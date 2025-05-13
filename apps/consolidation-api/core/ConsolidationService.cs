using ConsolidationApi.core.Models;
using ConsolidationApi.core.Repositories;

namespace ConsolidationApi.core;

public class ConsolidationService(
    IConsolidationRepository repo,
    IEntryRepository entryRepo
    ) : IConsolidationService
{
    public async Task<Consolidation> ConsolidateAsync()
    {
        var consolidation = await repo.GetLastAsync();

        var newConsolidation = new Consolidation
        {
            PeriodStart = consolidation?.PeriodEnd  ?? new DateTime(2024, 1, 1),
            PeriodEnd = DateTime.UtcNow.Date - TimeSpan.FromHours(1),
            Date = DateTime.UtcNow.Date,
        };

        var result = await entryRepo.GetPagedAsync(1, 0, (DateTime)newConsolidation.PeriodStart, newConsolidation.PeriodEnd);
        var maxPage = Math.Ceiling((double)result.Metadata.TotalItems / 400);

        for (var page = 1; page <= maxPage; ++page)
        {
            var pagedItems = await entryRepo.GetPagedAsync(page, 400, (DateTime)newConsolidation.PeriodStart, newConsolidation.PeriodEnd);
            var entriesList = pagedItems.Items;
            
            newConsolidation.NumberOfRecords += entriesList.Count;
            newConsolidation.StartsAtId = newConsolidation.StartsAtId == 0 ? entriesList.First().Id : newConsolidation.StartsAtId;
            newConsolidation.EndsAtId = entriesList.Last().Id;
            newConsolidation.TotalAmount += entriesList.Sum(l => l.Type == "credito" ? l.Amount : -l.Amount);
        }

        return await repo.AddAsync(newConsolidation);
    }

    public async Task<DTOs.PagedResultDto<Consolidation>> GetResultsAsync(int page, int pageSize)
    {
        return await repo.GetPaginatedAsync(page, pageSize);
    }
}