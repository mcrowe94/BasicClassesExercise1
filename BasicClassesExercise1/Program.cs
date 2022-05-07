using System;
using System.Collections.Generic;

namespace BasicClassesExercise1
{
    class Program 
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Equinox";
            myCar.Year = 2016;

            var dodge = new Car()
            {
                Make = "Dodge",
                Model = "Ram",
                Year = 2002
            };

            var chrysler = new Car("Chrysler", "PT Cruiser", 2001);

            var carList = new List<Car>() { myCar, dodge, chrysler };

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
