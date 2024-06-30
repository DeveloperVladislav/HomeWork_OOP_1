using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.ReptilesGroup
{
	public class Turtle : Animal
	{
		private string Name { get; set; } = "Turtle";
		public int ShellSize { get; set; }     // Размер панциря
		public int Lifespan { get; set; }     // Продолжительность жизни

		public Turtle(int age, int shellSize, int lifespan, AnimalGroup nameType = AnimalGroup.Reptiles) : base(nameType, age)
		{
			ShellSize = shellSize;
			Lifespan = lifespan;
		}

		public void DataTurtle(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nShellSize: {ShellSize}\nLifespan: {Lifespan}");
			Console.WriteLine();
		}
	}
}
