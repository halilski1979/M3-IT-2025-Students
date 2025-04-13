namespace P17___III___w7___1__SortName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                string fName = line[0];
                string lNane = line[1];
                int godini = int.Parse(line[2]);
                Person p = new Person(fName, lNane, godini);
                people.Add(p);
            }

            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            people = people.OrderBy(x => x.FirstName).ThenBy(x => x.Age).ToList();
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }
    }
}
