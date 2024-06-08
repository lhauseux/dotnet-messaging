namespace LH.Messaging;

public interface IIntegrationEventBus
{
    Task PublishAsync(IIntegrationEvent integrationEvent);
}
