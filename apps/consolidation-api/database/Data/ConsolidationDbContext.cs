using ConsolidationApi.core.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsolidationApi.Data;

public class ConsolidationDbContext(DbContextOptions<ConsolidationDbContext> options) : DbContext(options)
{
    public DbSet<Consolidation> Consolidations { get; set; }
}