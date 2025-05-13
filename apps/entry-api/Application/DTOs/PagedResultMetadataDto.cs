using System.Text.Json.Serialization;

namespace EntryApi.Application.DTOs;

public class PagedResultMetadataDto
{
    [property: JsonPropertyName("page")]
    public int CurrentPage { get; set; }
    
    [property: JsonPropertyName("perPage")]
    public int PageSize { get; set; }
    
    [property: JsonPropertyName("total")]
    public int TotalItems { get; set; }
    
    [property: JsonPropertyName("lastPage")]
    public int TotalPages { get; set; }
}