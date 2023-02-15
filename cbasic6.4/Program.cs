/*4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. 
    Display the unique numbers that the user has entered.
 */

using System;
using System.Collections.Generic;
namespace cbasic6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var unique = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type quit to leave");
                var input = Console.ReadLine();

                if (input.CompareTo("quit") == 0)
                    break;
                else
                {
                    var number = Convert.ToInt32(input);
                    if (unique.Contains(number))
                        continue;
                    else
                        unique.Add(number);
                }
            }

            foreach (var output in unique)
                Console.Write("{0} ", output);
        }
    }
}
