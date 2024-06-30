using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.MammalsGroup
{
	public class Dog : Animal
	{
		private string Name { get; set; } = "Dog";
		public string Breed { get; set; }        // Порода
		public bool IsTrained { get; set; }    // Выдрессирован ли

		public Dog(int age, string breed, bool isTrained, AnimalGroup nameType = AnimalGroup.Mammals) : base(nameType, age)
		{
			Breed = breed;
			IsTrained = isTrained;
		}

		public void DataDog(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nBreed: {Breed}\nIsTrained: {IsTrained}");
			Console.WriteLine();
		}
	}
}
