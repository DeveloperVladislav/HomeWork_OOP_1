using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.InsectsGroup
{
	public class Bee : Animal
	{
		private string Name { get; set; } = "Bee";
		public int HoneyProduction { get; set; } // Производство меда
		public string HiveType { get; set; }       // Тип улья

		public Bee(int age, int honeyProduction, string hiveType, AnimalGroup nameType = AnimalGroup.Insects) : base(nameType, age)
		{
			HoneyProduction = honeyProduction;
			HiveType = hiveType;
		}

		public void DataBee(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nHoneyProduction: {HoneyProduction}\nHiveType: {HiveType}");
			Console.WriteLine();
		}
	}
}
