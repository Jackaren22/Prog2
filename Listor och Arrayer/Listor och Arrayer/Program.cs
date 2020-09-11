using System;

namespace Listor_och_Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[5];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Input a name 5 times:");
                names[i] = Console.ReadLine();
            }

            Array.Reverse(names);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(names[i]);
                }


            }
        }
    }

