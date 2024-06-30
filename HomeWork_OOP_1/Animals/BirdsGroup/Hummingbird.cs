using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.BirdsGroup
{
	public class Hummingbird : Animal//колибри
	{
		private string Name { get; set; } = "Hummingbird";
		public int BeakLength { get; set; }    // Длина клюва
		public int WingbeatRate { get; set; } // Частота взмахов крыльев

		public Hummingbird(int age, int beakLength, int wingbeatRate, AnimalGroup nameType = AnimalGroup.Birds) : base(nameType, age)
		{
			BeakLength = beakLength;
			WingbeatRate = wingbeatRate;
		}

		public void DataHummingbird(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nBeakLength: {BeakLength}\nWingbeatRate: {WingbeatRate}");
			Console.WriteLine();
		}
	}
}
