namespace P18___III___w7___BOX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box b = new Box(2,3,4);

            Console.WriteLine(b);
            b.Obem();
            Console.WriteLine(b.Volume());
        }
    }
}
