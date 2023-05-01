using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}

		public int DoorNumber { get; set; } = 4;

        public override void DriveAbstract()
        {
            Console.WriteLine("This Car is in virtual drive.");
        }
    }
}

