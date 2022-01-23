using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Basics
{
    internal class ExampleVariables
    {
        
        public void SampleVariables()
        {
            //here we will go over variables and how to declare and use them
            //strings are used to hold text

            string myString = "hello World!";

            //char is short for Character. a char is a single letter or symbol. 
            char myChar = 'C';

            //here we are reusing the myChar variable and assigning a new value to it
            //we "index" our string using [0] to get the 0th character. In this case, thats h
            //note that in programming we consider the first element to be at position 0
            //this might take some getting used to, but if somethings broken and uses the [] operator, try checking that you used 0 as the first element and so on
            myChar = myString[0];

            //int is short for integer. It stores non-decimal numbers
            int myInt = 5;

            //longs are another way to store numbers. Typically you will be using ints, so look into these only if you have a special use case for big numbers
            long myLong = 5;


            // booleans can have only 2 values, true or false. They are good for if statements
            bool myBool = false;
            bool myBool2 = true;

            // here are two ways to store decimals. They vary slightly, but are similar for your purposes. 
            float myFloat = 5.5f;

            double myDouble = 5.5;

            //Datetimes come up with some regularity, but are a bit different from the others here.
            //If you are in Visual studio, you'll see the colouration is different on DateTime than on double, int, etc
            //DateTime is considered a class, rather than a basic data type. That means it is more versatile, and has its own unique methods
            //it also means that to assign a value to it, you will have to use methods rather than just say = "November 12, 1995"
            //Watch the bob tabor video on datetimes for more information
            DateTime myDateTime = DateTime.Now;

            
        }
    }
}
