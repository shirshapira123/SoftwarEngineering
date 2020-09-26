using System;

namespace everylessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[5];
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("Enter X: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y: ");
                int y = int.Parse(Console.ReadLine());
                points[i] = new Point(x, y);
            }
            Point a = new Point();
            for (int i = 0; i < points.Length; i++)
                Console.WriteLine(points[i].ToString());
            for (int i = 0; i < points.Length; i++)
                Console.WriteLine($"Distace from point a to point number {i + 1}: " + points[i].Distance(a));
            int quadrant_one = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].Quadrant() == 1)
                    quadrant_one++;
            }
            Console.WriteLine(quadrant_one + " points in quadrant number 1");
            points[1].SetX(points[1].GetX() - 3);
            Console.WriteLine("point 2 after sliding: " + points[1].ToString());
            for (int i = 0; i < points.Length; i++)
            {
                points[i].SetY(points[i].GetY() - 5);
                Console.WriteLine($"point {i+1} after sliding: {points[i].ToString()}");
            }
            Point middle = points[0].Middle(points[4]);
            Console.WriteLine("middle betwin the first and last point: " + middle.ToString());

            double max = 0;
            int point_max = 0;
            for (int i = 0; i < points.Length; i++)
            {
                max = Math.Max(max, points[i].Distance(a));
                if (points[i].Distance(a) == max)
                    point_max = i;
            }
            Console.WriteLine(points[point_max].ToString());

            Console.ReadKey();

        }
    }
}

//זכויות יוצרים למגניבים המדליקים   