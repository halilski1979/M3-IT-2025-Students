namespace P13___II___2___Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broy chlenove na semeystvo: ");
            int br = int.Parse(Console.ReadLine());

            Family petrovi=new Family();

            for (int i = 0; i < br; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var ime = input[0];
                var godini = int.Parse(input[1]);

                Person p = new Person();
                p.Name = ime;
                p.Age= godini;

                petrovi.AddMember(p);
            }

            petrovi.SortAge();
            petrovi.Print();
        }
    }
}
