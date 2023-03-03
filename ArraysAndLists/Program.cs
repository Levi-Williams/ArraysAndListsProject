using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            var numbers = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();

            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (int i in numbers)
            {
                if(i % 2 == 0)
                {
                   evens.Add(i);
                }

                else
                {
                    odds.Add(i);  
                }
            }



            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            Console.WriteLine("Hello, it looks like you'd like to know what numbers between 1 and 10 are even or odd");
            Console.WriteLine("Oh, you already know huh...Well that would ruin this assignment if I didnt show you anyway so here we go!");

            Console.WriteLine("Here are the even numbers:");
            
            foreach (int i in evens)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Here are the odd numbers:");

            foreach (int i in odds) 
            { 
                Console.WriteLine(i); 
            }

            Console.WriteLine("Now that may not be too impressive on the surface but would you be impressed if I told you I coded that all myself?");

            Console.WriteLine("Still not impressed huh. Well soon I will be coding all sorts of cool things:)");

            //If I got real creative my answers could have changed based on user input. But that would make grading this assignment more difficult and with hundreds a day, that sounds annoying.
            //So, thank you for taking tiome to look into this, I am sure it's a daunting task!
        }
    }
}
