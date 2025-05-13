namespace ConsolidationApi.core.Models;

public class Consolidation
{
    public int Id { get; set; }
    
    public int NumberOfRecords { get; set; }
    
    public DateTime? PeriodStart { get; set; }
    
    public DateTime PeriodEnd { get; set; }

    public int StartsAtId { get; set; } = 0;

    public int? EndsAtId { get; set; } = 0;

    public DateTime Date { get; set; }
    public double TotalAmount { get; set; }
}