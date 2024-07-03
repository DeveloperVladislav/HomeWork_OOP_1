using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_OOP_1.Animals.MammalsGroup;

namespace HomeWork_OOP_1
{
	public class Teacher<T, K> : Human<string>//типизация производного класса параметром совсем другого типа, отличного от универсального параметра в базовом классе
	{
		public T СlassNumber { get; set; }
		public K ClassLetter { get; set; }
		public Teacher(string id,string age, T classNumber, K classLetter, string nationality, AnimalGroup nameType = AnimalGroup.Mammals) : base(id, age, nationality, nameType)
		{
			СlassNumber = classNumber;
			ClassLetter = classLetter;
		}


		public override void Move()
		{
			Console.WriteLine("----The teacher is teaching-----");
		}
		public override void Print()
		{
			Console.WriteLine($"NameType: {NameType}\nСlassNumber: {СlassNumber} \"{ClassLetter}\"\nAge:{Age}\nNationality: {Nationality}");
			Move();
			Console.WriteLine();
		}
	}
}
