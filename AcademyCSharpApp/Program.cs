// PROJECT: SMART SHIPPING & DISCOUNT SYSTEM 
using System.Diagnostics.CodeAnalysis;

double cartTotal=120.00;
double finalTotal=cartTotal;
double shippingCost=0.00;
Console.WriteLine("original cart total: ${cartTotal}");
Console.WriteLine("---------------------------------");
if (cartTotal>=100.00)
{
    Console.WriteLine("condition met:cart is $100 or more");
    Console.WriteLine("result:you got %10 dicount and free shipping");
    double discount=cartTotal * 0.10;
    finalTotal=cartTotal - discount;
}
else if(cartTotal>=50.00)
{
    Console.WriteLine("condition met:cart s between $50 and $100");
    Console.WriteLine("result:you got free shipping");
}
else
{
    Console.WriteLine("condition met:cart is under $50");
    Console.WriteLine("result:shipping cost is $9.99");

    shippingCost=9.99;
    finalTotal=cartTotal+shippingCost;
}
Console.WriteLine("--------------------------------");
Console.WriteLine($"Shipping Cost: ${shippingCost}");
Console.WriteLine($"YOUR FINAL TOTAL IS: ${finalTotal}");
