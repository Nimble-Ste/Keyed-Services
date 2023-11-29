namespace KeyedServices.Services.Robots;

public interface IRobotClient
{
    Task SendStartCommandAsync();
}