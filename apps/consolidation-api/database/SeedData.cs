using ConsolidationApi.core.Models;
using ConsolidationApi.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsolidationApi.database;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new ConsolidationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ConsolidationDbContext>>());
        if (context.Consolidations.Any())
        {
            return;   // DB has been seeded
        }
        context.Consolidations.AddRange(
            new Consolidation { TotalAmount = 3640.59, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-04-01T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-02T00:00:00").ToUniversalTime(), StartsAtId = 1, EndsAtId = 4 },
            new Consolidation { TotalAmount = 6429.23, NumberOfRecords = 6, PeriodStart = DateTime.Parse("2025-04-02T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-03T00:00:00").ToUniversalTime(), StartsAtId = 5, EndsAtId = 10 },
            new Consolidation { TotalAmount = 4897.48, NumberOfRecords = 2, PeriodStart = DateTime.Parse("2025-04-03T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-04T00:00:00").ToUniversalTime(), StartsAtId = 11, EndsAtId = 12 },
            new Consolidation { TotalAmount = 2431.8, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-04-04T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-05T00:00:00").ToUniversalTime(), StartsAtId = 13, EndsAtId = 16 },
            new Consolidation { TotalAmount = 8833.1, NumberOfRecords = 6, PeriodStart = DateTime.Parse("2025-04-05T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-06T00:00:00").ToUniversalTime(), StartsAtId = 17, EndsAtId = 22 },
            new Consolidation { TotalAmount = 6563.38, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-04-06T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-07T00:00:00").ToUniversalTime(), StartsAtId = 23, EndsAtId = 26 },
            new Consolidation { TotalAmount = 8844.87, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-04-07T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-08T00:00:00").ToUniversalTime(), StartsAtId = 27, EndsAtId = 29 },
            new Consolidation { TotalAmount = 1674.33, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-04-08T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-09T00:00:00").ToUniversalTime(), StartsAtId = 30, EndsAtId = 32 },
            new Consolidation { TotalAmount = 4309.51, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-04-09T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-10T00:00:00").ToUniversalTime(), StartsAtId = 33, EndsAtId = 36 },
            new Consolidation { TotalAmount = 9405.02, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-04-10T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-11T00:00:00").ToUniversalTime(), StartsAtId = 37, EndsAtId = 40 },
            new Consolidation { TotalAmount = 7689.87, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-04-11T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-12T00:00:00").ToUniversalTime(), StartsAtId = 41, EndsAtId = 43 },
            new Consolidation { TotalAmount = 9107.89, NumberOfRecords = 5, PeriodStart = DateTime.Parse("2025-04-12T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-13T00:00:00").ToUniversalTime(), StartsAtId = 44, EndsAtId = 48 },
            new Consolidation { TotalAmount = 9619.98, NumberOfRecords = 6, PeriodStart = DateTime.Parse("2025-04-13T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-14T00:00:00").ToUniversalTime(), StartsAtId = 49, EndsAtId = 54 },
            new Consolidation { TotalAmount = 4389.36, NumberOfRecords = 5, PeriodStart = DateTime.Parse("2025-04-14T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-15T00:00:00").ToUniversalTime(), StartsAtId = 55, EndsAtId = 59 },
            new Consolidation { TotalAmount = 9495.5, NumberOfRecords = 5, PeriodStart = DateTime.Parse("2025-04-15T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-16T00:00:00").ToUniversalTime(), StartsAtId = 60, EndsAtId = 64 },
            new Consolidation { TotalAmount = 7464.83, NumberOfRecords = 2, PeriodStart = DateTime.Parse("2025-04-16T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-17T00:00:00").ToUniversalTime(), StartsAtId = 65, EndsAtId = 66 },
            new Consolidation { TotalAmount = 8542.11, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-04-17T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-18T00:00:00").ToUniversalTime(), StartsAtId = 67, EndsAtId = 69 },
            new Consolidation { TotalAmount = 8796.43, NumberOfRecords = 5, PeriodStart = DateTime.Parse("2025-04-18T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-19T00:00:00").ToUniversalTime(), StartsAtId = 70, EndsAtId = 74 },
            new Consolidation { TotalAmount = 1825.46, NumberOfRecords = 6, PeriodStart = DateTime.Parse("2025-04-19T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-20T00:00:00").ToUniversalTime(), StartsAtId = 75, EndsAtId = 80 },
            new Consolidation { TotalAmount = 9915.91, NumberOfRecords = 5, PeriodStart = DateTime.Parse("2025-04-20T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-21T00:00:00").ToUniversalTime(), StartsAtId = 81, EndsAtId = 85 },
            new Consolidation { TotalAmount = 7269.92, NumberOfRecords = 6, PeriodStart = DateTime.Parse("2025-04-21T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-22T00:00:00").ToUniversalTime(), StartsAtId = 86, EndsAtId = 91 },
            new Consolidation { TotalAmount = 3839.67, NumberOfRecords = 6, PeriodStart = DateTime.Parse("2025-04-22T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-23T00:00:00").ToUniversalTime(), StartsAtId = 92, EndsAtId = 97 },
            new Consolidation { TotalAmount = 4711.81, NumberOfRecords = 2, PeriodStart = DateTime.Parse("2025-04-23T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-24T00:00:00").ToUniversalTime(), StartsAtId = 98, EndsAtId = 99 },
            new Consolidation { TotalAmount = 1981.74, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-04-24T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-25T00:00:00").ToUniversalTime(), StartsAtId = 100, EndsAtId = 102 },
            new Consolidation { TotalAmount = 7260.11, NumberOfRecords = 5, PeriodStart = DateTime.Parse("2025-04-25T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-26T00:00:00").ToUniversalTime(), StartsAtId = 103, EndsAtId = 107 },
            new Consolidation { TotalAmount = 5440.65, NumberOfRecords = 2, PeriodStart = DateTime.Parse("2025-04-26T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-27T00:00:00").ToUniversalTime(), StartsAtId = 108, EndsAtId = 109 },
            new Consolidation { TotalAmount = 7621.91, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-04-27T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-28T00:00:00").ToUniversalTime(), StartsAtId = 110, EndsAtId = 113 },
            new Consolidation { TotalAmount = 3574.6, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-04-28T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-29T00:00:00").ToUniversalTime(), StartsAtId = 114, EndsAtId = 116 },
            new Consolidation { TotalAmount = 8544.34, NumberOfRecords = 6, PeriodStart = DateTime.Parse("2025-04-29T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-04-30T00:00:00").ToUniversalTime(), StartsAtId = 117, EndsAtId = 122 },
            new Consolidation { TotalAmount = 7477.41, NumberOfRecords = 2, PeriodStart = DateTime.Parse("2025-04-30T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-01T00:00:00").ToUniversalTime(), StartsAtId = 123, EndsAtId = 124 },
            new Consolidation { TotalAmount = 2265.99, NumberOfRecords = 5, PeriodStart = DateTime.Parse("2025-05-01T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-02T00:00:00").ToUniversalTime(), StartsAtId = 125, EndsAtId = 129 },
            new Consolidation { TotalAmount = 4855.25, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-05-02T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-03T00:00:00").ToUniversalTime(), StartsAtId = 130, EndsAtId = 132 },
            new Consolidation { TotalAmount = 2400.26, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-05-03T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-04T00:00:00").ToUniversalTime(), StartsAtId = 133, EndsAtId = 135 },
            new Consolidation { TotalAmount = 4224.52, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-05-04T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-05T00:00:00").ToUniversalTime(), StartsAtId = 136, EndsAtId = 139 },
            new Consolidation { TotalAmount = 4003.75, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-05-05T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-06T00:00:00").ToUniversalTime(), StartsAtId = 140, EndsAtId = 143 },
            new Consolidation { TotalAmount = 4187.55, NumberOfRecords = 6, PeriodStart = DateTime.Parse("2025-05-06T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-07T00:00:00").ToUniversalTime(), StartsAtId = 144, EndsAtId = 149 },
            new Consolidation { TotalAmount = 4552.99, NumberOfRecords = 5, PeriodStart = DateTime.Parse("2025-05-07T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-08T00:00:00").ToUniversalTime(), StartsAtId = 150, EndsAtId = 154 },
            new Consolidation { TotalAmount = 6472.73, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-05-08T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-09T00:00:00").ToUniversalTime(), StartsAtId = 155, EndsAtId = 158 },
            new Consolidation { TotalAmount = 6952.87, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-05-09T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-10T00:00:00").ToUniversalTime(), StartsAtId = 159, EndsAtId = 161 },
            new Consolidation { TotalAmount = 7409.48, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-05-10T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-11T00:00:00").ToUniversalTime(), StartsAtId = 162, EndsAtId = 164 },
            new Consolidation { TotalAmount = 9036.19, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-05-11T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-12T00:00:00").ToUniversalTime(), StartsAtId = 165, EndsAtId = 167 },
            new Consolidation { TotalAmount = 7414.78, NumberOfRecords = 2, PeriodStart = DateTime.Parse("2025-05-12T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-13T00:00:00").ToUniversalTime(), StartsAtId = 168, EndsAtId = 169 },
            new Consolidation { TotalAmount = 2158.72, NumberOfRecords = 5, PeriodStart = DateTime.Parse("2025-05-13T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-14T00:00:00").ToUniversalTime(), StartsAtId = 170, EndsAtId = 174 },
            new Consolidation { TotalAmount = 2713.32, NumberOfRecords = 3, PeriodStart = DateTime.Parse("2025-05-14T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-15T00:00:00").ToUniversalTime(), StartsAtId = 175, EndsAtId = 177 },
            new Consolidation { TotalAmount = 1485.17, NumberOfRecords = 5, PeriodStart = DateTime.Parse("2025-05-15T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-16T00:00:00").ToUniversalTime(), StartsAtId = 178, EndsAtId = 182 },
            new Consolidation { TotalAmount = 7444.65, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-05-16T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-17T00:00:00").ToUniversalTime(), StartsAtId = 183, EndsAtId = 186 },
            new Consolidation { TotalAmount = 705.63, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-05-17T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-18T00:00:00").ToUniversalTime(), StartsAtId = 187, EndsAtId = 190 },
            new Consolidation { TotalAmount = 5720.35, NumberOfRecords = 6, PeriodStart = DateTime.Parse("2025-05-18T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-19T00:00:00").ToUniversalTime(), StartsAtId = 191, EndsAtId = 196 },
            new Consolidation { TotalAmount = 5569.61, NumberOfRecords = 6, PeriodStart = DateTime.Parse("2025-05-19T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-20T00:00:00").ToUniversalTime(), StartsAtId = 197, EndsAtId = 202 },
            new Consolidation { TotalAmount = 8256.86, NumberOfRecords = 4, PeriodStart = DateTime.Parse("2025-05-20T00:00:00").ToUniversalTime(), PeriodEnd = DateTime.Parse("2025-05-21T00:00:00").ToUniversalTime(), StartsAtId = 203, EndsAtId = 206 }
        );
        context.SaveChanges();
    }
}