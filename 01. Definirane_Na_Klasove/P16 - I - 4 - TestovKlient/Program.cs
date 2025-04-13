using System.Runtime.InteropServices;

namespace P16___I___4___TestovKlient
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Client client = new Client();
          
          
           while (true)
            {
                var cmd = Console.ReadLine().Split(' ').ToList();

                string operation = cmd[0];
                if (operation=="End")
                {
                    break;
                }
                int id = int.Parse(cmd[1]);

                switch (operation)
                {
                    case "Create":
                        client.Create(id);
                    break;

                    case "Deposit":
                        double amount = double.Parse(cmd[2]);
                        client.Deposit(id,amount);
                        break;

                    case "Withdraw":
                        double amount1 = double.Parse(cmd[2]);
                        client.Withdraw(id, amount1);
                        break;

                    case "Print":
                        client.Print(id);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
