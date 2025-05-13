using ConsolidationApi.core.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsolidationApi.Data;

public class EntryDbContext(DbContextOptions<EntryDbContext> options) : DbContext(options)
{
    public DbSet<Entry> Entries { get; set; }
}