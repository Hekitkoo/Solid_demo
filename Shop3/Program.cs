// See https://aka.ms/new-console-template for more information

using Shop3;
using Shop3.Enums;
using Shop3.Interfaces;
using Shop3.Payments;

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
var paymentFactory = new PaymentFactory();
IPayment payment = paymentFactory.Get(paymentType);

payment.Pay(order);

Console.WriteLine(order.GetStatus());
Console.ReadKey();

// is null
// not implemented 
// is or as check