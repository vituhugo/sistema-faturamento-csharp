using Microsoft.AspNetCore.Mvc;

namespace ConsolidationApi.core;

[ApiController]
[Route("consolidation")]
public class ConsolidationController(IConsolidationService service) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Consolidate()
    {
        await service.ConsolidateAsync();
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] int page = 1, [FromQuery] int pageSize = 15)
    {
        var result = await service.GetResultsAsync(page, pageSize);
        return Ok(result);
    }
}