// PROJECT: SHIFTING TO METHODS
double shoesPrice = 120.00;
double discountRate = 0.15;
double discountAmount = CalculateDiscount(shoesPrice, discountRate);
double discountedPrice = shoesPrice - discountAmount;
double taxAmount = CalculateTax(discountedPrice);
double finalTotal = discountedPrice + taxAmount;
PrintReceipt(shoesPrice, discountAmount, taxAmount, finalTotal);
static double CalculateDiscount(double price,double rate)
{
  return price * rate;
}
static double CalculateTax(double price)
{
    double taxRate = 0.18;
    return price * taxRate;
}
static void PrintReceipt(double original,double discount,double tax,double total)
{
    Console.WriteLine("=== RECEIPT WITH METHODS ===");
    Console.WriteLine($"Original Price: ${original}");
    Console.WriteLine($"Discount Amount: -${discount}");
    Console.WriteLine($"Tax (18%): ${tax}");
    Console.WriteLine("----------------------------");
    Console.WriteLine($"GRAND TOTAL: ${total}");
    Console.WriteLine("============================");
}
