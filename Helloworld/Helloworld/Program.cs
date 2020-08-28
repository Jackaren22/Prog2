using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Nikklas!");

            Console.WriteLine("Please input your age.");
            string Age = Console.ReadLine();

            Console.WriteLine("Now input your name.");
            string Name = Console.ReadLine();

            Console.WriteLine("And lastly, are you currently alive? (Yes or No)");
            string Alive = Console.ReadLine();

            Console.WriteLine("You are " + Age + " years old | " + "Your name is " + Name + " | Currently Alive? " + Alive);

            Console.WriteLine("BONUS: Input two different Numbers and i will tell you which one is the largest one. ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            int Number2 = Convert.ToInt32(Console.ReadLine());
            Convert.ToInt32(Number1);

            Console.WriteLine(Math.Max(Number1, Number2) + "Is the largest number");



        }
    }
}
