using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Student
    {
        string name, id;
        char gender;
        int age;
        double[] grades;
        public Student(string name, string id, char gender, int age, double[] grades)
        {
            this.name = name;
            this.id = id;
            this.gender = gender;
            this.age = age;
            this.grades = grades;
        }
        public string GetName() => name;
        public string GetId() => id;
        public char GetGender() => gender;
        public int GetAge() => age;
        public double[] GetGrades() => grades;
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetId(string id)
        {
            this.id = id;
        }
        public void SetGender(char gender)
        {
            this.gender= gender;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void SetGrade(double[] grades)
        {
            this.grades = grades;
        }
        public override string ToString()
        {
            string tostring = $"\nid: {id}\nname: {name}\ngender: {gender}\nage: {age}\ngrade: ";
            for (int i = 0; i < grades.Length; i++)
            {
                tostring += grades[i].ToString() + ", ";
            }
            return tostring += "\n------------------";
        }
        
    }
}
