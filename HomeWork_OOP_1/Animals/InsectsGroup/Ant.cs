using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.InsectsGroup
{
	public class Ant : Animal
	{
		private string Name { get; set; } = "Ant";
		public int ColonySize { get; set; }   // Размер колонии
		public string FoodPreference { get; set; } // Пищевые предпочтения

		public Ant(int age, int colonySize, string foodPreference, AnimalGroup nameType = AnimalGroup.Insects) : base(nameType, age)
		{
			ColonySize = colonySize;
			FoodPreference = foodPreference;
		}

		public void DataAnt(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nColonySize: {ColonySize}\nFoodPreference: {FoodPreference}");
			Console.WriteLine();
		}
	}
}