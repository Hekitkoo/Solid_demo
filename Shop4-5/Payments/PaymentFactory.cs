using Shop4_5.Enums;
using Shop4_5.Interfaces;

namespace Shop4_5.Payments;

public class PaymentFactory : IPaymentFactory
{
    private IEmailNotification notification;

    public PaymentFactory(IEmailNotification notification)
    {
        this.notification = notification;
    }
    public IPayment Get(PaymentType paymentType)
    {
        switch (paymentType)
        {
            case PaymentType.Credit:
                return new CreditPayment(notification);
            case PaymentType.Debit:
                return new DebitPayment(notification);
            default:
                return new UnknownPayment();
        }
    }
}