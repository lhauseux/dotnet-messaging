using MediatR;

namespace LH.Messaging;

public interface IQuery<out TResponse> : IRequest<TResponse>
{

}
