﻿using System;

namespace Laboration_1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Kund Bogdan = new Kund("Bogdan");
            Kund Bruh = new Kund("Bruh");
            Kund Bob = new Kund("Bogdan");

            Pillow Obama = new Pillow("Black", "Large", "Cube");
            Pillow Trump = new Pillow("Orange", "Medium", "Tomato");
            Pillow Rorri = new Pillow("Red", "Extra Large", "Car");
            Pillow Shrek = new Pillow("Green", "Small", "Ogre");

            StartMenu();

            int userselect = Convert.ToInt32(Console.ReadLine());


            switch (userselect)
            {


                case 1:
                    Console.WriteLine("You are nog logged in with user Bogdan");
                    PillowMenu();

                    int pillowselect = 0;
                    pillowselect = Convert.ToInt32(Console.ReadLine());

                    switch (pillowselect)
                    {
                        case 1:
                            Obama.Description();
                            PillowConfirmation();
                            break;

                        case 2:
                            Trump.Description();
                            PillowConfirmation();
                            break;

                        case 3:
                            Rorri.Description();
                            PillowConfirmation();
                            break;

                        case 4:
                            Shrek.Description();
                            PillowConfirmation();
                            break;
                    }

                    break;

                case 2:
                    Console.WriteLine("You are nog logged in with user Bruh");
                    PillowMenu();

                    pillowselect = Convert.ToInt32(Console.ReadLine());

                    switch (pillowselect)
                    {
                        case 1:
                            Obama.Description();
                            PillowConfirmation();
                            break;

                        case 2:
                            Trump.Description();
                            PillowConfirmation();
                            break;

                        case 3:
                            Rorri.Description();
                            PillowConfirmation();
                            break;

                        case 4:
                            Shrek.Description();
                            PillowConfirmation();
                            break;
                    }

                    break;

                case 3:
                    Console.WriteLine("You are nog logged in with user Bob");
                    PillowMenu();

                    pillowselect = Convert.ToInt32(Console.ReadLine());

                    switch (pillowselect)
                    {
                        case 1:
                            Obama.Description();
                            PillowConfirmation();
                            break;

                        case 2:
                            Trump.Description();
                            PillowConfirmation();
                            break;

                        case 3:
                            Rorri.Description();
                            PillowConfirmation();
                            break;

                        case 4:
                            Shrek.Description();
                            PillowConfirmation();
                            break;
                    }

                    break;



            }


        }

        public static void StartMenu()
        {
            Console.WriteLine("Hello! Welcome to this shitty pillow shop, what User would you like to shop with?");
            Console.WriteLine("[1] Bogdan | [2] Bruh | [3] Bob");
        }

        public static void PillowMenu()
        {
            Console.WriteLine("Please select the pillow you would like to inspect and/or purchase");
            Console.WriteLine("[1] Obama | [2] Trump | [3] Rorri | [4] Shrek");
        }
        public static void PillowConfirmation()
        {
            Console.WriteLine("Is this the pillow you would like to purchase?");
            Console.WriteLine("[1] Yes | [2] No");
        }
    }
}
