using MediatR;

namespace HT.Messaging;

public interface IQuery<out TResponse> : IRequest<TResponse>
{

}
