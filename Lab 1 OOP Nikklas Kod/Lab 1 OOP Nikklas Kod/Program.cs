using System;

namespace Lab_1_OOP_Nikklas_Kod
{
    class Program
    {
        static void Main(string[] args)
        {
            var kund = new Customer(); // Variable för ny kund
            while (true)
            {
                Console.WriteLine("Do you want to make a purchase?");
                if (Console.ReadLine().ToLower() == "yes") 
                {
                    Console.WriteLine("What do you want to buy?");
                    kund._cart.Add(new Product() { _productName = Console.ReadLine() }); // Här skapas en produkt som använderen själv skapar.
                }
                else
                   break;

                Console.WriteLine("Do you want to view your cart?");
                if (Console.ReadLine().ToLower() == "yes")
                    foreach (var item in kund._cart)  // För varje item(Produkt) i kundvagnen kommer den att skriva ut alla produkter i arrayen.
                        Console.WriteLine(item._productName);
                else
                    Console.WriteLine("Why would you not check your cart... D:");
                    Console.WriteLine();

            }
        }
    }
}
