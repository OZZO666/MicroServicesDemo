using Order.Common.Entities;

namespace Order.Common.Dtos;

public class OrderDto
{
    public List<OrderDetailDto> OrderDetails { get; set; }
}