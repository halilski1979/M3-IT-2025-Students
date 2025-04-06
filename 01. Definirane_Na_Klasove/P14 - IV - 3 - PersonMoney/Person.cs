using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14___IV___3___PersonMoney
{
    public class Person
    {
		private string name;
        private int age;
        private List<BankAccount> accounts;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = new List<BankAccount>();
        }
        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = accounts;
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
		public List<BankAccount> Accounts
		{
			get { return accounts; }
			set { accounts = value; }
		}

        //Метод за намиране на всички пари по сметките
        public double GetBalance()
        {
            return this.Accounts.Sum(x => x.Balance);
        }

        public override string ToString()
        {
            return $"Name {this.Name}, Age: {this.Age}";
        }


    }
}
