//Name: Molli Bishop
//Date: 8/29/2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();

            int wNum = num.Next(0, 100);

            bool win = false;

            int count = 0;

            while (win == false)
            {
                Console.Write("Guess a number between 0 and 100: ");
                
                string num1 = Console.ReadLine();

                int i = int.Parse(num1);

                if (i > wNum)
                {
                    Console.Write("Number is too high! Please guess lower.");
                }
                else if (i < wNum)
                {
                    Console.Write("Number is too low! Please guess higher.");
                }
                else if (i == wNum)
                {
                    Console.Write("You Win!! It took ");
                    Console.Write(count);
                    Console.Write(" tries!\n");
                    win = true;
                }
                count += 1;
            }
            Console.Write("Thank you for playing!");
        }
    }
}
 
