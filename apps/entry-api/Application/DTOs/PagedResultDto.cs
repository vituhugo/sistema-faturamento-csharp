﻿using System.Text.Json.Serialization;

namespace EntryApi.Application.DTOs;

public class PagedResultDto<T>
{
    [property: JsonPropertyName("items")]
    public required List<T> Items { get; set; }
    
    [property: JsonPropertyName("metadata")]
    public required PagedResultMetadataDto Metadata { get; set; }
}