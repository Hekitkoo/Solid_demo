using Shop4_5.Enums;
using Shop4_5.Interfaces;

namespace Shop4_5.Payments;

public class DebitPayment : IPayment
{
    private readonly IEmailNotification emailNotification;

    public DebitPayment(IEmailNotification notification)
    {
        emailNotification = notification;
    }

    public void Pay(Order order)
    {
        Console.WriteLine("Processing debit payment");
        order.SetStatus(OrderStatus.Paid);
        Console.WriteLine("Processing debit complete");
        emailNotification.SendEmail(order);
    }
}