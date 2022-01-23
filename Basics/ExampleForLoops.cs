using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Basics
{
    internal class ExampleForLoops
    {

        public void ForLoops()
        {
            //a common challenge in code is doing the same thing many times
            // in cases where we know how many times we want to do it, a for loop works great!
            //for example, say we wanted to print out all the numbers from 1 to 100
            //we could write 100 Console.WriteLine(x), but what if we wanted all the numbers from 1 to 100000?
            //in this case a for loop is perfect
            //for autocomplete, type for and then hit tab twice. That will help you get the hang of the syntax

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("i");
            }

            Console.WriteLine("All Done!");

            
        }

        public void WhileLoops()
        {
            //in cases where we somehow know how many iterations we will do, a for loop is perfect
            //but sometimes we just want to iterate until some more difficult to quantify condition occurs
            //make sure you understand if statements before using this

            //in these cases, we use a while loop. It takes the form  
            //while(condition){
            //  do work
            //}

            //for example, here we are waiting for a random variable to become 2. When it does, we will break out
            Random rnd = new Random();
            int x = 0;
            while (x!=2)
            {
                x = rnd.Next(0,5);
            }

            // a variant of while loops are do while loops. I have yet to come across a use case for these, so look them up if you're interested but otherwise you should be fine
        }

        public void forEach()
        {
            //sometimes you have an array or list and want to do something with each element.
            //for example, 
            string[] names = { "John", "Elise", "Reggie", "Brittany" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            //this will print out each name on its own line. 

        }
    }
}
