using EntryApi.core.DTOs;
using EntryApi.core.Models;

namespace EntryApi.core.Repositories;

public interface IEntryRepository
{
    Task AddAsync(Entry entry);
    Task<IEnumerable<Entry>> GetAllAsync();
    
    Task<PagedResultDto<Entry>> GetPaginatedAsync(EntryGetFilterDto? filters, int page, int pageSize, string orderBy,
        string orderByType);
}