using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.AmphibiansGroup
{
	public class Triton : Animal
	{
		private string Name { get; set; } = "Triton";
		public int GillSize { get; set; }   // Размер жабр
		public string TailShape { get; set; } // Форма хвоста

		public Triton(int age, int gillSize, string tailShape, AnimalGroup nameType = AnimalGroup.Amphibians) : base(nameType, age)
		{
			GillSize = gillSize;
			TailShape = tailShape;
		}

		public void DataTriton(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nGillSize: {GillSize}\nTailShape: {TailShape}");
			Console.WriteLine();
		}
	}
}
