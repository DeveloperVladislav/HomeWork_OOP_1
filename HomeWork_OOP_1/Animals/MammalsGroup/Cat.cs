using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.MammalsGroup
{
	public class Cat : Animal
	{
		private string Name { get; set; } = "Cat";
		public string FurColor { get; set; }   // Цвет шерсти
		public bool IsDomesticated { get; set; } // Одомашнен ли

		public Cat(int age, string furColor, bool isDomesticated, AnimalGroup nameType = AnimalGroup.Mammals) : base(nameType, age)
		{
			FurColor = furColor;
			IsDomesticated = isDomesticated;
		}

		public override void Move() //абстрактный метод из Animal
		{
			Console.WriteLine("----Сat meow-----");
		}

		public override void Print() // вирутальный метод из Animal
		{		
			Console.WriteLine($"NameType: {NameType}\nName: {Name}\nAge:{Age}\nFurColor: {FurColor}\nIsDomesticated: {IsDomesticated}");
			Move();
			
			Console.WriteLine();
		}

		public new void Status()// скрытие
		{
			Console.WriteLine("Status");
		}


		public override string ToString()
		{
			return $"NameType: {NameType}\nName: {Name}\nAge:{Age}\nFurColor: {FurColor}\nIsDomesticated: {IsDomesticated}";
		}


		
	}
}
