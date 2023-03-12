using Microsoft.AspNetCore.Mvc;

namespace breakfastRestApi.Controllers;

public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}