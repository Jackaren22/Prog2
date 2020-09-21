using System;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            Pet Bogdan = new Pet();
            Bogdan._name = "Bogdan";
            Bogdan._species = "Monkey";
            Bogdan._color = "Pink";
            Bogdan._age = 999;

            Person Niklas = new Person("Niklas", 33, Bogdan);

            Niklas.Eat();
            Niklas.Sleep();

            Niklas.ActivatePet();
        }
    }
}
