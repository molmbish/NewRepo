//Name: Molli Bishop
//Date: 08/29/2020
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

            Console.Write("Please input a starting number: ");
            string first = Console.ReadLine();
            int fir = int.Parse(first);


            Console.Write("Please input an ending number: ");
            string last = Console.ReadLine();
            int las = int.Parse(last);


            int wNum = num.Next(fir, las);

            bool win = false;

            int count = 1;

            while (win == false)
            {
                Console.Write("Guess a number between " + fir + " and " + las + ": ");
                
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
                    Console.Write("You Win!! It took " + count + " tries!\n");
                    win = true;
                }
                count += 1;
            }
            Console.Write("Thank you for playing!");
        }
    }
}
 
