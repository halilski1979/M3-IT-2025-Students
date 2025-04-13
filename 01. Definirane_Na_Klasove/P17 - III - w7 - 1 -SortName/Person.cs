using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace P17___III___w7___1__SortName
{
    public class Person
    {
		private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Person()
        {

        }

        public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}	

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}
		

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is a {this.Age} years old";
        }

    }
}
