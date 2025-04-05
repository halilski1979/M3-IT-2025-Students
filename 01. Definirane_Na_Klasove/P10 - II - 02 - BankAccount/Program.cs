namespace P10___II___02___BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.ID = 1;
            account.Balance = 1200.55;

            Console.WriteLine(account);
        }
    }
}
