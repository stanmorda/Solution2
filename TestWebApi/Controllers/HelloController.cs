using Microsoft.AspNetCore.Mvc;

namespace TestWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class Hello123Controller : ControllerBase
{
    [HttpGet]
    public OkObjectResult Hello()
    {
        return Ok(1);
    }
}