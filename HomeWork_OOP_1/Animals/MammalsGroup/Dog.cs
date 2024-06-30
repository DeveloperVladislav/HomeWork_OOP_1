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
		public override void Move()
		{
			Console.WriteLine("----Dog bark-----");
		}
		public override void Print()
		{
			Console.WriteLine($"NameType: {NameType}\nName: {Name}\nAge:{Age}\nBreed: {Breed}\nIsTrained: {IsTrained}");
			Move();
			Console.WriteLine();
		}
	}
}
