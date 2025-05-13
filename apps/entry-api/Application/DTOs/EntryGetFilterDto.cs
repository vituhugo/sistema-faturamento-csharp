using EntryApi.Application.DTOs.Binders;
using Microsoft.AspNetCore.Mvc;

namespace EntryApi.Application.DTOs;

[ModelBinder(BinderType = typeof(GetEntryFilterBinder))]
public class EntryGetFilterDto
{
    [FromQuery(Name = "date")]
    public DateTime? Date { get; set; }

    [FromQuery(Name = "type")]
    public string? Type { get; set; }
}