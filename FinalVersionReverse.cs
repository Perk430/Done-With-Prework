using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Reverse3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*numeralsString will store the number we want to reverse
             * reverse will store the reversed number
             * numerals' only purpose is to check if the input is actually a number before trying to reverse it
             * inputIsNumber will make sure that the program keeps asking for a  number until it gets one
            */
            string numeralsSrting = "", reverse = "";
            long numerals;
            bool inputIsNumbers = false;

            Console.WriteLine("Welcome to the Number Reversal");

            // using a while loop to let the user enter input until they give a number with 10 or less digits.

            while (!inputIsNumbers)
            {
                Console.WriteLine("Please input a number (maximum 10 digits):\t");
                numeralsSrting = Console.ReadLine();

                // Parsing the string to see if it's actually a number
                if (long.TryParse(numeralsSrting, out numerals))
                {
                    if (numeralsSrting.Length <= 10)
                    {
                        inputIsNumbers = true;
                        Console.WriteLine("You entered the number {0}", numerals);
                    }

                    else
                    {
                        Console.WriteLine("Sorry, that number is a bit too long; max is 10 digits...\n\n");
                    }
                }

                else
                {
                    Console.WriteLine("Sorry, but that isn't a number.  Please try again... \n\n");
                }
            }
                /* we have our number, now let's reverse it!
                         * normally, we use for loops to count up to a certain point
                         * however, we are going backwards; therefore, I think it would be a good idea to count down instead
                         * to pull characters from the end of the string entered by the user.
                        */

                int i, len = numeralsSrting.Length;
                for (i = len; i > 0; i--)
                {
                    // not forgetting to subtract one to get ther right character 
                    reverse += numeralsSrting[i - 1];
                }
                // Ta-Dah!!!  Our number is reversed
                Console.WriteLine("Your reversed number is {0}", reverse);
            
                // Our work here is done
                Console.WriteLine("Press any key to close...");
                Console.Read();
        }
    }
}
    
