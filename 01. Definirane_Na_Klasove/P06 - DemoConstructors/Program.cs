namespace P06___DemoConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p);

            Person p1 = new Person("Ivan",20);
            Console.WriteLine(p1);
        }
    }
}
