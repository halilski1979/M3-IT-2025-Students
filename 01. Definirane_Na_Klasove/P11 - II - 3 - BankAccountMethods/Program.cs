namespace P11___II___3___BankAccountMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BankAccount OBB = new BankAccount();
            OBB.ID = 1;
            OBB.Balance = 1000;
            Console.WriteLine(OBB);


            OBB.Deposit(150);
            Console.WriteLine(OBB);

            OBB.Withdraw(250.50);
            Console.WriteLine(OBB);
        }
    }
}
