using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            ArrayList num = new ArrayList { };
            int user = 0;

            do
            {
                Console.WriteLine("Please add a number, -1 to exit");
                user = Convert.ToInt32(Console.ReadLine());
                
                if (user != -1)
                {
                    num.Add(user);
                } else
                {
                    break;
                }
                
            } while (num.Count != 20);
            Console.WriteLine("Input complete");

            //Loop for menu selection 

            Console.ReadLine();
        }
    }
}
