namespace P11___w12___Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Square side: ");
            var side = double.Parse(Console.ReadLine());
            var p = Geometry.SquarePerimeter(side);
            var s = Geometry.SquareArea(side);
            Console.WriteLine($"Square Perimeter = {p}");
            Console.WriteLine($"Square Area = {s}");

            Console.Write("Rectangle sides [a,b]: ");
            var sides = Console.ReadLine().Split().Select(double.Parse).ToArray();
            p = Geometry.RectanglePerimeter(sides[0], sides[1]);
            s = Geometry.RectangleArea(sides[0], sides[1]);
            Console.WriteLine($"Rectangle Perimeter = {p}");
            Console.WriteLine($"Rectangle Area = {s}");

            Console.Write("Circle Radius: ");
            var r = double.Parse(Console.ReadLine());
            s = Geometry.CircleArea(r);
            Console.WriteLine("Circle Area = {0}", s);
        }
    }
}
