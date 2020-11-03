using System;

namespace everylessons
{
    class Program
    {
        public static int DigitSum(int a)
        {
            int sum = 0;
            if (a < 10)
                return a;
            sum = DigitSum(a / 10);
            return a % 10 + sum;
        }
        public static int Length(int a)
        {
            int len = 0;
            if (a < 10)
                return 1;
            len = Length(a / 10);
            return len + 1;
        }
        public static bool Search(int num, int a)
        {
            bool check = false;
            if (num < 10 && num != a)
                return false;
            if (num % 10 == a)
                return true;
            check = Search(num / 10, a);
            return check;
        }
        public static int BigestNum(int num)
        {
            int max = num % 10;
            if (num < 10)
                return max;
            max = Math.Max(max, BigestNum(num / 10));
            return max;
        }
        public static int SumNum(int num, int a)
        {
            int sumnum = 0;
            if (num < 10)
            {
                if (num == a)
                    return 1;
                return 0;
            }
            if (num % 10 == a)
                sumnum ++;
            sumnum += SumNum(num / 10, a);
            return sumnum;

        }
        public static int Atseret(int a)
        {
            int number = 1;
            if (a == 0)
                return 1;
            number = Atseret(a - 1);
            return a * number;

        }
        public static int Times(int num1, int num2)
        {
            int times = 0;
            if (num2 > num1)
                return 0;
            num1 -= num2;
            times++;
            times += Times(num1, num2);
            return times;
        }
        public static int Rest(int num1, int num2)
        {
            int rest = 0;
            if (num1 - num2 < num2)
                rest = num1 - num2;
            else
                rest = Rest(num1 - num2, num2);
            return rest;
        }
        public static int Pow(int a, int b)
        {
            int number = 1;
            if (b == 0)
                return 1;
            number = Pow(a, b - 1);
            return a * number;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(DigitSum(123));
            //Console.WriteLine(DigitSum(124));
            //Console.WriteLine(DigitSum(153));

            //Console.WriteLine(Length(3456789));
            //Console.WriteLine(Length(345678));
            //Console.WriteLine(Length(34569));

            //Console.WriteLine(Search(12345, 4));
            //Console.WriteLine(Search(12345, 6));
            //Console.WriteLine(Search(10345, 1));

            //Console.WriteLine(BigestNum(987654321));
            //Console.WriteLine(BigestNum(654321));
            //Console.WriteLine(BigestNum(21));

            //Console.WriteLine(SumNum(123123121, 1));
            //Console.WriteLine(SumNum(123123121, 2));
            //Console.WriteLine(SumNum(123123121, 3));

            //Console.WriteLine(Atseret(5));
            //Console.WriteLine(Atseret(3));
            //Console.WriteLine(Atseret(0));

            //Console.WriteLine(Times(10,2));
            //Console.WriteLine(Times(10,4));
            //Console.WriteLine(Times(13,3));

            //Console.WriteLine(Rest(13,2));
            //Console.WriteLine(Rest(14,2));
            //Console.WriteLine(Rest(14,8));


            //Console.WriteLine(Pow(5,3));
            //Console.WriteLine(Pow(2,4));
            //Console.WriteLine(Pow(3,0));
            Console.ReadKey();
        }
    }
}

//זכויות יוצרים למגניבים המדליקים   