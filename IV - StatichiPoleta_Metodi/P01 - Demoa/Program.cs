namespace P01___Demoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ivan",23);



            Console.WriteLine(p);
            Console.WriteLine($"Broy hora: {Person.Counter()}");

            Person q = new Person("Petar", 43);
            Console.WriteLine(q);
            Console.WriteLine($"Broy hora: {Person.Counter()}");
        }
    }
}
