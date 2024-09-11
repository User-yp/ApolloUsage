using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApolloUsage.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GetStringController(IConfiguration configuration) : ControllerBase
{
    private readonly IConfiguration configuration = configuration;

    [HttpGet]
    public async Task<ActionResult<string>> GetConfigurationAsync()
    {
        var res= configuration.GetSection("RabbitMQ").Value;
        return Ok(res);
    }
}
