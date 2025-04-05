using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10___II___02___BankAccount
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

        public override string ToString()
        {
			return $"Account: {this.ID} ,Balance: {this.Balance}";
        }
    }
}
