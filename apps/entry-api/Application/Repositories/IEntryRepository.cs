using EntryApi.Application.DTOs;
using EntryApi.Application.Models;

namespace EntryApi.Application.Repositories;

public interface IEntryRepository
{
    Task AddAsync(Entry entry);
    
    Task<PagedResultDto<Entry>> GetPaginatedAsync(EntryGetFilterDto? filters, int page, int pageSize, string orderBy,
        string orderByType);
}