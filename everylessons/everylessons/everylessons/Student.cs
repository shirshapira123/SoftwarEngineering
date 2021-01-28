using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Student
    {
        string name, id;
        private Node<int> gradesList;
        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
            gradesList = null;
        }
        public string GetName() => name;
        public string GetId() => id;
        public Node<int> GetGradesList() => gradesList;
        public void AddGrade(int grade)
        {
            Node<int> pos = gradesList;
            if (pos == null)
            {
                gradesList = new Node<int>(grade);
            }
            else
            {
                while (pos.GetNext() != null)
                {
                    pos = pos.GetNext();
                }
                pos.SetNext(new Node<int>(grade));
            }
        }
        public double CalculateAvg()
        {
            double sum = 0;
            double counter = 0;
            Node<int> pos = gradesList;
            while (pos != null)
            {
                sum += pos.GetInfo();
                counter++;
                pos = pos.GetNext();
            }
            double avg = sum / counter;
            return avg;
        }
        public void UpdateGrade(int subject, int newGrade)
        {
            if (GetLength(gradesList) < subject)
            {
                Console.WriteLine("subject goes beyond the list");
            }
            else
            {
                Node<int> pos = gradesList;
                for (int i = 0; i < subject-1; i++)
                {
                    pos = pos.GetNext();
                }
                pos.SetInfo(newGrade);
            }
        }
        public void DeleteGrade(int subject)
        {
            if(GetLength(gradesList) < subject)
            {
                Console.WriteLine("subject goes beyond the list");
            }
            else
            {
                Node<int> pos = gradesList;
                for (int i = 0; i < subject-2; i++)
                {
                    pos = pos.GetNext();
                }
                pos.SetNext(pos.GetNext().GetNext());
            }
            
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
        public override string ToString()
        {
            string tostring = $"\nid: {id}\nname: {name}\nthe grades: ";
            Node<int> pos = gradesList;
            while (pos != null)
            {
                tostring += pos.GetInfo() + ", ";
                pos = pos.GetNext();
            }
            return tostring;
        }
    }
}
