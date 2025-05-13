using EntryApi.core.DTOs;
using EntryApi.core.Models;
using EntryApi.database.Data;
using Microsoft.EntityFrameworkCore;

namespace EntryApi.core.Repositories;

public class EntryRepository(EntryDbContext context) : IEntryRepository
{
    public async Task AddAsync(Entry entry)
    {
        context.Entries.Add(entry);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Entry>> GetAllAsync()
    {
        return await context.Entries.ToListAsync();
    }

    public async Task<PagedResultDto<Entry>> GetPaginatedAsync(EntryGetFilterDto? filters, int page, int pageSize,
        string orderBy, string orderByType)
    {
        IQueryable<Entry> query = context.Entries;

        if (filters != null)
        {
            if (filters.Date != null)
            {
                var startDate = filters.Date.Value.Date.ToUniversalTime();
                var endDate = startDate.AddDays(1).AddTicks(-1).ToUniversalTime();
                query = query.Where(l =>
                    l.Date >= startDate && l.Date <= endDate);
            }

            if (filters.Type != null)
            {
                query = query.Where(l => l.Type == filters.Type);
            }
        }
        // Ordenação dinâmica
        query = (orderBy.ToLower(), orderByType.ToLower()) switch
        {
            ("date", "desc") => query.OrderByDescending(x => x.Date),
            ("date", "asc") => query.OrderBy(x => x.Date),
            ("amount", "desc") => query.OrderByDescending(x => x.Amount),
            ("amount", "asc") => query.OrderBy(x => x.Amount),
            _ => query.OrderByDescending(x => x.Date)
        };

        var totalItems = await query.CountAsync();
        var items = await query
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