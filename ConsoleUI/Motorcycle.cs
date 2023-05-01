using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}

		public bool HasSideCar { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is in virtual drive.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This Motorcycle is driving virtually.");
        }
    }
}

