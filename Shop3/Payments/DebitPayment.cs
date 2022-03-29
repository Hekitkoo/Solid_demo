using Shop3.Enums;
using Shop3.Interfaces;

namespace Shop3.Payments;

public class DebitPayment : IPayment
{
    public void Pay(Order order)
    {
        Console.WriteLine("Processing debit payment");
        order.SetStatus(OrderStatus.Paid);
        Console.WriteLine("Processing debit complete");
    }
}