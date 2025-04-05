namespace P03___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Ivan";
            p.Age = 35;

            Person person = new Person();
            person.Name = "Petar";
            person.Age = 25;

            //Console.WriteLine($"Name: {p.Name}, {p.Age} years old.");
            p.Print();
            person.Print();

            Console.WriteLine(p.Pechat());
            Console.WriteLine(person.Pechat());

            Console.WriteLine(p);
            Console.WriteLine(person);
        }
    }
}
