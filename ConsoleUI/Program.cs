using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            Car civic = new Car()
            {
                Year = 2017,
                Make = "Honda",
                Model = "Civic",
                DoorNumber = 4
            };
            vehicles.Add(civic);

            Motorcycle harley = new Motorcycle()
            {
                Year = 2006,
                Make = "Harley",
                Model = "Davidson",
                HasSideCar = false
            };
            vehicles.Add(harley);

            Vehicle sonata = new Car()
            {
                Year = 2016,
                Make = "Hundai",
                Model = "Sonata",
                DoorNumber = 4
            };
            vehicles.Add(sonata);

            Vehicle jetta = new Car()
            {
                Year = 2009,
                Make = "Volkswagen",
                Model = "Jetta",
                DoorNumber = 4
            };
            vehicles.Add(jetta);

            foreach(var auto in vehicles)
            {
                Console.WriteLine($"Make: {auto.Make}");
                Console.WriteLine($"Model: {auto.Model}");
                Console.WriteLine($"Year: {auto.Year}");
               
                auto.DriveVirtual();
                Console.WriteLine("");
            }

                /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
            /x * Create an abstract class called Vehicle
            /x * The vehicle class shall have three string properties Year, Make, and Model
            /x * Set the defaults to something generic in the Vehicle class
            /x * Vehicle shall have an abstract method called DriveAbstract with no implementation
            /x * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
            /x * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
            /x * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
            /x * Provide the implementations for the abstract methods
            /x * Only in the Motorcycle class will you override the virtual drive method
            */

            //x Create a list of Vehicle called vehicles

            /*
            /x * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
            /* 
            /x * Set the properties with object initializer syntax
             */

            /*
            /x * Add the 4 vehicles to the list
            /x * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
