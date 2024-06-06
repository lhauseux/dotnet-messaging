namespace HT.Messaging;

public interface IIntegrationEventBus
{
    void Publish(IIntegrationEvent integrationEvent);
}
