﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BankAccount
    {
		private int id;
        private double balance;


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
            return $"Smetka N:{this.ID} = {this.Balance} lv.";
        }

		public void Deposit(double amount)
		{
			this.Balance += amount;
		}
    }
}
