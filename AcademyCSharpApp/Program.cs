//PROJECT: SMART CART TOTAL CALCULATOR
double[] cartItems={19.99,45.50,12.00,99.99};
double totalSum=0.00;
Console.WriteLine("Iterating through your cart items...");
Console.WriteLine("-------------------------------------");
foreach(double price in cartItems)
{
    Console.WriteLine($"Item found in cart: ${price}");
    totalSum=totalSum + price;
}
Console.WriteLine("-------------------------------------");
Console.WriteLine($"Calculated Total: ${totalSum}");