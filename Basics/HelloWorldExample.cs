using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Basics
{
    internal class HelloWorldExample
    {
        //Do this one first!!
        //Hello world is a traditional program to test your system and make sure everything works. 
        // it's also traditionally the first program anyone ever writes

        //make note of many of the basic structural pieces of this simple program
        //the line of code that does something is ended with a semicolon; almost every line will have this
        //We use <Class name>.<Method name>(<parameters>); to make things happen. Classes are like objects or tools, things we can use.
        //methods are the things they can do
        //and parameters are the instructions
        //in this case, we use the class <Console>, which is another name for the black text window that opens when we run this
        //we use the method "WriteLine" to write a line of text
        //and we use the parameters "hello world" to tell it what to write!
        static void Main(string[] args)
        {
            Console.WriteLine("hello World");
        }
    }
}
