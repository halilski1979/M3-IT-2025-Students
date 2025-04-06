using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06___DemoConstructors
{
    public class Person
    {
		private string name;
        private int age;
        private double salary;

        public Person(string name, int age, double salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }

       
        //Празен конструктор с default - стойност
        public Person()
        {
            this.Name = "EmptyName";
            this.Age = 100;
            this.Salary = 1000000;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
		{
			get { return name; }
			set 
            {
                if (value.Length<=2)
                {
                    throw new ArgumentException("Name is too short!");
                }
                name = value; 
            }
		}		

		public int Age
		{
			get { return age; }
			set 
            {
                if (value<=0)
                {
                    throw new ArgumentException("ERROR");
                }
                age = value; 
            }
		}		

		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}


        public override string ToString()
        {
            return $"{this.Name}, {this.Age}, Salary: {this.Salary}";
        }
    }
}
