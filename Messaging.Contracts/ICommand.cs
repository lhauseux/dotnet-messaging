using MediatR;

namespace LH.Messaging;

public interface ICommand<out TResponse> : IRequest<TResponse>
{

}
