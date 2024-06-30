using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.ReptilesGroup
{
	public class Snake : Animal
	{
		private string Name { get; set; } = "Snake";
		public double Length { get; set; }   // Длина
		public bool IsVenomous { get; set; } // Ядовита ли

		public Snake(int age, double length, bool isVenomous, AnimalGroup nameType = AnimalGroup.Reptiles) : base(nameType, age)
		{
			Length = length;
			IsVenomous = isVenomous;
		}

		public void DataSnake(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nLength: {Length}\nIsVenomous: {IsVenomous}");
			Console.WriteLine();
		}
	}
}
