using EntryApi.core.DTOs;
using EntryApi.core.Models;
using EntryApi.core.Repositories;

namespace EntryApi.core;

public class EntryService(IEntryRepository repo) : IEntryService
{
    public async Task AddEntryAsync(EntryCreateDto dto)
    {
        var lanc = new Entry
        {
            Amount = dto.Amount,
            Type = dto.Type,
            Date = dto.Date,
            Description = dto.Description,
        };
        await repo.AddAsync(lanc);
    }

    public async Task<PagedResultDto<Entry>> GetPaginatedAsync(EntryGetFilterDto? filters, int page, int pageSize, string orderBy, string orderByType)
    {
        return await repo.GetPaginatedAsync(filters, page, pageSize, orderBy, orderByType);
    }
}