using System;

namespace everylessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(43, 7);
            Point point2 = new Point(5, 5);
            Console.WriteLine("point 1: " + point1.ToString());
            Console.WriteLine("point 2: " + point2.ToString());
            Console.WriteLine("distance: " + point1.Distance(point2));
            double num = point1.GetX();
            point1.SetX(point2.GetX());
            point2.SetX(num);
            Console.WriteLine("point 1:" + point1.ToString());
            Console.WriteLine("point 2:" + point2.ToString());
            Point middle = point1.Middle(point2);
            Console.WriteLine("middle point: " + middle.ToString());
            Console.ReadKey();
        }
    }
}

//זכויות יוצרים למגניבים המדליקים   