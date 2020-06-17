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

                //these vars should be there already so this code block should be deleted when merged and variable names changed
                int menuItem =4;//will be the number corresponding with menu
                ArrayList num = new ArrayList();
                num.Add(1); num.Add(2); num.Add(3); num.Add(4); num.Add(5); num.Add(6); num.Add(7); num.Add(8); num.Add(9); num.Add(10); num.Add(11);


            if (menuItem == 3)//every fifth number
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

            if(menuItem == 4)//sum
            {
                int sum = 0;
                foreach(int i in num)
                {
                    sum = sum + i;
                }
                Console.WriteLine("The sum is " + sum);
            }


            Console.ReadLine();
        }
    }
}
