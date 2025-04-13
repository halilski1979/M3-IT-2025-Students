using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P01___Demoa
{
    public class Person
    {
		private string name;
        private int age;

        private static int counter=0;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            counter++;
        }

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


        public override string ToString()
        {
            return $"Name {this.Name},{this.Age} godini!"; 
        }

        public static int Counter()
        {
            return counter;
        }
    }
}
