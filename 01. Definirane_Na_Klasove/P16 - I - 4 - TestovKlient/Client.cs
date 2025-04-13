using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P16___I___4___TestovKlient
{
    public class Client
    {
        Dictionary<int,BankAccount> accounts=new Dictionary<int,BankAccount>();

        public void Create(int id)
        {
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                BankAccount account = new BankAccount();
                account.Id = id;
                accounts.Add(id, account);

            }

            
        }

        public void Deposit(int id, double amount)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                //BankAccount account = accounts.FirstOrDefault(x=>x.Key==id).Value;
                BankAccount account = accounts[id];
                account.Deposit(amount);

            }
        }

         public void Withdraw(int id, double amount)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                //BankAccount account = accounts.FirstOrDefault(x=>x.Key==id).Value;
                BankAccount account = accounts[id];

                if (account.Balance<amount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    account.Withdraw(amount);
                }
            }
        }

        public void Print(int id)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                BankAccount account = accounts[id];
                Console.WriteLine(account.ToString());
            }
        }

    }
}
