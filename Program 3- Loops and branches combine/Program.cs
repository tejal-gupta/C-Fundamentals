using System;

namespace Program_3__Loops_and_branches_combine
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"The sum of numbers divisible by 3 is {sum}");
        }
    }
}
