using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.AmphibiansGroup
{
    public class Frog : Animal
    {
		private string Name { get; set; } = "Frog";
		public int JumpDistance { get; set; } // Дальность прыжка
		public string Color { get; set; }       // Цвет

		public Frog(int age, int jumpDistance, string color, AnimalGroup nameType = AnimalGroup.Amphibians) : base(nameType, age)
		{
			JumpDistance = jumpDistance;
			Color = color;
		}
		public void DataFrog(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nJumpDistance: {JumpDistance}\nColor: {Color}");
			Console.WriteLine();
		}
	}
}
