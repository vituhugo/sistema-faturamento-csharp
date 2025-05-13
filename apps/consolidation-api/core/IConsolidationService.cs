using ConsolidationApi.core.DTOs;
using ConsolidationApi.core.Models;

namespace ConsolidationApi.core;

public interface IConsolidationService
{
    Task<Consolidation> ConsolidateAsync();
    Task<PagedResultDto<Consolidation>> GetResultsAsync(int page, int pageSize);
}