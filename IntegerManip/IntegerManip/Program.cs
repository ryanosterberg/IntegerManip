using Microsoft.Win32;
using System;
using System.Collections;
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
            List<int> num = new List<int> { };
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
            int displayNum = 0;
            do
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
                 displayNum = Convert.ToInt32(display);




                if (displayNum == 1)
                {
                    //all numbers
                    foreach (var i in num)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (displayNum == 2)
                {
                    //evens
                    foreach (var i in num)
                    {

                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }

                if (displayNum == 3)
                {
                    //odds
                    foreach (var i in num)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                //Add in evry other comand in ifs

            
            if (displayNum == 4)//every fifth number
            {
                for(int i=0; i<num.Count; i++)//for each index
                {
                    if (i % 5 == 0)
                    {
                        Console.Write(num[i] + " ");
                    }
                }
                Console.WriteLine();
            }

            if (displayNum == 5)//sum
            {
                int sum = 0;
                foreach(int i in num)
                {
                    sum = sum + i;
                }
                Console.WriteLine("The sum is " + sum);
            }
            } while (displayNum != 7);
            Console.ReadLine();
        }
    }
}
