using Shop.Enums;

namespace Shop;

public class Payment
{
    public void Pay(Order order, PaymentType paymentType)
    {
        switch (paymentType)
        {
            case PaymentType.Credit:
                Console.WriteLine("Processing credit payment");
                order.SetStatus(OrderStatus.Paid);
                Console.WriteLine("Processing credit complete");
                break;
            case PaymentType.Debit:
                Console.WriteLine("Processing debit payment");
                order.SetStatus(OrderStatus.Paid);
                Console.WriteLine("Processing debit complete");
                break;
            default:
                Console.WriteLine("Unknown payment type");
                break;
        }
    }
}