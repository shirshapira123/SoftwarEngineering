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
        public static Node<int> DeleteNumber(Node<int> list, int num)
        {
            if (list == null)
                return null;
            if (list.GetInfo() == num)
                return list.GetNext();
            Node<int> pos = list;
            while (pos.GetNext() != null)
            {
                if(pos.GetNext().GetInfo() == num)
                {
                    pos.SetNext(pos.GetNext().GetNext());
                    return list;
                }
                pos = pos.GetNext();
            }
            return list;
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
        public static Node<int> DeleteAll(Node<int> list, int num)
        {
            if (list == null)
                return list;
            while (IsAppears(list, num))
                list = DeleteNumber(list, num);
            return list;
        }
        public static Node<int> AddNumberToSortedList(Node<int> list, int num)
        {
            if (list == null || num <= list.GetInfo())
                return new Node<int>(num, list);
            Node<int> pos = list;
            while (pos.GetNext() != null) 
            { 
                if(pos.GetNext().GetInfo() > num) 
                {
                    Node<int>temp = new Node<int> (num, pos.GetNext());
                    pos.SetNext(temp);          
                    return list;
                }
                pos = pos.GetNext();
            }
            pos.SetNext(new Node<int>(num));
            return list;
        }
        static void Main(string[] args)
        {
            Node<int> list1 = BuildRegularList();
            OutputList(list1);
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            list1 = AddNumberToSortedList(list1, num);
            OutputList(list1);
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            list1 = AddNumberToSortedList(list1, num);
            OutputList(list1);
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            list1 = AddNumberToSortedList(list1, num);
            OutputList(list1);

            Node<int> list = BuildRegularList();
            OutputList(list);
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            list = DeleteAll(list, num);
            OutputList(list);
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            list = DeleteNumber(list, num);
            OutputList(list);
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            list = DeleteNumber(list, num);
            OutputList(list);
            Console.ReadKey();
        }
    }
}


//זכויות יוצרים למגניבים המדליקים   