
/*Реализовать зоопарк
Есть базовая сущность Animal
От неё сделать несколько сущностей зверей(cat, dog и тд)
Поиграться с sealed, internal, private, public. Попробовать к классам добавить private protected, private internal
Ключевое слово base
Несколько конструкторов
Поработать с преобразованием типов*/

using HomeWork_OOP_1.Animals.MammalsGroup;

namespace HomeWork_OOP_1
{

	public class Program
	{
		static void Main(string[] args)
		{
			Animal cat1 = new Cat(10, "black", true);
			Animal cat2 = new Cat(20, "white", false);
			Animal cat3 = cat1;// переменная cat3 типа Animal начинает ссылаться на тот же самый объектв памяти, на который ссылается cat1
			cat1.Status();// скрытие new
			cat1.Print();
			
			Console.WriteLine("---cat.ToString()---");
			Console.WriteLine(cat1.ToString());
			Console.WriteLine("--------------");
			Console.WriteLine();

			Console.WriteLine("----cat.GetHashCode()---");
			Console.WriteLine(cat1.GetHashCode());
			Console.WriteLine("-------");
			Console.WriteLine();
			Console.WriteLine("----cat.GetType()---");
			Console.WriteLine(cat1.GetType());
			Console.WriteLine(typeof(Cat));//пример через typeof
			Console.WriteLine("-------");
			Console.WriteLine();
			Console.WriteLine("----cat.Equals()---");
			Console.WriteLine(Equals(cat1, cat3));//true, потому что одинаковые объекты
			Console.WriteLine(cat1.Equals(cat3));//true, потому что одинаковые объекты
			Console.WriteLine("-------");
			

			Animal dog = new Dog(10, "other", true);
			dog.Print();

			Animal human = new Human(30, "belarus", "developer");
			human.Print();

		}
	}
}