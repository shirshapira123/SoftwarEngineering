using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Company
    {
        string companyName;
        int numOfDepartments;
        Node<Employee>[] workers;
        public Company(string companyName, int numOfDepartments)
        {
            this.companyName = companyName;
            this.numOfDepartments = numOfDepartments;
            this.workers = new Node<Employee>[numOfDepartments];
            for (int i = 0; i < numOfDepartments; i++)
            {
                this.workers[i] = null;
            }
        }
        public Node<Employee>[] Workers
        {
            get { return this.workers; }
            set { this.workers = value; }
        }
        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public int NumOfDepartments
        {
            get { return this.numOfDepartments; }
        }
        public void AddEmployee(Employee employee, int numOfDepartment)
        {
            
            if (workers[numOfDepartment - 1] == null)
            {
                workers[numOfDepartment - 1] = new Node<Employee>(employee);
            }
            else
            {
                Node<Employee> pos = workers[numOfDepartment - 1];
                while(pos.GetNext() != null)
                {
                    pos = pos.GetNext();
                }
                pos.SetNext(new Node<Employee>(employee));
            }
            Console.WriteLine("the worker has been added to list");
        }
        public void DeleteEmployee(string idEmployee)
        {
            bool succeed = false;
            Node<Employee> pos;
            for (int i = 0; i < numOfDepartments; i++)
            {
                pos = workers[i];
                if (workers[i] == null)
                    break;
                else if (pos.GetInfo().Id == idEmployee)
                {
                    workers[i] = workers[i].GetNext();
                    succeed = true;
                }
                else
                {
                    while (pos.GetNext() != null)
                    {
                        if (pos.GetNext().GetInfo().Id == idEmployee)
                        {
                            pos.SetNext(pos.GetNext().GetNext());
                            succeed = true;
                            break;
                        }
                        pos = pos.GetNext();
                    }
                }
            }
            if (succeed)
                Console.WriteLine("the worker has been removed from the company");
            else
                Console.WriteLine("the worker doesn't exist");
        }
        public void MoveEmployee(string idEmployee, int numFromDepartment, int numToDepartment)
        {
            Node<Employee> pos = workers[numFromDepartment - 1];
            Employee employee = null;
            while (pos != null)
            {
                if (pos.GetInfo().Id == idEmployee)
                {
                    employee = pos.GetInfo();
                }
                pos = pos.GetNext();
            }
            DeleteEmployee(idEmployee);
            if (employee != null)
            {
                AddEmployee(employee, numToDepartment);
                Console.WriteLine("the move was successful");
            }
            else
                Console.WriteLine("the employee doesn't exist");
        }
        public override string ToString()
        {
            string tostr = $"Company name: {companyName}\n";
            for (int i = 0; i < workers.Length; i++)
            {
                tostr += $"department {i+1}: \n";
                Node<Employee> pos = workers[i];
                while (pos != null)
                {
                    tostr += pos.GetInfo().ToString() + "\n";
                    pos = pos.GetNext();
                }
            }
            return tostr;
        }
    }
}
