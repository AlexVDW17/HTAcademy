using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Basics
{

    // A class is used to respresent an object in your code. While using the auto generated C# code for console applications, you've actually been using a class called Program
    // We will create a class representing a car to explain common class concepts
    class Car
    {
        // classes, like objects, have properties. These properties are like variables that every object of type <class> will have.
        // for our example, every car will have a make, model, and colour
        public string colour { get; set; }
        public string model { get; set; }
        public string make { get; set; }

        //When you create an object of type "Car", you use something called a constructor
        //the constructor is sort of like the factory for cars. You pass the constructor information about the object, and it returns the car
        //the constructor is always written as <class name>(parameters)
        Car(string colour, string model, string make)
        {
            // inside the constructor, we initialize our car and use the parameters. In this example, we just set the colour, make, and model to match our specifications
            // you could, however, do anything else related to the creation of the object in here, like log the creation of the car
            this.colour = colour;
            this.model = model;
            this.make = make;
        }

        // the most useful things classes give you is the ability to create methods related to the class
        //for a car, this is all the things a car can do. Drive, Park, and Honk could all be methods

        public void Honk()
        {
            Console.WriteLine("HONK");
        }

        //Try going to the program.cs file and adding the following lines:
        //Car myCar = new Car("blue", "Cavalier", "Chevrolet");
        //mycar.Honk();
    }
}
