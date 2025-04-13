using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19___III___w8___1___IncreaseSalary
{
    public class Person
    {
		private string firtsName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firtsName, string lastName, int age, double salary)
        {
            this.FirtsName = firtsName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirtsName
		{
			get { return firtsName; }
			set { firtsName = value; }
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

		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}


		public void IncreaseSalary(double bonus)
		{
			if (this.Age>30)
			{
				this.Salary = this.Salary + this.Salary * (bonus / 100);
				
			}
			else
			{
				bonus = bonus / 2;
				this.Salary = this.Salary + this.Salary * (bonus / 100);
            }
		}

        public override string ToString()
        {
            return $"{this.FirtsName} {this.lastName} get {this.Salary} leva";
        }

    }
}
