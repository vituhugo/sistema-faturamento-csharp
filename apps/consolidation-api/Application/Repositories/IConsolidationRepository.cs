using ConsolidationApi.core.Models;

namespace ConsolidationApi.core.Repositories;

public interface IConsolidationRepository
{
    Task<Consolidation> AddAsync(Consolidation result);

    Task<DTOs.PagedResultDto<Consolidation>> GetPaginatedAsync(int page, int pageSize);

    Task<Consolidation?> GetLastAsync();
}