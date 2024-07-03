using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP_1.Animals
{
	public class Test
	{
		public string Info { get; set; }

		/*public Test()
		{

		}
		public Test(string info)
		{
			Info = info;
		}*/
		public virtual string GetDescription() => $"This is {Info}";
	}
}
