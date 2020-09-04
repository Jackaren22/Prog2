using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Nikklas!");

            Console.WriteLine("Please input your age.");
            var Age = Convert.ToInt32(Console.ReadLine());

            if (Age >= 18)
            {
                Console.WriteLine("Drinking Time! :o"); }

            else while (Age < 18)
            {
                Console.WriteLine("Unlucky no drinking");
                Console.WriteLine("Maybe input a higher number ;)");
                    var newAge = Convert.ToInt32(Console.ReadLine());
                Age = newAge;
            if (Age >= 18)
                    {
                        Console.WriteLine("Drinking Time! :o");
                    }
                }


            Console.WriteLine("Now input your name.");
            var Name = Console.ReadLine();

            Console.WriteLine("And lastly, are you currently alive? (True or False)");
            var Alive = Convert.ToBoolean(Console.ReadLine());

       
            switch (Alive)
            {
                case true:
                    Console.WriteLine("Good thing you are alive!");
                    break;

                case false:
                    Console.WriteLine("That doesnt make any sense... ");
                    break;
            }


            Console.WriteLine("You are " + Age + " years old | " + "Your name is " + Name + " | Currently Alive? " + Alive);

            Console.WriteLine("BONUS: Input two different Numbers and i will tell you which one is the largest one. ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            int Number2 = Convert.ToInt32(Console.ReadLine());
            Convert.ToInt32(Number1);

            Console.WriteLine(Math.Max(Number1, Number2) + "Is the largest number");

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Sorry Nikklas, jag är inte så creativ xd");
            }




        }
    }
}
