double totalAllProducts = 0;
int choice = 1;
while (choice != 0)
{
    Console.WriteLine("Enter the Price: ");
    double price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the quantity: ");
    double quantity = Convert.ToDouble(Console.ReadLine());
    double total = price * quantity;
    Console.WriteLine($"The total is: {total}");
    totalAllProducts += total;
    Console.WriteLine("1-  Add another product");
    Console.WriteLine("0-  Stop");
    Console.WriteLine("Enter your choise : ");
    choice = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"The final Total is {totalAllProducts}");