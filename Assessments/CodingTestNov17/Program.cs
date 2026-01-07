using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestNov17
{
    public class Employee
    {
        public int EmpId;
        public string Name;
        public string Department;
        public double Salary;
        public int Experience;

    }

    public delegate bool EmpFilter(Employee e);
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
        {
            new Employee() { EmpId = 101, Name = "Amit", Department = "IT", Salary = 50000, Experience = 3 },
            new Employee() { EmpId = 102, Name = "Pooja", Department = "Consultant", Salary = 33000, Experience = 2 },
            new Employee() { EmpId = 103, Name = "John", Department = "Transport", Salary = 55000, Experience = 5 },
            new Employee() { EmpId = 104, Name = "Tina", Department = "Health", Salary = 60000, Experience = 4 },
            new Employee() { EmpId = 105, Name = "Smith", Department = "Finance", Salary = 40000, Experience = 3 },
            new Employee() { EmpId = 106, Name = "Priya", Department = "Sales", Salary = 45000, Experience = 6 },
            new Employee() { EmpId = 107, Name = "Sonal", Department = "HR", Salary = 30000, Experience = 1 },
            new Employee() { EmpId = 108, Name = "Arun", Department = "IT", Salary = 70000, Experience = 8 },
            new Employee() { EmpId = 109, Name = "Nivedita", Department = "Security", Salary = 30000, Experience = 2 },
            new Employee() { EmpId = 110, Name = "Arnav", Department = "IT", Salary = 65000, Experience = 7 },
        };

            Console.WriteLine("==========All Employees========");
            foreach (var e in list)
                Console.WriteLine(e.EmpId + " " + e.Name + " " + e.Department + " " + e.Salary + " " + e.Experience);

            EmpFilter filter = (emp) => emp.Salary > 50000;

            Console.WriteLine("\n=======Filtered Results======");

            Console.WriteLine("\nSalary > 50000:");
            foreach (var e in list.Where(x =>  filter(x)))
                Console.WriteLine(e.Name);

            Console.WriteLine("\nIT Department:");
            foreach (var e in list.Where(x => x.Department == "IT"))
                Console.WriteLine(e.Name);

            Console.WriteLine("\nExperience > 5:");
            foreach (var e in list.Where(x => x.Experience > 5))
                Console.WriteLine(e.Name);

            Console.WriteLine("\nName starts with 'A':");
            foreach (var e in list.Where(x => x.Name.StartsWith("A")))
                Console.WriteLine(e.Name);

            Console.WriteLine("\n==========Sorted Results=======");

            Console.WriteLine("\nSort by Name (A-Z):");
            foreach (var e in list.OrderBy(x => x.Name))
                Console.WriteLine(e.Name);

            Console.WriteLine("\nSort by Salary (High -> Low):");
            foreach (var e in list.OrderByDescending(x => x.Salary))
                Console.WriteLine(e.Name + " - " + e.Salary);

            Console.WriteLine("\nSort by Experience (Low -> High):");
            foreach (var e in list.OrderBy(x => x.Experience))
                Console.WriteLine(e.Name + " - " + e.Experience);

            Console.WriteLine("\n=====Promotion List (Experience > 5) =====");
            foreach (var e in list.Where(x => x.Experience > 5))
                Console.WriteLine(e.Name + " - " + e.Experience + " years");
        }
    }
}
