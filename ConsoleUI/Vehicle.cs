using System;

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
}
