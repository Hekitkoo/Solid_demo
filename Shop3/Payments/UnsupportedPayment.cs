using Shop3.Interfaces;

namespace Shop3.Payments;

public class UnsupportedPayment : IPayment
{
    public void Pay(Order order)
    {
        Console.WriteLine("Unsupported payment type");
    }
}