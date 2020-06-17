using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IntegerManip
{
    class Program
    {
        //As a team, write a project to prompt the user for up to 20 integers.  
        //The user will be allowed to choose from the following menu options until they decide to quit:
        //• Display the whole list of input
        //• Display every even number
        //• Display every odd number
        //• Display every 5th number
        //• Display the sum of the integers
        //• Display every number divisible by 3
        //• Quit
        static void Main(string[] args)
        {


            Console.WriteLine("What would you like to see?");
            Console.WriteLine("1: All numbers entered");
            Console.WriteLine("2: All even numbers entered");
            Console.WriteLine("3: All odd numbers entered");
            Console.WriteLine("4: Every 5th number entered");
            Console.WriteLine("5: The sum of every number entered");
            Console.WriteLine("6: Every input thats divisable by 3");
            Console.WriteLine("7: Quit");
            string display = Console.ReadLine();
            int displayNum = Convert.ToInt32(display);




            if (displayNum == 1)
            {
                //all numbers
                for (i = 0; i < num.size(); i++)
                {
                    Console.WriteLine(num.get(i));
                }
            }

            if (displayNum == 2)
            {
                //evens
                for (i = 0; i < num.size(); i++)
                {
                    if (num.get(i) / 2 == 0)
                    {
                        Console.WriteLine(num.get(i));
                    }
                }
            }

            if (displayNum == 3)
            {
                //odds
                for (i = 0; i < num.size(); i++)
                {
                    if (num.get(i) / 2 != 0)
                    {
                        Console.WriteLine(num.get(i));
                    }
                }
            }
            //Add in evry other comand in ifs


            Console.ReadLine();
        }
    }
}
