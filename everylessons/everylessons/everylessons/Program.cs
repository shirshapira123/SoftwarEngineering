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
        static void Main(string[] args)
        {
            Console.Write("your name: ");
            string name = Console.ReadLine();
            Console.Write("your id: ");
            string id = Console.ReadLine();
            Student student1 = new Student(name, id);

            Console.Write("your name: ");
            name = Console.ReadLine();
            Console.Write("your id: ");
            id = Console.ReadLine();
            Student student2 = new Student(name, id);

            Console.WriteLine("Enter list of grades to the first student: ");
            int grade = int.Parse(Console.ReadLine());
            while (grade >= 0 && grade <= 100)
            {
                student1.AddGrade(grade);
                grade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter list of grades to the second student: ");
            grade = int.Parse(Console.ReadLine());
            while (grade >= 0 && grade <= 100)
            {
                student2.AddGrade(grade);
                grade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());

            double avg1 = student1.CalculateAvg();
            double avg2 = student2.CalculateAvg();
            bool biggerAvg = avg1 > avg2;
            Console.WriteLine($"\n{student1.GetName()}'s avarage is: {avg1}");
            Console.WriteLine($"{student2.GetName()}'s avarage is: {avg2}");
            if (biggerAvg)
                Console.WriteLine($"the avarage of student: {student1.GetName()}, id: {student1.GetId()}, is bigger.");           
            else
                Console.WriteLine($"the avarage of student: {student2.GetName()}, id: {student2.GetId()}, is bigger.");

            student1.UpdateGrade(1, 100);
            student1.UpdateGrade(GetLength(student1.GetGradesList()), 100);
            Console.WriteLine(student1.ToString());

            student2.DeleteGrade(3);
            Console.WriteLine(student2.ToString());
            Console.ReadKey();

        }
    }
}


//זכויות יוצרים למגניבים המדליקים   