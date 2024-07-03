using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.MammalsGroup
{
	public class Human<T> : Animal<string> //типизация производного класса параметром совсем другого типа, отличного от универсального параметра в базовом классе
	{

		public T Id { get; set; }
		private string Name { get; set; } = "Human";
		public string Nationality { get; set; }   // Национальность

		public Human(T id, string age, string nationality, AnimalGroup nameType = AnimalGroup.Mammals) : base(nameType, age)
		{
			Nationality = nationality;
			Id = id;
		}
		public override void Move()
		{
			Console.WriteLine("----Man speaks-----");
		}
		public override void Print()
		{
			Console.WriteLine($"NameType: {NameType}\nName: {Name}\nAge:{Age}\nNationality: {Nationality}");
			Move();
			Console.WriteLine();
		}
	}
}
