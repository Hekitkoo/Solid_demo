using Shop4_5.Enums;

namespace Shop4_5.Interfaces;

public interface IPaymentFactory
{
    IPayment Get(PaymentType paymentType);
}