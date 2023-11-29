namespace KeyedServices.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services.Robots;

    [ApiController]
    [Route("[controller]")]
    public class RobotController([FromKeyedServices("plc-client")] IRobotClient plcRobotClient,
            [FromKeyedServices("tcp-client")] IRobotClient tcpRobotClient)
        : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get(bool useTCP)
        {
            if (useTCP)
            {
                await tcpRobotClient.SendStartCommandAsync();
            }
            else
            {
                await plcRobotClient.SendStartCommandAsync();
            }

            return Ok();
        }
    }
}
