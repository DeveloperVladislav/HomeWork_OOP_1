using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.MammalsGroup
{
	public class Human : Animal
	{
		private string Name { get; set; } = "Human";
		public string Nationality { get; set; }   // Национальность
		public string Profession { get; set; }    // Профессия

		public Human(int age, string nationality, string profession, AnimalGroup nameType = AnimalGroup.Mammals) : base(nameType, age)
		{
			Nationality = nationality;
			Profession = profession;
		}
		public override void Move()
		{
			Console.WriteLine("----Man speaks-----");
		}
		public override void Print()
		{
			Console.WriteLine($"NameType: {NameType}\nName: {Name}\nAge:{Age}\nNationality: {Nationality}\nProfession: {Profession}");
			Move();
			Console.WriteLine();
		}
	}
}
