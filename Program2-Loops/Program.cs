using System;

namespace Program2_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //For loop
            Console.WriteLine("For loop");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"Inside for loop Counter{i}");
            }

            //While loop
            Console.WriteLine("While loop");
            int c = 0;
            while (c <= 2)
            {
                Console.WriteLine($"Inside while loop Counter{c}");
                c++;
            }

            //Do-while loop
            Console.WriteLine("Do-while loop");
            int d = 0;
            do
            {
                Console.WriteLine($"Inside do-while loop Counter{d}");
                d++;
            } while (d <= 2);
        }
    }
}
