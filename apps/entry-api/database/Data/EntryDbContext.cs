using EntryApi.core.Models;
using Microsoft.EntityFrameworkCore;

namespace EntryApi.database.Data;

public class EntryDbContext(DbContextOptions<EntryDbContext> options) : DbContext(options)
{
    public DbSet<Entry> Entries { get; set; }
}