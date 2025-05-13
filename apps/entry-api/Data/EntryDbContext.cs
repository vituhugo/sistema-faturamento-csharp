using EntryApi.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace EntryApi.Data;

public class EntryDbContext(DbContextOptions<EntryDbContext> options) : DbContext(options)
{
    public DbSet<Entry> Entries { get; set; }
}