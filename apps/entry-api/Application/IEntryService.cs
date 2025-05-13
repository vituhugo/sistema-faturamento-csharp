using EntryApi.Application.DTOs;
using EntryApi.Application.Models;

namespace EntryApi.Application;

public interface IEntryService
{
    Task AddEntryAsync(EntryCreateDto dto);
    Task<PagedResultDto<Entry>> GetPaginatedAsync(EntryGetFilterDto? filters, int page, int pageSize, string orderBy, string orderByType);
}