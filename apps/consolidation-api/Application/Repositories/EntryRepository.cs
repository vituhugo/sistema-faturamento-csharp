using ConsolidationApi.core.DTOs;
using ConsolidationApi.core.Models;
using ConsolidationApi.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsolidationApi.core.Repositories;

public class EntryRepository(EntryDbContext context) : IEntryRepository
{
    public async Task<PagedResultDto<Entry>> GetPagedAsync(int page, int pageSize, DateTime periodStart, DateTime periodEnd)
    {
        IQueryable<Entry> query = context.Entries;

        var totalItems = await query
            .Where(l =>
                l.Date >= periodStart && l.Date <= periodEnd)
            .CountAsync();

        var items = await query
            .Where(l =>
                l.Date >= periodStart && l.Date <= periodEnd)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PagedResultDto<Entry>
        {
            Items = items,
            Metadata = new PagedResultMetadataDto
            {
                CurrentPage = page,
                PageSize = pageSize,
                TotalItems = totalItems,
                TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize),
            }
        };
    }
}