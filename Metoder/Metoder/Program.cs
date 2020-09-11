using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 3, 5, 7, 9, 12 };
            string[] words = { "hej", "svejs", "leif", "kommer", "majs" };

            Console.WriteLine(sum(numbers));
            Console.WriteLine(reversed(words));

        }

        static int sum(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static string reversed(string[] words)
        {
            Array.Reverse(words);
            return words[0];

        }
   
    }
}
