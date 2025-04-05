namespace P02___Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Ivan";
            p.Age = 25;

            Console.WriteLine($"Name: {p.Name}, {p.Age} years old.");
        }
    }
}
