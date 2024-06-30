using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.AmphibiansGroup
{
	public class Salamander : Animal
	{
		private string Name { get; set; } = "Salamander";
		public bool HasTail { get; set; }     // Есть ли хвост
		public string Habitat { get; set; }     // Среда обитания

		public Salamander(int age, bool hasTail, string habitat, AnimalGroup nameType = AnimalGroup.Amphibians) : base(nameType, age)
		{
			HasTail = hasTail;
			Habitat = habitat;
		}
		public Salamander(string name = "Salamander",int age = 20, bool hasTail = true, string habitat = "other", AnimalGroup nameType = AnimalGroup.Amphibians) : base(nameType, age)
		{
			Name = name;
			HasTail = hasTail;
			Habitat = habitat;
		}

		public void DataSalamander(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nHasTail: {HasTail}\nHabitat: {Habitat}");
			Console.WriteLine();
		}
	}
}
