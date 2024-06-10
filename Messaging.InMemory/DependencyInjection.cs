using Microsoft.Extensions.DependencyInjection;

namespace LH.Messaging.InMemory;

public static class DependencyInjection
{
    public static IServiceCollection AddInMemoryMessaging(this IServiceCollection services)
    {
        services.AddSingleton<InMemoryMessageQueue>();
        services.AddSingleton<IIntegrationEventBus, InMemoryIntegrationEventBus>();
        services.AddHostedService<IntegrationEventBackgroundService>();

        return services;
    }
}