using MediatR;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LH.Messaging.InMemory;

public class IntegrationEventBackgroundService(ILogger<IntegrationEventBackgroundService> _logger,
    InMemoryMessageQueue _messageQueue,
    IPublisher _publisher) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await foreach (var integrationEvent in _messageQueue.Reader.ReadAllAsync(stoppingToken))
        {
            _logger.LogDebug("Processing event {@IntegrationEventId}", integrationEvent.Id);
            try
            {
                await _publisher.Publish(integrationEvent, stoppingToken);
                _logger.LogDebug("Event {@IntegrationEventId} processed", integrationEvent.Id);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while processing {@IntegrationEventId}.", integrationEvent.Id);
            }

        }
    }
}
