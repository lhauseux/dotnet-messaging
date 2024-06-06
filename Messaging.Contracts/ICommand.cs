using MediatR;

namespace HT.Messaging;

public interface ICommand<out TResponse> : IRequest<TResponse>
{

}
