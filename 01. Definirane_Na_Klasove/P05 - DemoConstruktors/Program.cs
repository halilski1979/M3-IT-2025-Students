namespace P05___DemoConstruktors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount OBB = new BankAccount(1,1000);           
            BankAccount firstBank= new BankAccount(2,2000);

            BankAccount secondBank = new BankAccount();

            Console.WriteLine(OBB);
            Console.WriteLine(firstBank);
        }
    }
}
