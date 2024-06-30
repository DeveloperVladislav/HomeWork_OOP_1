using HomeWork_OOP_1.Animals.InsectsGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.ReptilesGroup
{
	public class Crocodile : Animal
	{
		private string Name { get; set; } = "Crocodile";
		public int BiteForce { get; set; }   // Сила укуса
		public int BodyLength { get; set; } // Длина тела

		public Crocodile(int age, int biteForce, int bodyLength, AnimalGroup nameType = AnimalGroup.Reptiles) : base(nameType, age)
		{
			BiteForce = biteForce;
			BodyLength = bodyLength;
		}

		public void DataCrocodile(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nBiteForce: {BiteForce}\nBodyLength: {BodyLength}");
			Console.WriteLine();
		}
	}
}
