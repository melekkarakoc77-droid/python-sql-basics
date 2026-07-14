// PROJECT: MY FIRST OOP CLASS & OBJECT
Product product1 = new Product();
product1.id = 1;
product1.name="wireless mouse";
product1.price=29.99;
Product product2 = new Product();
product2.id=2;
product2.name="mechanical keyboard";
product2.price=89.99;
Console.WriteLine("=== PRODUCT LIST FROM OOP ===");
Console.WriteLine($"product1: {product1.name} costs {product1.price}");
Console.WriteLine($"product2 : {product2.name} costs {product2.price}");
class Product
{
    public int id;
    public string name="";
    public double price;
}