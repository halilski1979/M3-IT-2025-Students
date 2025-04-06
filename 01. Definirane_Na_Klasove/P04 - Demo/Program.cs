namespace P04___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person p1 = new Person();

            p.Name = "Ivan";
            p.Age = 25;

            p1.Name = "Kiril";
            p1.Age = 34;

            p.Print();
            p1.Print();

            Console.WriteLine(p.Pechat());
            Console.WriteLine(p1.Pechat());

            Console.WriteLine(p);
            Console.WriteLine(p1);
        }
    }
}
