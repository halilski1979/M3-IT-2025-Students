namespace P10___Person_StaticCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"People = {Person.Count()}");
            Person Ivan = new Person("Ivan", 12);
            Console.WriteLine($"People = {Person.Count()}");
            Person Peter = new Person("Peter", 18);
            Console.WriteLine($"People = {Person.Count()}");
        }
    }
}
