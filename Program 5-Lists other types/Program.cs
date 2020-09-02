using System;
using System.Collections.Generic;

namespace Program_5_Lists_other_types
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20) //We already have two numbers in list, we check till we have 20 list items
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1]; //taking last item in list
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2]; //taking second item in list

                fibonacciNumbers.Add(previous + previous2); //sum up last two numbers in list and then add the result in list
            }

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }
    }
}
