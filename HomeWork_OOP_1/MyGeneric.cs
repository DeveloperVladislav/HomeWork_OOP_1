using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1
{
	public class MyGeneric<T> where T : class, new() //ограничения в виде - T будет классом, с new() - конструктором по умолчанию
	{
		public T CreateObj()
		{
			return new T();
		}
	}
}
