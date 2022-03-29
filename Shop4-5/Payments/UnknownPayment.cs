using Shop4_5.Interfaces;

namespace Shop4_5.Payments;

public class UnknownPayment : IPayment
{
    public void Pay(Order order)
    {
        Console.WriteLine("Unsupported payment type");
    }
}