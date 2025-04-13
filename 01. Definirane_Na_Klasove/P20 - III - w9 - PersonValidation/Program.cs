namespace P20___III___w9___PersonValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();


            for (int i = 0; i < br; i++)
            {
                var line = Console.ReadLine().Split(' ').ToArray();
                string fName = line[0];
                string lName = line[1];
                int godiini = int.Parse(line[2]);
                double zaplata = double.Parse(line[3]);

                Person p = new Person(fName, lName, godiini, zaplata);
                people.Add(p);
            }
            double percent = double.Parse(Console.ReadLine());


            foreach (Person p in people)
            {
                p.IncreaseSalary(percent);
            }


            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

        }
    }
}
