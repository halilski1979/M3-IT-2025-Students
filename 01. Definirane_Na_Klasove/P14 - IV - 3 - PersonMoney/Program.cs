using System.Runtime.CompilerServices;

namespace P14___IV___3___PersonMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<BankAccount> smetki = new List<BankAccount>();
            BankAccount OBB = new BankAccount(1,1000);
            BankAccount firstBank = new BankAccount(2,2000);
            smetki.Add(OBB);
            smetki.Add(firstBank);

            Person p = new Person("Ivan",25,smetki);
            
            Console.WriteLine(p);
            foreach (var item in smetki)
            {
                Console.WriteLine($"ID:{item.ID} = {item.Balance}");
            }
            Console.WriteLine($"Total: {p.GetBalance()}");


        }
    }
}
