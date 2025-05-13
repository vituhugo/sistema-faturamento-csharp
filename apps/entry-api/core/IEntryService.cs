using EntryApi.core.DTOs;
using EntryApi.core.Models;

namespace EntryApi.core;

public interface IEntryService
{
    Task AddEntryAsync(EntryCreateDto dto);
    Task<PagedResultDto<Entry>> GetPaginatedAsync(EntryGetFilterDto? filters, int page, int pageSize, string orderBy, string orderByType);
}