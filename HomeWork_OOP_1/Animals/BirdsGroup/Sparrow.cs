using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.BirdsGroup
{
	public class Sparrow : Animal
	{
		private string Name { get; set; } = "Sparrow";
		public double Wingspan { get; set; } // Размах крыльев
		public string Song { get; set; }      // Песня

		public Sparrow(int age, double wingspan, string song, AnimalGroup nameType = AnimalGroup.Birds) : base(nameType, age)
		{
			Wingspan = wingspan;
			Song = song;
		}

		public void DataSparrow(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nWingspan: {Wingspan}\nSong: {Song}");
		}
	}
}
