using System;

namespace everylessons
{
    class Program
    {
        public static Node<int> BuildRegularList()
        {
            Node<int> list = null;
            Node<int> last = null;
            int num;
            Console.WriteLine("Enter a list of numbers and a negative number when your'e done");
            num = int.Parse(Console.ReadLine());
            while (num >= 0)
            {
                if (list == null)
                {
                    list = new Node<int>(num);
                    last = list;
                }
                else
                {
                    last.SetNext(new Node<int>(num));
                    last = last.GetNext();
                }
                num = int.Parse(Console.ReadLine());
            }
            return list;
        }
        public static Node<int> BuildInsolentList()
        {
            Console.WriteLine("Enter a list of numbers and a negative number when your'e done");
            int num = int.Parse(Console.ReadLine());
            Node<int> list = new Node<int>(num);
            while (num > 0)
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                    list = new Node<int>(num, list);
            }
            return list;
        }
        public static void OutputList(Node<int> list)
        {
            Node<int> pos = list;
            while (pos != null)
            {
                Console.Write(pos.GetInfo() + "    ");
                pos = pos.GetNext();
            }
            Console.WriteLine();
        }
        public static int TimesAtList(Node<int> list, int x)
        {
            int counter = 0;
            Node<int> pos = list;
            while (pos != null)
            {
                if(pos.GetInfo() == x)
                    counter++;
                pos = pos.GetNext();
            }
            return counter;
        }
        public static int GetLength(Node<int> list)
        {
            int counter = 0;
            Node<int> pos = list;
            while (pos != null)
            {
                counter++;
                pos = pos.GetNext();
            }
            return counter;
        }
        public static bool IsAppears(Node<int> list, int num)
        {
            Node<int> pos = list;
            while (pos != null)
            {
                if (num == pos.GetInfo())
                    return true;
                pos = pos.GetNext();
            }
            return false;
        }
        public static int GetSumOfList(Node<int> list)
        {
            int sum = 0;
            Node<int> pos = list;
            while (pos != null)
            {
                sum += pos.GetInfo();
                pos = pos.GetNext();
            }
            return sum;
        }
        public static int EvenNumbers(Node<int> list)
        {
            int counter = 0;
            Node<int> pos = list;
            while (pos != null)
            {
                if (pos.GetInfo() % 2 == 0)
                    counter ++;
                pos = pos.GetNext();
            }
            return counter;
        }
        public static void ChangeFirstAndLast(Node<int> list)
        {
            int counter = 0;
            Node<int> pos = list;
            int first = pos.GetInfo();
            while (pos != null)
            {
                counter++;
                if (pos != null)
                    list.SetInfo(pos.GetInfo());
                pos = pos.GetNext();
            }
            pos = list;
            for (int i = 0; i < counter; i++)
            {
                if (i == counter - 1)
                    pos.SetInfo(first);
                pos = pos.GetNext();
            }
        }
        public static void ChangeTheNumberX(Node<int> list, int x, int y)
        {
            Node<int> pos = list;
            while (pos != null)
            {
                if(pos.GetInfo() == x)
                    pos.SetInfo(y);
                pos = pos.GetNext();
            }
        }
        public static void AddToList(Node<int> list, int x)
        {
            int counter = 0;
            Node<int> pos = list;
            while (pos != null)
            {
                counter++;
                pos = pos.GetNext();
            }
            pos = list;
            for (int i = 0; i < counter - 1; i++)
            {
                pos = pos.GetNext();
            }
            pos.SetNext(new Node<int>(x));
        }
        public static bool IsAscendingSeries(Node<int> list)
        {
            int max = 0;
            Node<int> pos = list;
            while (pos != null)
            {
                if (max > pos.GetInfo())
                    return false;
                max = pos.GetInfo();
                pos = pos.GetNext();
            }
            return true;
        }
        public static bool IsInvoiceSeries(Node<int> list)
        {
            int distance = list.GetNext().GetInfo()-list.GetInfo();
            int counter = 0;
            Node<int> pos = list;
            while (pos != null)
            {
                counter++;
                pos = pos.GetNext();
            }
            pos = list;
            for (int i = 0; i < counter-1; i++)
            {
                if (pos.GetNext().GetInfo() - pos.GetInfo() != distance)
                    return false;
                pos = pos.GetNext();
            }
            return true;
        }
        public static int GetNode(Node<int> list, int k)
        {
            Node<int> pos = list;
            int counter = 0;
            while (pos != null)
            {
                counter++;
                pos = pos.GetNext();
            }
            int num = k % counter;
            int wanted = 0;
            pos = list;
            for (int i = 0; i <= num; i++)
            {
                if (i == num-1)
                {
                    wanted = pos.GetInfo();
                }
                pos = pos.GetNext();
            }
            return wanted;
        }
        public static bool IsPalindrome(Node<int> list)
        {
            Node<int> pos = list;
            Node<int> tsil = null;
            while (pos != null)
            {
                tsil = new Node<int>(pos.GetInfo());
                pos = pos.GetNext();
            }
            pos = list;
            while (tsil != null)
            {
                if (pos.GetInfo() != tsil.GetInfo())
                    return false;
                tsil = tsil.GetNext();
                pos = pos.GetNext();
            }
            return true;
        }
        public static Node<int> GetOddNumbers(Node<int> list)
        {
            Node<int> pos = list;
            Node<int> ddo = null;
            Node<int> odd = null;
            while (pos != null)
            {
                if (pos.GetInfo() % 2 != 0)
                    ddo = new Node<int>(pos.GetInfo(), ddo);
                pos = pos.GetNext();
            }
            while (ddo != null)
            {
                odd = new Node<int>(ddo.GetInfo(),odd);
                ddo = ddo.GetNext();
            }
            return odd;
        }
        public static bool IsInclude(Node<int> list1, Node<int> list2)
        {
            Node<int> pos = list2;
            while (pos != null)
            {
                if (!IsAppears(list1, pos.GetInfo()))
                    return false;
                pos = pos.GetNext();
            }
            return true;
        }
        public static Node<int> MatualNodes(Node<int> list1, Node<int> list2)
        {
            Node<int> pos = list2;
            Node<int> list = null;
            while (pos != null)
            {
                if (IsAppears(list1, pos.GetInfo()))
                    list = new Node<int>(pos.GetInfo(), list);
                pos = pos.GetNext();
            }
            return list;
        }
        static void Main(string[] args)
        {
            Node<int> list1 = BuildInsolentList();
            Console.Write("Insolent list:");
            OutputList(list1);
            Node<int> list = BuildRegularList();
            Console.Write("Regular list:");
            OutputList(list);
            Console.WriteLine($"the number 1 appears {TimesAtList(list, 1)} times in the list.");
            Console.WriteLine($"there are {GetLength(list)} nodes in the list.");
            if (IsAppears(list, 2))
                Console.WriteLine("the number 2 exists in the list");
            else
                Console.WriteLine("the number 2 does not exist in the list");
            Console.WriteLine($"The sum of all the numbers in the list is {GetSumOfList(list)}");
            Console.WriteLine($"there are {EvenNumbers(list)} even numbers.");
            ChangeFirstAndLast(list);
            Console.WriteLine("\nReplaces the first number with the last number:");
            OutputList(list);
            ChangeTheNumberX(list, 3, 4);
            Console.WriteLine("\nReplaces the number 3 with the number 4:");
            OutputList(list);
            AddToList(list, 11);
            Console.WriteLine("\nadd the number 11 to list:");
            OutputList(list);
            if (IsAscendingSeries(list))
                Console.WriteLine("the list is an ascending series");
            else
                Console.WriteLine("the list is not an ascending series");
            Console.ReadKey();
            if (IsInvoiceSeries(list))
                Console.WriteLine("the list is an invoice series");
            else
                Console.WriteLine("the list is not an invoice series");
            Console.WriteLine($"The fifth link contains the number {GetNode(list, 5)}");
            if (IsPalindrome(list))
                Console.WriteLine("the list is a Palindrome");
            else
                Console.WriteLine("the list is not an Palindrome");
            Console.WriteLine();
            Console.WriteLine("list of the odd numbers:");
            OutputList(GetOddNumbers(list));
            Node<int> list2 = BuildRegularList();
            if (IsInclude(list, list2))
                Console.WriteLine("the source list contains the new list");
            else
                Console.WriteLine("the source list doesn't contains the new list");
            Node<int> list12 = MatualNodes(list, list2);
            Console.WriteLine("\nmatual list(the source one and the last one): ");
            OutputList(list12);

            Console.ReadKey();
        }
    }
}


//זכויות יוצרים למגניבים המדליקים   