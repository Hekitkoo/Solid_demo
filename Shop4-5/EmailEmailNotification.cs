using Shop4_5.Interfaces;

namespace Shop4_5;

public class EmailEmailNotification : IEmailNotification
{
    public void SendEmail(Order order)
    {
        Console.WriteLine($"Email for order. Status: {order.GetStatus()}");
    }
}