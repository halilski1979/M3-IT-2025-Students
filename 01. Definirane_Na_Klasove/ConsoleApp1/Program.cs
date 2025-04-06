namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount OBB = new BankAccount();
            OBB.ID= 1;
            OBB.Balance = 1000;

            Console.WriteLine(OBB);

            BankAccount firstBank=new BankAccount();
            firstBank.ID = 2;
            firstBank.Balance = 2000;
            Console.WriteLine(firstBank);


            OBB.Deposit(200);
            Console.WriteLine(OBB);

            firstBank.Deposit(355.50);
            Console.WriteLine(firstBank);
        }
    }
}
