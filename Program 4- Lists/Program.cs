using System;
using System.Collections.Generic;

namespace Program_4__Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //You use var when you dont know what the type is gonna be: generic type
            var names = new List<string> { "Tejal", "Ana", "Felipe" }; //List<Generic Type>
            
            /**
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            **/
            //ADD AND REMOVE
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            //TRAVERSAL
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine(names[1]); //Displays item at position 1

            Console.WriteLine($"The list has {names.Count} people in it"); //To count the number of items in list

            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

            //SEARCHING
            var index = names.IndexOf("Bill");
            Console.WriteLine($"Found Bill at {index}");

            var index1 = names.IndexOf("Felipe");
            if (index1 != -1)
                Console.WriteLine($"The name {names[index1]} is at index {index1}");

            var notFound = names.IndexOf("Scott");//The name doesnot exist, so index is -1
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            //SORTING
            names.Sort();
            Console.WriteLine("Sorted names are: ");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            /**for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()!}");
            }**/
        }
    }
}
