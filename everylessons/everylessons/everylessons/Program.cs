using System;

namespace everylessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first line:");
            Console.Write("enter x1: ");
            double x1 = int.Parse(Console.ReadLine());
            Console.Write("enter y1: ");
            double y1 = int.Parse(Console.ReadLine());
            Console.Write("enter x2: ");
            double x2 = int.Parse(Console.ReadLine());
            Console.Write("enter y2: ");
            double y2 = int.Parse(Console.ReadLine());
            Line line1 = new Line(x1, y1, x2, y2);
            Console.WriteLine("second line:");
            Console.Write("enter x1: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("enter y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("enter x2: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("enter y2: ");
            y2 = int.Parse(Console.ReadLine());
            Line line2 = new Line(x1, y1, x2, y2);
            Console.WriteLine("start point of the first line: " + line1.GetStartPoint());
            Console.WriteLine("last point of the second line: " + line2.GetEndPoint());
            line2.SetStartPoint(0, 0);
            Console.WriteLine("line 1: " + line1);
            Console.WriteLine("line 2: " + line2);
            Console.WriteLine("line 1 function: " + line1.FunctionLine());
            Console.WriteLine("line 2 function: " + line2.FunctionLine());
            Console.WriteLine("line 1 length: " + line1.LengthLine());
            Console.WriteLine("line 2 length: " + line2.LengthLine());
            Console.WriteLine("line 1 middle point: " + line1.GetMiddleLine());
            if (line1.Is90AngleLines(line2))
                Console.WriteLine("these two lines form a right angle");
            else
                Console.WriteLine("these two lines don't form a right angle");
            if (line1.IsParallelLines(line2))
                Console.WriteLine("these two lines are parallel");
            else
                Console.WriteLine("these two lines aren't parallel");
            if (line1.IsVerticalLine())
                Console.WriteLine("line 1 is vertical");
            else
                Console.WriteLine("line 1 is not vertical");
            if (line2.IsHorizontalLine())
                Console.WriteLine("line 2 is horizontal");
            else
                Console.WriteLine("line 2 is not horizontal");


            Line[] polygon = new Line[10];
            Random rnd = new Random();
            double first_line_x = rnd.Next(-10, 11);
            double first_line_y = rnd.Next(-10, 11);
            x1 = rnd.Next(-10, 11);
            y1 = rnd.Next(-10, 11);
            polygon[0] = new Line(first_line_x, first_line_y, x1,y1);
            for (int i = 1; i < polygon.Length-1; i++)
            {
                x2 = rnd.Next(-10, 11);
                y2 = rnd.Next(-10, 11);
                polygon[i] = new Line(x1, y1, x2, y2);
                x1 = x2;
                y1 = y2;
            }
            polygon[9] = new Line(x1, y1, first_line_x, first_line_y);
            foreach (Line item in polygon)
            {
                Console.WriteLine(item);
            }
            int counter = 0;
            for (int i = 0; i < polygon.Length; i++)
            { 
                    if (!polygon[i].IsHorizontalLine() && !polygon[i].IsVerticalLine()) 
                        counter++;  
            }
            Console.WriteLine($"there are {counter} lines who aren't vertical and not horizontal");
            bool parallel = false;
            for (int i = 0; i < polygon.Length; i++)
            {
                for (int k = 0; k < polygon.Length; k++)
                {
                    if (polygon[i].IsParallelLines(polygon[k]) && i != k)
                    {
                        parallel = true;
                    }
                }
            }
            if(parallel)
                Console.WriteLine("there are some parallel lines");
            else
                Console.WriteLine("there are 0 parallel lines");
            double p = 0;
            for (int i = 0; i < polygon.Length; i++)
                p += polygon[i].LengthLine();
            Console.WriteLine($"the circumference of the polygon is {p}");
            Line connector = new Line(polygon[0].GetStartPoint().GetX(), polygon[0].GetStartPoint().GetY(), polygon[4].GetStartPoint().GetX(), polygon[4].GetStartPoint().GetY());
            Console.WriteLine("new line betwin first point of line number 1 and first point of line number 5: " + connector);
            Console.ReadKey();
        }
    }
}

//זכויות יוצרים למגניבים המדליקים   