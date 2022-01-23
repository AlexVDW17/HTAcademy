using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Basics
{
    internal class ExampleIfs
    {

        public void IfExample()
        {
            // one of the most common things you will have to do is check some condition and then decide what do do
            //this is what if statements are for
            //they work like the english language : if <something is true>, then <something will happen>. 
            //for example, 
            if(5 == 10 / 2)
            {
                Console.WriteLine("Algebra works!");
            }

            //you can probably look at this and see how it will work. Since 5 is indeed equal to 10 / 2, the code will write Algebra works
            //take special note of the == symbol. 
            //In programming, a single equals sign = means "assignment," as in 
            //int x = 5
            //which sets the value of x to 5

            //double equals == means equality, so if the left hand side is not equal to the right hand side, it will return False. 
            //for example, 
            if(5 == 3)
            {
                Console.WriteLine("There goes Algebra");
            }
            //will print nothing
            //there are other operators similar to ==
            //they  are called logical operators, and the most common ones are 
            // == : The equality operator. Returns true if both sides are equal, and false otherwise
            // < : The less than operator. Returns true if the left is less than the right, false otherwise
            // >: the greater than operator. Returns true if the left is greater than the right, false otherwise
            // != : the inequality operator. Whenever you want to do something only if two objects are NOT equal, use this. 
            //returns true if the left does not equal the right, and false otherwise
            // || : the or operator uses the pipe symbol, which might be new for you! Use this if you want to combine two conditions.
            // for example, if you want to buy something if it is on sale or you really like it, your could do

            bool isOnSale = false;
            bool iReallyLikeIt = true;
            if(isOnSale || iReallyLikeIt)
            {
                Console.WriteLine("Buying");
            }

            //the && operator. Much like or, but rather than entering the if statement if only one of the options is true, it will only enter if both are true. 
            //for example, I will buy that if I like it AND it is on sale
            if (isOnSale && iReallyLikeIt)
            {
                Console.WriteLine("Buying");
            }

            //finally, we will learn how to chain ifs.
            //sometimes you have to have multiple cases all related to the same variable. For example, lets say you are trying to guess a number.
            //you can get the user input like this:
            int number = 72;

            int input = Convert.ToInt32(Console.ReadLine());
            if (input == number)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (input > number)
            {
                Console.WriteLine("Too High!");
            }
            else
            {
                Console.WriteLine("Too low");
            }

            //the else if and else statements can only be used immediately following an if. 
            //else statements will always be executed if the if or else ifs before them were not entered
            //else if statements are the same as if statements, but will not run if the if before them succeeded


        }
    }
}
