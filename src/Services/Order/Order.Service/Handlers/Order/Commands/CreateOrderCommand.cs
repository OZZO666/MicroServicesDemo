using MediatR;
using Order.Common.Dtos;

namespace Order.Service.Handlers.Order.Commands;

public class CreateOrderCommand : IRequest<Common.Entities.Order>
{
    public List<OrderDetailDto> OrderDetails { get; set; }
}
public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Common.Entities.Order>
{
    public async Task<Common.Entities.Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        return new Common.Entities.Order()
        {
            Id= Guid.NewGuid(),
            IsPaymentSuccessful = false,
        };
    }
}