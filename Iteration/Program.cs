using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("I have eaten " + i + "pizza(s)");
            }

            bool areNearlyThereYet = false;

            while (areNearlyThereYet == false)
            {
                Console.WriteLine("Are we nearly there yet?");
                areNearlyThereYet = Console.ReadLine().ToLower() == "yes";
            }


            //reapeat from 1 - 50
            for (int i = 1; i < 50; i++)
            {
                string oddOrEven = "odd";
                if (i % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }
                Console.WriteLine($"{i} is {oddOrEven}");
            }

            //see if number is divisiblr by 3
            Console.WriteLine("Gimmie a number in times table");
            int num = int.Parse(Console.ReadLine());


            for (int i = 1; i < 50; i++)
            {
                string isInTable = "odd";
                if (i % num == 0)
                {
                    isInTable = "oui oui";
                }
                else
                {
                    isInTable = "nien";
                }
                Console.WriteLine($"{i} is {isInTable}");
            }
        }
    }
}
