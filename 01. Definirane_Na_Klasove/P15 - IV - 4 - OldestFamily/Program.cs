namespace P15___IV___4___OldestFamily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            Family ivanovi = new Family();
            
            for (int i = 0; i < br; i++)
            {
                var line = Console.ReadLine().Split(' ').ToList();

                var ime = line[0];
                var godini = int.Parse(line[1]);
                Person p = new Person(ime,godini);
                ivanovi.AddMember(p);
            }

            Console.WriteLine(ivanovi.GetOldestMember());
        }
    }
}
