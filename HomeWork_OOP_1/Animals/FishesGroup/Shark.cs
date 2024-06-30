using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.FishesGroup
{
	public class Shark : Animal
	{
		private string Name { get; set; } = "Shark";
		public int TeethRows { get; set; }     // Количество рядов зубов
		public string BodyShape { get; set; }   // Форма тела

		public Shark(int age, int teethRows, string bodyShape, AnimalGroup nameType = AnimalGroup.Fish) : base(nameType, age)
		{
			TeethRows = teethRows;
			BodyShape = bodyShape;
		}

		public void DataShark(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nTeethRows: {TeethRows}\nBodyShape: {BodyShape}");
			Console.WriteLine();
		}
	}
}
