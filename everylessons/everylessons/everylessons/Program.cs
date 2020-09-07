using System;

namespace everylessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first date:\nYear: ");
            int year1 = int.Parse(Console.ReadLine());
            Console.Write("month: ");
            int month1 = int.Parse(Console.ReadLine());
            Console.Write("day: ");
            int day1 = int.Parse(Console.ReadLine());
            Console.Write("enter second date:\nYear: ");
            int year2 = int.Parse(Console.ReadLine());
            Console.Write("month: ");
            int month2 = int.Parse(Console.ReadLine());
            Console.Write("day: ");
            int day2 = int.Parse(Console.ReadLine());
            Date date1 = new Date(year1, month1, day1);
            Date date2 = new Date(year2, month2, day2);
            Console.WriteLine("date N.1: " + date1.ToString());
            Console.WriteLine("date N.2: " + date2.ToString());
            int compare = date1.CompareTo(date2);
            if(compare > 0)
                Console.WriteLine("date number 1 is latest.");
            else if(compare < 0)
                Console.WriteLine("date number 2 is latest.");
            else
                Console.WriteLine("these dates are equale");
            Console.WriteLine(date1);
            Console.ReadKey();
        }
    }
}

//זכויות יוצרים למגניבים המדליקים   