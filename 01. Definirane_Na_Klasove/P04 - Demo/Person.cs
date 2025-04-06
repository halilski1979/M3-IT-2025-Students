using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04___Demo
{
    public class Person
    {
		//поле
		private string name;
        private int age;

        //Свойство
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

		//Метод в класа
		public void Print()
		{
            Console.WriteLine($"My name is {this.Name}. I am {this.Age} years old.");
        }

		public string Pechat()
		{
			return $"Az sam {this.Name}, na {this.Age} godini!";
		}

        public override string ToString()
        {
            return $"Zdraveyte! Az sam {this.Name}. I sam na {this.Age}";
        }
    }
}
