using MediatR;

namespace LH.Messaging;

public interface IIntegrationEvent : INotification
{
    Guid Id { get; }
}
