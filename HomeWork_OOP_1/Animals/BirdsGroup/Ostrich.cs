using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.BirdsGroup
{
	public class Ostrich : Animal
	{
		private string Name { get; set; } = "Ostrich";
		public double RunningSpeed { get; set; } // Скорость бега
		public int EggSize { get; set; }         // Размер яйца

		public Ostrich(int age, double runningSpeed, int eggSize, AnimalGroup nameType = AnimalGroup.Birds) : base(nameType, age)
		{
			RunningSpeed = runningSpeed;
			EggSize = eggSize;
		}

		public void DataOstrich(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nRunningSpeed: {RunningSpeed}\nEggSize: {EggSize}");
			Console.WriteLine();
		}
	}
}
