using FernwehApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Controllers;
[ApiController]
[Route("[controller]")]
public class PlacesController : ControllerBase
{
    private readonly ILogger<PlacesController> _logger;
    private readonly IPlacesService _placesService;

    public PlacesController(ILogger<PlacesController> logger, IPlacesService placesService)
    {
        _logger = logger;
        _placesService = placesService;
    }

    [HttpGet(Name = "onGet")]
    public void OnGet()
    {
        _placesService.OnGet();
    }
}
