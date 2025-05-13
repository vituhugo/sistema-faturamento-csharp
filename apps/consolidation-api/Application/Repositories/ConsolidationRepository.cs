using ConsolidationApi.core.DTOs;
using ConsolidationApi.core.Models;
using ConsolidationApi.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsolidationApi.core.Repositories;

public class ConsolidationRepository(ConsolidationDbContext context) : IConsolidationRepository
{
    public async Task<Consolidation> AddAsync(Consolidation result)
    {
        context.Consolidations.Add(result);
        await context.SaveChangesAsync();

        return result;
    }

    public async Task<PagedResultDto<Consolidation>> GetPaginatedAsync(int page, int pageSize)
    {
        IQueryable<Consolidation> query = context.Consolidations;

        var totalItems = await query.CountAsync();
        var items = await query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PagedResultDto<Consolidation>
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

    public async Task<Consolidation?> GetLastAsync()
    {
        return await context.Consolidations.OrderByDescending(l => l.PeriodEnd).FirstOrDefaultAsync();
    }
}