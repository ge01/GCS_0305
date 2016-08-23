using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0305_082216
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constant fields
            const decimal FIVE_CENTS_VALUE = 0.05m;
            const decimal TEN_CENTS_VALUE = 0.10m;
            const decimal TWENTY_FIVE_CENTS_VALUE = 0.25m;
            const decimal FIFTY_CENTS_VALUE = 0.50m;

            // Field variable to hold president's name
            string president;

            // Field variable to hold the total,
            // initialized with 0.
            decimal total = 0m;
            // Field variable to exit Change Counter
            int again = 0;

            do
            {
                // Input
                Console.WriteLine("jefferson = 5 cents");
                Console.WriteLine("roosevelt = 10 cents");
                Console.WriteLine("washington = 25 cents");
                Console.WriteLine("kennedy = 50 cents");
                Console.WriteLine("Enter a president's name: ");
                president = Console.ReadLine();

                // Process
                if (president == "jefferson")
                    total += FIVE_CENTS_VALUE;
                else if (president == "roosevelt")
                    total += TEN_CENTS_VALUE;
                else if (president == "washington")
                    total += TWENTY_FIVE_CENTS_VALUE;
                else if (president == "kennedy")
                    total += FIFTY_CENTS_VALUE;
                else
                {
                    Console.WriteLine("You did not enter the name correctly");
                    Console.WriteLine("Try again");
                    Console.WriteLine();
                }
                    

                Console.WriteLine("Enter 1  to exit or 2 to go again");
                again = int.Parse(Console.ReadLine());

            } while (again != 1);

            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
