using MediatR;

namespace Order.Service.Handlers.Order.Queries;

public class GetOrderQuery : IRequest<Common.Entities.Order>
{
    public Guid OrderId { get; set; }
}

public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, Common.Entities.Order>
{
    public async Task<Common.Entities.Order> Handle(GetOrderQuery request, CancellationToken cancellationToken)
    {
        return new Common.Entities.Order()
        {
            Id = request.OrderId,
            IsPaymentSuccessful = true
        };
    }
}