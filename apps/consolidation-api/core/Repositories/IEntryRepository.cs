using ConsolidationApi.core.DTOs;
using ConsolidationApi.core.Models;

namespace ConsolidationApi.core.Repositories;

public interface IEntryRepository
{
    public Task<PagedResultDto<Entry>> GetPagedAsync(int page, int pageSize, DateTime periodStart,
        DateTime periodEnd);
}