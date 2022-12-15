using System;
namespace ConsoleUI
{
	internal class Motorcycle : Vehicle
	{
        public bool HasSideCar { get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine("The Motorcycle is driveable");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcyle's Virtual Drive Method");
        }

    }
}

