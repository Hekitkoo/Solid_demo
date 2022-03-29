// See https://aka.ms/new-console-template for more information

using Shop4_5;
using Shop4_5.Enums;
using Shop4_5.Interfaces;
using Shop4_5.Payments;

const PaymentType paymentType = PaymentType.Debit;
var order = new Order();
var item = new OrderItem
{
    Price = 1,
    Quantity = 2
};

order.Add(item);

Console.WriteLine(order.GetTotal());
Console.WriteLine(order.GetStatus());

IPaymentFactory paymentFactory = new PaymentFactory(new EmailEmailNotification());

IPayment payment = paymentFactory.Get(paymentType);
payment.Pay(order);

Console.ReadKey();