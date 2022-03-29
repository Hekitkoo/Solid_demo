using Shop3.Enums;
using Shop3.Interfaces;

namespace Shop3.Payments;

public class CreditPayment : IPayment
{
    public void Pay(Order order)
    {
        Console.WriteLine("Processing credit payment");
        order.SetStatus(OrderStatus.Paid);
        Console.WriteLine("Processing credit complete");
    }
}