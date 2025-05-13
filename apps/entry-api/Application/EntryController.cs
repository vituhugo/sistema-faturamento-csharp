using EntryApi.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EntryApi.Application;

[ApiController]
[Route("entry")]
public class EntryController(IEntryService service) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] EntryCreateDto dto)
    {
        await service.AddEntryAsync(dto);
        return CreatedAtAction(nameof(Get), new { }, dto);
    }

    [HttpGet]
    public async Task<IActionResult> Get(
        [FromQuery] EntryGetFilterDto? filters = null,
        [FromQuery] int page = 1,
        [FromQuery] int perPage = 15,
        [FromQuery] string orderBy = "date",
        [FromQuery] string orderByType = "desc"
    ) {
        var result = await service.GetPaginatedAsync(filters, page, perPage, orderBy, orderByType);
        return Ok(result);
    }
}