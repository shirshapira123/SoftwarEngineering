using System;

namespace everylessons
{
    class Program
    {
        public static void AvgAge(Company company)
        {
            double sum_company = 0;
            double counter_company = 0;
            string avg = "";
            for (int i = 0; i < company.Workers.Length; i++)
            {
                double sum_department = 0;
                double counter_department = 0;
                Node<Employee> pos = company.Workers[i];
                while (pos != null)
                {
                    sum_department += pos.GetInfo().Years_of_work;
                    counter_department++;
                    sum_company += pos.GetInfo().Years_of_work; ;
                    counter_company++;
                    pos = pos.GetNext();
                }
                avg += $"department {i+1} work age avarage: {sum_department / counter_department}\n";
            }
            avg += $"company work age avarage: {sum_company / counter_company}";
            Console.WriteLine(avg);
        }
        public static void GirlsAndBoys(Company company)
        {
            string avg = "";
            for (int i = 0; i < company.Workers.Length; i++)
            {
                double boys = 0;
                double girls = 0;
                Node<Employee> pos = company.Workers[i];
                while (pos != null)
                {
                    if (pos.GetInfo().Gender == 'M')
                        boys++;
                    else
                        girls++;
                    pos = pos.GetNext();
                }
                avg += $"department {i+1} girls: {girls} boys: {boys}\n";
            }
            Console.Write(avg);
        }
        public static Company AddOneYear(Company company)
        {
            for (int i = 0; i < company.Workers.Length; i++)
            {
                Node<Employee> pos = company.Workers[i];
                while (pos != null)
                {
                    pos.GetInfo().Years_of_work++;
                    pos = pos.GetNext();
                }
            }
            return company;
        }
        public static double[] AvgSalary(Company company)
        {
            double[] avgSalary = new double[company.NumOfDepartments];
            for (int i = 0; i < company.NumOfDepartments; i++)
            {
                double salarySum = 0;
                double counter = 0;
                Node<Employee> pos = company.Workers[i];
                while (pos != null)
                {
                    salarySum += pos.GetInfo().CalculateSalary();
                    counter++;
                    pos = pos.GetNext();
                }
                avgSalary[i] = salarySum / counter;
            }
            return avgSalary;
        }
        public static Node<string> Oldest(Company company)
        {
            Node<string> oldest = null;
            for (int i = 0; i < company.NumOfDepartments; i++)
            {
                Node<Employee> pos = company.Workers[i];
                while (pos != null)
                {
                    if (pos.GetInfo().Years_of_work > 15)
                    {
                        if (oldest == null)
                            oldest = new Node<string>(pos.GetInfo().Id);
                        else
                        {
                            Node<string> pos_ = oldest;
                            while (pos_.GetNext() != null)
                            {
                                pos_ = pos_.GetNext(); 
                            }
                            pos_.SetNext(new Node<string>(pos.GetInfo().Id));
                        }
                    }
                    pos = pos.GetNext();
                }
            }
            return oldest;
        }
        public static Employee[] Committee(Company company)
        {
            Employee[] committee = new Employee[company.NumOfDepartments];
            for (int i = 0; i < company.NumOfDepartments; i++)
            {
                Node<Employee> pos = company.Workers[i];
                Employee oldest_of_department = null;
                double max = 0;
                while (pos != null)
                {
                    max = Math.Max(pos.GetInfo().Years_of_work, max);
                    if (max == pos.GetInfo().Years_of_work)
                        oldest_of_department = pos.GetInfo();
                    pos = pos.GetNext();
                }
                committee[i] = oldest_of_department;
            }
            return committee;
        }

        static void Main(string[] args)
        {
            string id;
            Company company = new Company("Oleg And Sons", 3);
            for (int i = 1; i <= 9; i++)
            {
                Console.Write("id: ");
                id = Console.ReadLine();
                Console.Write("name: ");
                string name = Console.ReadLine();
                Console.Write("gender: ");
                char gender = char.Parse(Console.ReadLine());
                Console.Write("years of work: ");
                double years_of_work = int.Parse(Console.ReadLine());
                Employee employee = new Employee(id, name, gender, years_of_work);
                if (i <= 4)
                    company.AddEmployee(employee, 1);
                else if (i >= 5 && i <= 7)
                    company.AddEmployee(employee, 2);
                else
                    company.AddEmployee(employee, 3);
            }
            Console.WriteLine(company);
            Console.Write("enter ID of worker in the third department: ");
            id = Console.ReadLine();
            company.DeleteEmployee(id);
            Console.WriteLine(company);
            Console.Write("enter ID of worker in the second department who doesn't exist: ");
            id = Console.ReadLine();
            company.DeleteEmployee(id);
            Console.Write("enter ID of worker in the first department: ");
            id = Console.ReadLine();
            company.MoveEmployee(id, 1, 2);
            Console.WriteLine(company);
            AvgAge(company);
            GirlsAndBoys(company);
            company = AddOneYear(company);
            Console.WriteLine(company);
            double[] avgSalary = AvgSalary(company);
            for (int i = 0; i < avgSalary.Length; i++)
            {
                Console.WriteLine($"deparment {i+1} avarage salary: {avgSalary[i]}");
            }
            Node<string> oldest = Oldest(company);
            ViewList(oldest);
            Employee[] committee = Committee(company);
            for (int i = 0; i < committee.Length; i++)
            {
                Console.WriteLine(committee[i]);
            }
            Console.ReadKey();
        }
        public static void ViewList(Node<string> list)
        {
            Node<string> pos = list;
            while (pos != null)
            {
                Console.Write($"{pos.GetInfo()}, ");
                pos = pos.GetNext();
            }
            Console.WriteLine();
        }
    }
}


//זכויות יוצרים למגניבים המדליקים