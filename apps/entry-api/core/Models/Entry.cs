namespace EntryApi.core.Models;

public class Entry
{
    public int Id { get; set; }
    public double Amount { get; set; }
    public string Type { get; set; } // "credito" or "debito"
    public DateTime Date { get; set; }

    public string Description { get; set; }
}