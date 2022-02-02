using Microsoft.AspNetCore.Mvc;
using Shared;

namespace ControllerApi.Controllers;

[ApiController]
[Route("~/fibonacci")]
public class FibonacciController : ControllerBase
{
    private readonly FibonacciService _service;

    public FibonacciController(FibonacciService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var items = await _service.GetItemsAsync();
        return Ok(items);
    }
}