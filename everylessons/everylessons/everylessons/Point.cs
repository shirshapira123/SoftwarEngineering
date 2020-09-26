using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Point
    {
        double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public double GetX() => x;
        public double GetY() => y;
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public double Distance(Point p)
        {
            double delthaX = Math.Pow(p.GetX() - x, 2);
            double delthaY = Math.Pow(p.GetY() - y, 2);
            return Math.Sqrt(delthaX + delthaY);
        }
        public Point Middle(Point p)
        {
            double xMiddle = (p.GetX() + x) / 2;
            double yMiddle = (p.GetY() + y) / 2;
            return new Point(xMiddle, yMiddle);
        }
        public int Quadrant()
        {
            if (x == 0 || y == 0)
                return 0;
            if (x > 0 && y > 0)
                return 1;
            if (x < 0 && y > 0)
                return 2;
            if (x < 0 && y < 0)
                return 3;    
            return 4;
        }
        public override string ToString() => ($"({x},{y})");
        
    }
}