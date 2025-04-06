using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14___IV___3___PersonMoney
{
    public class BankAccount
    {
		private int id;
        private double balance;

        public BankAccount(int id, double balance)
        {
            this.ID = id;
            this.Balance = balance;
        }

        public int ID
		{
			get { return id; }
			set { id = value; }
		}		
		public double Balance
		{
			get { return balance; }
			set { balance = value; }
		}

		public override string ToString()
		{
			return $"BankAccount: {this.ID} = {this.Balance} lv.";
		}
	}
}
