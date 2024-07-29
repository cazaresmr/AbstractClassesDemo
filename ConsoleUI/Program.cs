using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "Unknown Year";
        public string Make { get; set; } = "Unknown Make";
        public string Model { get; set; } = "Unknown Model";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is a generic vehicle driving.");
        }
    }

    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The car is driving.");
        }
    }

    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This motorcycle is driving differently.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            var car1 = new Car { Year = "2021", Make = "Toyota", Model = "Camry", HasTrunk = true };
            var motorcycle1 = new Motorcycle { Year = "2022", Make = "Harley-Davidson", Model = "Sportster", HasSideCart = false };
            Vehicle vehicle1 = new Car { Year = "2019", Make = "Honda", Model = "Civic", HasTrunk = false };
            Vehicle vehicle2 = new Motorcycle { Year = "2020", Make = "Ducati", Model = "Monster", HasSideCart = true };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
            }

            // Call each of the drive methods for one car and one motorcycle
            car1.DriveAbstract();
            car1.DriveVirtual();

            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();

            Console.ReadLine();
        }
    }
}
