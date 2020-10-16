using System;

namespace everylessons
{
    class Program
    {
        public static void ShowParents(Class group)
        {
            for (int i = 0; i < group.GetMaxAmountStudent(); i++)
            {
                Console.WriteLine(group.GetStudents()[i].GetParent());
            }
        }
        public static bool UpdateParentPhone(Class group, string name, string phone)
        {
            for (int i = 0; i < group.GetMaxAmountStudent(); i++)
            {
                if (name.Equals(group.GetStudents()[i].GetName()))
                {
                    group.GetStudents()[i].GetParent().SetPhone(phone);
                    return true;
                }
            }
            return false;
        }
        public static bool AreThereTwins(Class group)
        {
            for (int i = 0; i < group.GetMaxAmountStudent(); i++)
            {
                for (int k = 0; k < group.GetMaxAmountStudent(); k++)
                {
                    if (group.GetStudents()[i].GetParent().Equals(group.GetStudents()[k].GetParent()))
                        return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Class c1 = new Class("iud alef4", 4);
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Parent name: ");
                string p_name = Console.ReadLine();
                Console.Write("Parent phone number: ");
                string phone = Console.ReadLine();
                Parent parent = new Parent(p_name, phone);
                Console.Write("Student name: ");
                string s_name = Console.ReadLine();
                Console.Write("Student gender: ");
                string gender = Console.ReadLine();
                Console.Write("Student age: ");
                int age = int.Parse(Console.ReadLine());
                Student student = new Student(s_name, gender, age, parent);
                bool add = c1.AddStudent(student);
                if (add)
                    Console.WriteLine("Successfuly add!\n-------------------------");
                else
                    Console.WriteLine("The list is full\n-------------------------");
            }
            Console.WriteLine(c1);
            for (int i = 0; i < 2; i++)
            {
                Console.Write("search student by name: ");
                string search_name = Console.ReadLine();
                Student search_student = c1.SearchStudent(search_name);
                if (search_student == null)
                    Console.WriteLine("the student you are looking for isn't exist");
                else
                    Console.WriteLine($"the student you are looking for is: {search_student}");
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write("delete student by name: ");
                string delete_name = Console.ReadLine();
                Student delete_student = c1.SearchStudent(delete_name);
                if (delete_student == null)
                    Console.WriteLine("the student you are looking for isn't exist");
                else
                    Console.WriteLine($"the student you just deleted is: {delete_student}");
                Console.WriteLine(c1);
            }
            ShowParents(c1);
            Console.Write("enter the name of the student(to update his parent's phone number): ");
            string name = Console.ReadLine();
            Console.Write("enter the updated phone number: ");
            string updated_phone = Console.ReadLine();
            bool update_success = UpdateParentPhone(c1, name, updated_phone);
            if (update_success)
                Console.WriteLine("The update was successful");
            else
                Console.WriteLine("can't update. the name is not exist");
            bool are_they_twins = AreThereTwins(c1);
            if (are_they_twins)
                Console.WriteLine("There are twins in the class");
            else
                Console.WriteLine("You don't have twins in the class");
            Console.ReadKey();
        }
    }
}

//זכויות יוצרים למגניבים המדליקים   