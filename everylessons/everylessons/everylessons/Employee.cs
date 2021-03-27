using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Employee
    {
        string id, name;
        char gender;
        double years_of_work;
        public Employee(string id, string name, char gender, double years_of_work)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.years_of_work = years_of_work;
        }
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public char Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public double Years_of_work
        {
            get { return this.years_of_work; }
            set { this.years_of_work = value; }
        }
        public double CalculateSalary()
        {
            return (120000 + 12000 * years_of_work);
        }
        public override string ToString()
        {
            return $"-----------------\nid: {id}, name: {name}, gender: {gender}, years of work: {years_of_work}\n";
        }
    }
}
