using Shop3.Enums;
using Shop3.Interfaces;

namespace Shop3.Payments;

public class PaymentFactory
{
    public IPayment Get(PaymentType paymentType)
    {
        switch (paymentType)
        {
            case PaymentType.Credit:
                return new CreditPayment();
            case PaymentType.Debit:
                return new DebitPayment();
            default:
                return new UnsupportedPayment();
        }
    }
}