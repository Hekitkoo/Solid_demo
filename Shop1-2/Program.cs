// See https://aka.ms/new-console-template for more information

using Shop;
using Shop.Enums;

var order = new Order();
var item = new OrderItem
{
    Price = 1,
    Quantity = 2
};

order.Add(item);

Console.WriteLine(order.GetTotal());
Console.WriteLine(order.GetStatus());
var payment = new Payment();
payment.Pay(order, PaymentType.Debit);
Console.WriteLine(order.GetStatus());
Console.ReadKey();