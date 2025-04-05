using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02___Demo2
{
    public class Person
    {
		private int myVar;

		public int MyProperty
		{
			get { return myVar; }
			set { myVar = value; }
		}


		//Полета на класа
		private string name;
		private int age;

		//Свойство на класа
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

	}
}
