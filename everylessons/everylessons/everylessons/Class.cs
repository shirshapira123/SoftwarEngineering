using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Class
    {
        string name;
        int maxAmountStudents;
        int currentAmountStudents;
        Student[] students;

        public Class(string name, int maxAmountStudents)
        {
            this.name = name;
            this.maxAmountStudents = maxAmountStudents;
            currentAmountStudents = 0;
            students = new Student[maxAmountStudents];
        }
        public int GetMaxAmountStudent() => maxAmountStudents;
        public int GetCurrentAmountStudent() => currentAmountStudents;
        public string GetName() => name;
        public Student[] GetStudents() => students;
        public bool AddStudent(Student s)
        {
            if (currentAmountStudents == maxAmountStudents)
                return false;
            students[currentAmountStudents] = s;
            currentAmountStudents++;
            return true;
        }
        public Student DeleteStudent(string name)
        {
            Student s;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].GetName().Equals(name))
                {
                    s = students[i];
                    students[i] = students[currentAmountStudents - 1];
                    students[currentAmountStudents - 1] = null;
                    currentAmountStudents--;
                    return s;
                }
            }
            return null;
        }
        public Student SearchStudent(string name)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].GetName().Equals(name))
                    return students[i];
            }
            return null;
        }
        public override string ToString()
        {
            string names = "";
            for (int i = 0; i < students.Length; i++)
                names += students[i];
            return $"class name: {name}\nstudents names:\n{names}";
        }
    }
}
