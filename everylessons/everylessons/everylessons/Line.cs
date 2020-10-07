using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Line
    {
        double x1, y1, x2, y2;
        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        /// <summary>
        /// return the first point
        /// </summary>
        /// <returns>start_point(Point)</returns>
        public Point GetStartPoint()
        {
            Point start_point = new Point(x1, y1);
            return start_point;
        }
        /// <summary>
        /// return the last point
        /// </summary>
        /// <returns>end_point(Point)</returns>
        public Point GetEndPoint()
        {
            Point end_point = new Point(x2, y2);
            return end_point;
        }
        /// <summary>
        /// set the start of the line
        /// </summary>
        /// <param name="x1">the x of the first point</param>
        /// <param name="y1">the y of the first point</param>
        public void SetStartPoint(double x1, double y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        /// <summary>
        /// set the end of the line
        /// </summary>
        /// <param name="x2">the x of the end point</param>
        /// <param name="y2">the y of the end point</param>
        public void SetEndPoint(double x2, double y2)
        {
            this.x2 = x2;
            this.y2 = y2;
        }
        /// <summary>
        /// the line description
        /// </summary>
        /// <returns>returns the line description(string)</returns>
        public override string ToString()
        {
            return ($"({x1},{y1})--->({x2},{y2})");
        }
        /// <summary>
        /// check if the line is horizontal
        /// </summary>
        /// <returns>if horizontal returns true else retruns false</returns>
        public bool IsHorizontalLine()
        {
            if (x1 == x2)
                return true;
            return false;
        }
        /// <summary>
        /// check if the line is vertical
        /// </summary>
        /// <returns>if vertical returns true else retruns false</returns>
        public bool IsVerticalLine()
        {
            if (y1 == y2)
                return true;
            return false;
        }
        /// <summary>
        /// calculate the length of the line
        /// </summary>
        /// <returns>length(double)</returns>
        public double LengthLine()
        {
            Point start_point = new Point(x1, y1);
            Point end_point = new Point(x2, y2);
            return start_point.Distance(end_point);
        }
        /// <summary>
        /// find the middle point (the point that placed in the middle of the line)
        /// </summary>
        /// <returns>the middle point(Point)</returns>
        public Point GetMiddleLine()
        {
            Point start_point = new Point(x1, y1);
            Point end_point = new Point(x2, y2);
            return start_point.Middle(end_point);
        }
        /// <summary>
        /// make the line look like a function
        /// </summary>
        /// <returns>returns fanction like string: mx+b(string)</returns>
        public string FunctionLine()
        {
            double m = (y1 - y2) / (x1 - x2);
            double b = m * x1 * (-1) + y1;
            if (b == 0)
                return $"y={m}x";
            if (b > 0)
                return $"y={m}x+{b}";
            return $"y={m}x-{b}";
        }
        /// <summary>
        /// that action get point and check if the point is on the line
        /// </summary>
        /// <param name="a">point to check</param>
        /// <returns>if the point is on the line return true, else return false</returns>
        public bool IsPointOnTheLine(Point a)
        {
            double m = (y1 - y2) / (x1 - x2);
            double b = m * x1 * (-1) + y1;
            double y = m*a.GetX()-b;
            if (y == a.GetY())
                return true;
            return false;
        }
        /// <summary>
        /// Gets another line and checks if the current line and the extra line form a right angle
        /// </summary>
        /// <param name="otherLine">another line</param>
        /// <returns>if the current line and the extra line form a right angle returns true else return true</returns>
        public bool Is90AngleLines(Line otherLine)
        {
            double m1 = (y1 - y2) / (x1 - x2);
            double m2 = (otherLine.GetStartPoint().GetY() - otherLine.GetEndPoint().GetY()) / (otherLine.GetStartPoint().GetX() - otherLine.GetEndPoint().GetX());
            if (m1 / m2 == -1)
                return true;
            return false;
        }
        /// <summary>
        /// Gets another line and checks if the current line and the other line are parallel
        /// </summary>
        /// <param name="otherLine">another line</param>
        /// <returns>if the current line and the extra line are parallel returns true else return true</returns>
        public bool IsParallelLines(Line otherLine)
        {
            double m1 = (y1 - y2) / (x1 - x2);
            double m2 = (otherLine.GetStartPoint().GetY() - otherLine.GetEndPoint().GetY()) / (otherLine.GetStartPoint().GetX() - otherLine.GetEndPoint().GetX());
            if (m1 == m2)
                return true;
            return false;
        }

    }
}
