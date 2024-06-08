using Microsoft.Extensions.Logging;

namespace LH.Messaging.InMemory;

public class InMemoryIntegrationEventBus(ILogger<InMemoryIntegrationEventBus> _logger,
    InMemoryMessageQueue _inMemoryMessageQueue)
    : IIntegrationEventBus
{
    public async Task PublishAsync(IIntegrationEvent integrationEvent)
    {
        _logger.LogDebug("Publishing event {@IntegrationEventId}", integrationEvent.Id);
        await _inMemoryMessageQueue.Writer.WriteAsync(integrationEvent);
        _logger.LogDebug("Event {@IntegrationEventId} published", integrationEvent.Id);
    }
}