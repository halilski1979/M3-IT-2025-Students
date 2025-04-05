namespace P01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Person person = new Person();
            person.name = "Petar";
            person.age = 25;

            Person p = new Person();
            p.name = "Ivan";
            p.age = 8;

            Console.WriteLine($"Name: {person.name}, {person.age} years old.");
            Console.WriteLine($"Name: {p.name}, {p.age} years old.");

        }
    }
}
