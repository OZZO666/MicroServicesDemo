namespace Order.Common.Entities;

public class OrderDetail : BaseEntity
{
    public Guid ProductId { get; set; }
    public decimal Amount { get; set; }
    public int Version { get; set; }
}