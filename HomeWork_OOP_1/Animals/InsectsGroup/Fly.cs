using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.InsectsGroup
{
	public class Fly : Animal
	{
		private string Name { get; set; } = "Fly";
		public double FlightSpeed { get; set; }    // Скорость полета
		public int EyeCount { get; set; }         // Количество глаз

		public Fly(int age, double flightSpeed, int eyeCount, AnimalGroup nameType = AnimalGroup.Insects) : base(nameType, age)
		{
			FlightSpeed = flightSpeed;
			EyeCount = eyeCount;
		}

		public void DataFly(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nFlightSpeed: {FlightSpeed}\nEyeCount: {EyeCount}");
			Console.WriteLine();
		}
	}
}
