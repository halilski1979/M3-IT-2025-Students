using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03___Demo
{
   
    //Модификатор на клас
    public class Person
    {
		//Полета
		private string name;
        private int age;


		//Свойства
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

		//Метод на класа
		 public void Print()
		{
            Console.WriteLine($"My name is {this.Name}. I am {this.Age} years old");
        }
		public string Pechat()
		{
			return $"Kazvam se {this.Name}. Az sam na {this.Age} godini!";
		}

        public override string ToString()
        {
            return $"Az sam {this.Name}. {this.Age} GODINI!";
        }
    }
}
