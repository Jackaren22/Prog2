using System;
using System.Linq;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 28, 2, 3, 5, 7, 9, 12 };
            string[] words = { "hej", "svejs", "leif", "kommer", "majs" };

            Console.WriteLine(sum(numbers));
            Reversed(words);
            int[] maxandmin = MaxAndMin(numbers); // Mina variablers namn är hemska mamma mia....


            for (int i = 0; i < maxandmin.Length; i++)
            {
                Console.WriteLine(maxandmin[i]);
            }

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

        static void Reversed(string[] words)
        {
            Array.Reverse(words);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(words[i]);
            }

        }
   
        static int[] MaxAndMin (int[] numbers)
        {
            int largest = numbers.Max();
            int smallest = numbers.Min();

            int[] both = { largest, smallest };

            return both;

        }
    }
}
