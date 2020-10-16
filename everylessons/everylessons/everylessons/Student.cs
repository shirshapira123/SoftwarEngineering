using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Student
    {
        string name, gender;
        int age;
        Parent parent;

        public Student(string name, string gender, int age, Parent parent)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.parent = parent;
        }
        public string GetName() => name;
        public string GetGender() => gender;
        public int GetAge() => age;
        public Parent GetParent() => parent;
        public void SetAge(int age)
        {
            this.age = age;
        }
        public override string ToString()
        {
            return $"name: {name} \ngender: {gender} \nage: {age}\n{parent}\n--------------------\n";
        }
    }
}
