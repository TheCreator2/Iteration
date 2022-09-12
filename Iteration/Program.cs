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
                Console.WriteLine("I have eaten " +  i + "pizza(s)");
            }

            bool areNearlyThereYet = false;

            while (areNearlyThereYet == false)
            {
                Console.WriteLine("Are we nearly there yet?");
                areNearlyThereYet = Console.ReadLine().ToLower() == "yes";
            }

        }
    }
}
