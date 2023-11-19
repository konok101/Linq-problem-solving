using System;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8 };
            var numsPlusOne = from n in numbers select n;
            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            foreach (var i in numsPlusOne)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
