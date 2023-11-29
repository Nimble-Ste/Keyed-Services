namespace KeyedServices.Services.Robots
{
    using Microsoft.Extensions.Logging;

    public class PLCRobotClient(ILogger<PLCRobotClient> logger) : IRobotClient
    {
        public async Task SendStartCommandAsync()
        {
            await Task.Delay(100);

            logger.LogInformation("Sending via PLC client");
        }
    }
}
