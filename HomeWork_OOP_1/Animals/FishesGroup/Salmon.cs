using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals.FishesGroup
{
	public class Salmon : Animal
	{
		private string Name { get; set; } = "Salmon";
		public double MigrationDistance { get; set; } // Дистанция миграции
		public int SpawningAge { get; set; }         // Возраст нереста

		public Salmon(int age, double migrationDistance, int spawningAge, AnimalGroup nameType = AnimalGroup.Fish) : base(nameType, age)
		{
			MigrationDistance = migrationDistance;
			SpawningAge = spawningAge;
		}

		public void DataSalmon(Animal animal)
		{
			animal.Print(Name);
			Console.WriteLine($"Age:{Age}\nMigrationDistance: {MigrationDistance}\nSpawningAge: {SpawningAge}");
			Console.WriteLine();
		}
	}
}
