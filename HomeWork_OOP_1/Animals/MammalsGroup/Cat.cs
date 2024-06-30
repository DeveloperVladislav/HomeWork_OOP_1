using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.MammalsGroup
{
	public class Cat : Animal
	{
		private string Name { get; set; } = "Cat";
		public string FurColor { get; set; }   // Цвет шерсти
		public bool IsDomesticated { get; set; } // Одомашнен ли

		public Cat(int age, string furColor, bool isDomesticated, AnimalGroup nameType = AnimalGroup.Mammals) : base(nameType, age)
		{
			FurColor = furColor;
			IsDomesticated = isDomesticated;
		}

		public void DataCat(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nFurColor: {FurColor}\nIsDomesticated: {IsDomesticated}");
			Console.WriteLine();
		}
	}
}
