namespace KeyedServices.Services.Robots
{
    using Microsoft.Extensions.Logging;

    public class TCPRobotClient(ILogger<TCPRobotClient> logger) : IRobotClient
    {
        public async Task SendStartCommandAsync()
        {
            await Task.Delay(100);

            logger.LogInformation("Sending via TCP client");
        }
    }
}
