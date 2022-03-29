using Shop4_5.Enums;
using Shop4_5.Interfaces;

namespace Shop4_5.Payments;

public class CreditPayment : IPayment
{
    private readonly IEmailNotification emailNotification;
    
    public CreditPayment(IEmailNotification notification)
    {
        emailNotification = notification;
    }

    public void Pay(Order order)
    {
        Console.WriteLine("Processing credit payment");
        order.SetStatus(OrderStatus.Paid);
        Console.WriteLine("Processing credit complete");
        emailNotification.SendEmail(order);
    }
}