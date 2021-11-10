using System;

namespace LineComparisionLength
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter x1: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2: ");
            int x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter y2: ");
            int y2 = int.Parse(Console.ReadLine());
            Line obj1 = new Line();
            obj1.computelength(x1, y1, x2, y2);

        }
    }
}
