using System;

namespace everylessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> list = new Node<int>(1);
            list.SetNext(new Node<int>(2));
            list.GetNext().SetNext(new Node<int>(3));
            list.GetNext().GetNext().SetNext(new Node<int>(4));
            list.GetNext().GetNext().GetNext().SetNext(new Node<int>(5));
            Console.WriteLine(list.GetInfo());
            Console.WriteLine(list.GetNext().GetInfo());
            Console.WriteLine(list.GetNext().GetNext().GetInfo());
            Console.WriteLine(list.GetNext().GetNext().GetNext().GetInfo());
            Console.WriteLine(list.GetNext().GetNext().GetNext().GetNext().GetInfo());
            Console.ReadKey();
        }
    }
}

//זכויות יוצרים למגניבים המדליקים   