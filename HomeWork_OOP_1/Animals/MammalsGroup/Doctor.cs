using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HomeWork_OOP_1.Animals.MammalsGroup;

namespace HomeWork_OOP_1.Animals
{
	//доделать классы профессии человека
	public class Doctor<T> : Human<int> where T:struct
	{
		public static T? Info { get; set; }
		public string Specialization { get; set; }
		public Doctor(int id,string specialization, string age, string nationality, AnimalGroup nameType = AnimalGroup.Mammals) : base(id,age, nationality, nameType)
		{
			Specialization = specialization;
		}


		public override void Move()
		{
			Console.WriteLine("----The doctor is treating-----");
		}
		public override void Print()
		{
			Console.WriteLine($"NameType: {NameType}\nSpecialization: {Specialization}\nAge:{Age}\nNationality: {Nationality}");
			Move();
			Console.WriteLine();
		}
	}
}
