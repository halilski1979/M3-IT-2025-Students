using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11___II___3___BankAccountMethods
{
    public class BankAccount
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private double balance;

		public double Balance
		{
			get { return balance; }
			set { balance = value; }
		}

		public void Deposit(double amount)
		{
			this.Balance += amount;
		}

		public void Withdraw(double amount)
		{
			this.Balance -= amount;
		}

        public override string ToString()
        {
            return $"Account: {this.ID}, Balance po smetka: {this.Balance}";
        }


    }
}
