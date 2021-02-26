using System;

namespace everylessons
{
    class Program
    {
        //1
        public static Node<Book> BuildBookList(int n)
        {

            Node<Book> list = null;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the name of the book: ");
                string name = Console.ReadLine();
                Console.Write("Enter the author name: ");
                string author = Console.ReadLine();
                Console.Write("Enter the price: ");
                double price = double.Parse(Console.ReadLine());
                Book book = new Book(name, author, price);
                list = new Node<Book>(book, list);
            }
            return list;
        }
        //2
        public static Node<Student> BuildStudentList()
        {
            int n = 10;
            Node<Student> list = null;
            bool flag = true;
            Console.WriteLine("\nenter student stats- when your done, write 'end' at the name title.");
            while (flag)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                flag = !name.Equals("end");
                if (!flag)
                    break;
                Console.Write("Enter your id: ");
                string id = Console.ReadLine();
                Console.Write("Enter your gender: ");
                char gender = char.Parse(Console.ReadLine());
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter {n} grades: ");
                double[] grades = new double[n];
                for (int i = 0; i < n; i++)
                {
                    grades[i] = double.Parse(Console.ReadLine());
                }
                Student student = new Student(name, id, gender, age, grades);
                list = new Node<Student>(student, list);
            }
            return list;
        }
        //3
        public static void OutputBooks(Node<Book> list)
        {
            Console.WriteLine("\nlist of books: ");
            Node<Book> pos = list;
            while (pos != null)
            {
                Console.Write(pos.GetInfo());
                pos = pos.GetNext();
            }
        }
        //for main
        public static void OutputStudents(Node<Student> list)
        {
            Console.WriteLine("\nlist of students: ");
            Node<Student> pos = list;
            while (pos != null)
            {
                Console.Write(pos.GetInfo());
                pos = pos.GetNext();
            }
        }
        //for main
        public static void OutputItems(Node<Item> list, double num)
        {
            Console.WriteLine($"\nlist of students above the grade {num}: ");
            Node<Item> pos = list;
            while (pos != null)
            {
                Console.Write(pos.GetInfo());
                pos = pos.GetNext();
            }
        }
        //4
        public static Book IsExist(Node<Book> list, string name)
        {
            Node<Book> pos = list;
            while(pos != null)
            {
                if(pos.GetInfo().GetName().Equals(name) && pos.GetInfo().GetIsExist())
                {
                    return pos.GetInfo();
                }
                pos = pos.GetNext();
            }
            return null;
        }
        //5
        public static void ChangeStatus(Node<Book> list)
        {
            Node<Book> pos = list;
            while(pos != null)
            {
                if (pos.GetInfo().GetPrice() > 100 && pos.GetInfo().GetName()[0] == 'A')
                {
                    pos.GetInfo().SetIsExist(false);
                }
                pos = pos.GetNext();
            }
            Console.WriteLine("All the books which started with the letter 'A' and their price is more then 100 have been changed to unvailable.");
        }
        //6
        public static void AddBook(Node<Book> list, Book book)
        {
            bool flag = false;
            Node<Book> pos = list;
            while (pos != null)
            {
                if (pos.GetInfo().GetName().Equals(book.GetName()) && pos.GetInfo().GetIsExist())
                {
                    flag = true;
                }
                pos = pos.GetNext();
            }
            if (flag)
            {
                Console.WriteLine("This book is already exist.");
            }
            else
            {
                pos = list;
                while(pos.GetNext() != null)
                {
                    pos = pos.GetNext();
                }
                pos.SetNext(new Node<Book>(book));
                Console.WriteLine("the book has been added to list!");
            }
        }
        //7 check
        public static Node<Book> DeleteBook(Node<Book> list, string name)
        {
            if (list == null)
                return null;
            if (list.GetInfo().GetName() == name)
                return list.GetNext();
            Node<Book> pos = list;
            while (pos.GetNext() != null)
            {
                if (pos.GetNext().GetInfo().GetName() == name)
                {
                    pos.SetNext(pos.GetNext().GetNext());
                    Console.WriteLine("the book has been deleted.");
                    return list;
                }
                pos = pos.GetNext();
            }
            return list;
            
        }
        //8
        public static double[] GetGradesById(Node<Student> list, string id)
        {
            Node<Student> pos = list;
            while(pos != null)
            {
                if(pos.GetInfo().GetId().Equals(id))
                {
                    return pos.GetInfo().GetGrades();
                }
                pos = pos.GetNext();
            }
            return null;
        }
        //9
        public static double AvarageGrades(Node<Student> list, string id)
        {
            double[] grades;
            double avg = 0;
            Node<Student> pos = list;
            while (pos != null)
            {
                if (pos.GetInfo().GetId().Equals(id))
                {
                    grades = pos.GetInfo().GetGrades();
                    for (int i = 0; i < grades.Length; i++)
                    {
                        avg += grades[i];
                    }
                    avg /= grades.Length;
                    return avg;
                }
                pos = pos.GetNext();
            }
            return -1;
        }
        //10
        public static Node<Student> AddStudentToSortedList(Node<Student> list, Student student)
        {
            if (list == null || int.Parse(student.GetId()) <= int.Parse(list.GetInfo().GetId()))
                return new Node<Student>(student, list);
            Node<Student> pos = list;
            while (pos.GetNext() != null)
            {
                if (int.Parse(pos.GetNext().GetInfo().GetId()) > int.Parse(student.GetId()))
                {
                    Node<Student> temp = new Node<Student>(student, pos.GetNext());
                    pos.SetNext(temp);
                    Console.WriteLine("the student have been added to the list");
                    return list;
                }
                pos = pos.GetNext();
            }
            pos.SetNext(new Node<Student>(student));
            return list;
        }
        //11
        public static void IsThereTwins(Node<Student> list)
        {
            string lastName1;
            string lastName2;
            bool flag = false;
            Node<Student> pos1 = list;
            Node<Student> pos2 = list;
            while(pos1 != null && !flag)
            {
                try
                {
                    lastName1 = pos1.GetInfo().GetName().Split(' ')[1];
                }
                catch
                {
                    lastName1 = "";
                }
                while(pos2 != null && !flag)
                {
                    try
                    {
                        lastName2 = pos2.GetInfo().GetName().Split(' ')[1];
                    }
                    catch
                    {
                        lastName2 = "";
                    }
                    if (lastName2.Equals(lastName1))
                        flag = true;
                    pos2 = pos2.GetNext();
                }
                pos1 = pos1.GetNext();
            }
            if (flag)
            {
                Console.WriteLine("\nThere are twins in the list.\n");
            }
            else
            {
                Console.WriteLine("\nThere aren't twins in the list.\n");
            }
        }
        //12
        public static Node<string> SmartStudents(Node<Student> list)
        {
            Node<Student> pos = list;
            Node<string> smartStudents = null;
            double avg;
            while(pos != null)
            {
                avg = AvarageGrades(list, pos.GetInfo().GetId());
                if (avg > 90)
                    smartStudents = new Node<string>(pos.GetInfo().GetName(), smartStudents) ;
                pos = pos.GetNext();
            }
            return smartStudents;
        }
        // 13
        public static Node<Student> GetGirls(Node<Student> list) 
        {
            Node<Student> pos = list;
            Node<Student> girls = null;
            while (pos != null)
            {
                if (pos.GetInfo().GetGender() == 'F')
                {
                    if (girls == null)
                    {
                        girls = new Node<Student>(pos.GetInfo());
                    }
                    else
                    {
                        girls.SetNext(new Node<Student>(pos.GetInfo()));
                    }
                }
                pos = pos.GetNext();
            }
            return girls;
        }
        //14
        public static Node<Item> ItemList(Node<Student> list, double grade)
        {
            Node<Item> resultList = null;
            Node<Student> pos = list;
            Item item;
            while(pos != null)
            {
                double avg = AvarageGrades(list, pos.GetInfo().GetId());
                if (avg > grade)
                {
                    item = new Item(pos.GetInfo().GetId(), pos.GetInfo().GetGender());
                    resultList = new Node<Item>(item, resultList);
                }
                pos = pos.GetNext();
            }
            return resultList;
        }
        
        static void Main(string[] args)
        {

            //1
            Node<Book> books = BuildBookList(2);

            //3
            OutputBooks(books);

            //4
            Console.Write("\nEnter the name of the book you want to search: ");
            string name = Console.ReadLine();
            Book book = IsExist(books, name);
            if (book != null)
                Console.WriteLine(book);
            else
                Console.WriteLine("the book doesn't exist.");

            //5
            ChangeStatus(books);
            OutputBooks(books);

            //6
            Console.Write("\nenter the name of the new book: ");
            name = Console.ReadLine();
            Console.Write("enter the author's name of the new book: ");
            string author = Console.ReadLine();
            Console.Write("enter the price of the new book: ");
            double price = double.Parse(Console.ReadLine());
            Book newBook = new Book(name, author, price);
            AddBook(books, newBook);
            OutputBooks(books);

            //7
            Console.Write("\nenter the name of the book you want to delete: ");
            name = Console.ReadLine();
            books = DeleteBook(books, name);
            OutputBooks(books);

            //2
            Node<Student> students = BuildStudentList();
            OutputStudents(students);


            //8
            Console.Write("\nEnter the id of the student you want his grades: ");
            string id = Console.ReadLine();
            double[] grades = GetGradesById(students, id);
            if (grades != null)
            {
                Console.Write("The grades: ");
                foreach (double i in grades)
                    Console.Write(i + ", ");
                Console.WriteLine();
            }
            else
                Console.WriteLine("The student doesn't exist.");

            //9
            Console.Write("\nEnter the id of the student you want his avarage grade: ");
            id = Console.ReadLine();
            double avg = AvarageGrades(students, id);
            if (avg != -1)
                Console.WriteLine($"the avarage: {avg}");
            else
                Console.WriteLine("the student doesn't exist.");

            //10
            Console.Write("Enter new student's name: ");
            name = Console.ReadLine();
            Console.Write("Enter new student's id: ");
            id = Console.ReadLine();
            Console.Write("Enter new student's gender: ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Enter new student's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {3} grades: ");
            grades = new double[3];
            for (int i = 0; i < 3; i++)
            {
                grades[i] = double.Parse(Console.ReadLine());
            }
            Student newStudent = new Student(name, id, gender, age, grades);
            students = AddStudentToSortedList(students, newStudent);
            OutputStudents(students);

            //11
            IsThereTwins(students);

            //12
            Node<string> smartStudents = SmartStudents(students);
            Console.WriteLine("\nthe names of the students who have avarage above 90: ");
            Node<string> pos = smartStudents;
            while (pos != null)
            {
                Console.Write(pos.GetInfo() +", ");
                pos = pos.GetNext();
            }

            //13
            Node<Student> girls = GetGirls(students);
            Console.WriteLine("girls: ");
            OutputStudents(girls);

            //14
            Console.Write("\nenter grade: ");
            double num = double.Parse(Console.ReadLine());
            Node<Item> items = ItemList(students, num);
            OutputItems(items, num);

            Console.ReadKey();
        }
    }
}


//זכויות יוצרים למגניבים המדליקים   