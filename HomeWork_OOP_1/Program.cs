
/*Реализовать зоопарк
Есть базовая сущность Animal
От неё сделать несколько сущностей зверей(cat, dog и тд)
Поиграться с sealed, internal, private, public. Попробовать к классам добавить private protected, private internal
Ключевое слово base
Несколько конструкторов
Поработать с преобразованием типов*/

using HomeWork_OOP_1.Animals.AmphibiansGroup;
using HomeWork_OOP_1.Animals.BirdsGroup;
using HomeWork_OOP_1.Animals.FishesGroup;
using HomeWork_OOP_1.Animals.InsectsGroup;
using HomeWork_OOP_1.Animals.MammalsGroup;
using HomeWork_OOP_1.Animals.ReptilesGroup;
using System.Xml.Linq;

namespace HomeWork_OOP_1
{
	
	public class Program
	{
		static void Main(string[] args)
		{
			Animal animal = new Animal();


			Frog frog = new Frog(10, 100, "green");
			

			Animal animalFromFrog = frog; //Неявное преобразование, безопасно, т к frog это Animal
			frog.DataFrog(animalFromFrog);


			/*Frog? asFrog = animal as Frog;//будет null, т к animal не Frog
			if (asFrog != null)
			{
				Console.WriteLine("Good");
				asFrog.DataFrog(asFrog);
			}*/

			//проверка типа через is
			/*if (animal is Frog)
			{
				//animal не является Frog,поэтому не выполнится код
				Console.WriteLine("animal - it is Frog!");
			}

			if (frog is Animal)
			{
				// код выполнится, т.к. frog является наследником Animal
				Console.WriteLine("frog - it is Animal!");
			}*/

			Salamander salamander1 = new();
			Console.WriteLine("default constructor");
			salamander1.DataSalamander(salamander1);

			Console.WriteLine("constructor with parameters");
			Salamander salamander = new Salamander(10, true, "Africa");
			salamander.DataSalamander(salamander);

			/*Salamander salamanderFromAnimal = (Salamander)animal;*/ // Вызовет InvalidCastException, т.к. animal не является Frog

			Triton triton = new Triton(10, 24, "other");
			triton.DataTriton(triton);

			Hummingbird hummingbird = new Hummingbird(10, 34, 1);
			hummingbird.DataHummingbird(hummingbird);

			Ostrich ostrich = new Ostrich(10, 1.1, 13);
			ostrich.DataOstrich(ostrich);

			Sparrow sparrow = new Sparrow(10, 1.2, "song");
			sparrow.DataSparrow(sparrow);

			Perch perch = new Perch(10, 32, "other");
			perch.DataPerch(perch);

			Salmon salmon = new Salmon(10, 1.3, 100);
			salmon.DataSalmon(salmon);

			Shark shark = new Shark(10, 11, "other");
			shark.DataShark(shark);

			Ant ant = new Ant(10, 12, "other");
			ant.DataAnt(ant);

			Bee bee = new Bee(10, 14, "other");
			bee.DataBee(bee);

			Fly fly = new Fly(10, 1.5, 100);
			fly.DataFly(fly);

			Cat cat = new Cat(10, "black", true);
			cat.DataCat(cat);

			Dog dog = new Dog(10, "other", true);
			dog.DataDog(dog);

			Human human = new Human(30, "belarus", "developer");
			human.DataHuman(human);

			Crocodile crocodile = new Crocodile(10, 19, 100);
			crocodile.DataCrocodile(crocodile);

			Snake snake = new Snake(10, 1.6, true);
			snake.DataSnake(snake);

			Turtle turtle = new Turtle(10, 12, 190);
			turtle.DataTurtle(turtle);

			
		}
	}
}