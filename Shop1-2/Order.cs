using Shop.Enums;

namespace Shop;

public class Order
{
    private ICollection<OrderItem> Items { get; }

    private OrderStatus Status { get; set; } = OrderStatus.Open;

    public Order()
    {
        Items = new List<OrderItem>();
    }

    public void Add(OrderItem orderItem)
    {
        Validate(orderItem);
        Items.Add(orderItem);
    }
    
    public decimal GetTotal()
    {
        var total = Items.Sum(item => item.Price * item.Quantity);

        return total;
    }

    public string GetStatus()
    {
        return Status.ToString();
    }

    public void SetStatus(OrderStatus status)
    {
        Status = status;
    }

    private void Validate(OrderItem orderItem)
    {
        // if (item is null)
        // {
        //     throw new Exception();
        // }
    }
}