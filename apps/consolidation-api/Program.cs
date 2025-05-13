using System.Text.Json;
using ConsolidationApi.core;
using ConsolidationApi.core.Repositories;
using ConsolidationApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DB Context
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.WithOrigins("*");
        });
});

// DB Context
builder.Services.AddDbContext<ConsolidationDbContext>(
    options => options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

// DB Context
builder.Services.AddDbContext<EntryDbContext>(
    options => options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection2") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

builder.Services.AddScoped<IConsolidationService, ConsolidationService>();
builder.Services.AddScoped<IConsolidationRepository, ConsolidationRepository>();
builder.Services.AddScoped<IEntryRepository, EntryRepository>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ConsolidationDbContext>();

    // Check and apply pending migrations
    var pendingMigrations = dbContext.Database.GetPendingMigrations();
    if (pendingMigrations.Any())
    {
        Console.WriteLine("Applying pending migrations...");
        dbContext.Database.Migrate();
        Console.WriteLine("Migrations applied successfully.");
    }
    else
    {
        Console.WriteLine("No pending migrations found.");
    }

    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
    
    
    if (args.Contains("consolidate"))
    {
        var task = scope.ServiceProvider.GetRequiredService<IConsolidationService>();
        var _logger = scope.ServiceProvider.GetRequiredService<ILogger<IConsolidationService>>();
        _logger.LogInformation("Starting consolidation...");

        var consolidation = await task.ConsolidateAsync();
        _logger.LogInformation("Consolidation Finished: {consolidation}", JsonSerializer.Serialize(consolidation));

        return;
    }
}

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();