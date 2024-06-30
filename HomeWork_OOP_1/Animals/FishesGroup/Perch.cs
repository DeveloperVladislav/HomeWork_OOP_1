using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.FishesGroup
{
	public class Perch : Animal
	{
		private string Name { get; set; } = "Perch";
		public int FinCount { get; set; }     // Количество плавников
		public string Habitat { get; set; }     // Среда обитания

		public Perch(int age, int finCount, string habitat, AnimalGroup nameType = AnimalGroup.Fish) : base(nameType, age)
		{
			FinCount = finCount;
			Habitat = habitat;
		}

		public void DataPerch(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nFinCount: {FinCount}\nHabitat: {Habitat}");
			Console.WriteLine();
		}
	}
}
