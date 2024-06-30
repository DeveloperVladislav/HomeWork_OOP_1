using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_OOP_1
{
	public enum AnimalGroup
	{
		Unknow = 0,
		Mammals = 1,     //млекопитающие
		Reptiles = 2,    //рептилии
		Amphibians = 3,  //земноводные
		Birds = 4,       //птицыы
		Insects = 5,     //насекомые
		Fish = 6         //рыбы
	}
	public class Animal//поставим sealed и всем наследникам хана...
	{
		protected internal AnimalGroup NameType { get; set; } //доступ только внутри сборки и у его наследников в любой сборке
		private protected int Age { get; set; } //Доступно внутри класса Animal и его наследникам в этой же сборке

		public Animal()
		{
		}
		public Animal(AnimalGroup nameType,int age)
		{
			NameType = nameType;
			Age = age;
		}

		public void Print(string name) //Доступно внутри сборки и наследникам в любой сборке
		{
			Console.WriteLine($"This is {NameType}\nName: {name}");
		}
	}
}
