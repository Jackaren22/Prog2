using System;

namespace OOP_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please input your name customer");
            var kund = new Customer(Console.ReadLine()); // Variable för ny kund som man döper själv
            Console.WriteLine("Welcome " + kund._customerName + "!");

            while (true)
            {
                Console.WriteLine("Do you want to make a purchase?");
                if (Console.ReadLine().ToLower() == "yes") 
                {
                    Console.WriteLine("What kind of product would you like to purchase?");
                    Console.WriteLine("[1] Drink | [2] Food | [3] Snack");
                    var productselect = Convert.ToInt32(Console.ReadLine());
                    
                    switch (productselect)
                    {
                        case 1:
                            
                            Console.WriteLine("What kind of drink would you like to purchase?");
                            var drink = Console.ReadLine();
                            kund._cart.Add(new Drink() { _productName = drink }); //Försökte att ha Console.Readline(); istället för variablen direkt i koden men det funkade inte
                            break;

                        case 2:

                            Console.WriteLine("What kind of food would you like to purchase?");
                            var food = Console.ReadLine();
                            kund._cart.Add(new Food() { _productName = food });
                            break;

                        case 3:

                            Console.WriteLine("What kind of snack would you like to purchase?");
                            var snack = Console.ReadLine();
                            kund._cart.Add(new Snack() { _productName = snack });
                            break;


                    }

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
