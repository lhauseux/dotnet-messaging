using MediatR;

namespace HT.Messaging;

public interface IIntegrationEvent : INotification
{
    Guid Id { get; }
}
