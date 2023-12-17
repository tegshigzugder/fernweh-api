using Microsoft.AspNetCore.Mvc;

namespace Controllers;
[ApiController]
[Route("[controller]")]
public class PlacesController : ControllerBase
{
    private readonly ILogger<PlacesController> _logger;

    public PlacesController(ILogger<PlacesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPlaces")]
    public void Get()
    {
        Console.WriteLine("Test");
    }
}
