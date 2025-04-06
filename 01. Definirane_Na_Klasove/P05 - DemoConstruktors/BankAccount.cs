using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05___DemoConstruktors
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

        public BankAccount()
        {
            
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
            return $"Account number: {this.ID} = {this.Balance}";
        }

    }
}
