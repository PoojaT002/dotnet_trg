
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public decimal Salary { get; set; }

    }


    internal class ArrayListWithComplexType
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //Console.WriteLine("Enter the Employee Id, Name and Dept");
            //employee.EmpId=Convert.ToInt32(Console.ReadLine());
            //employee.Name=Console.ReadLine();
            //employee.Dept=Console.ReadLine();

            ArrayList employeeList = new ArrayList();
            employeeList.Add(new Employee { EmpId = 1, Name = "Peter", Dept = "IT" });

            employeeList.Add(new Employee { EmpId = 1, Name = "Peter", Dept = "IT", Salary = 76898.0m });
            employeeList.Add(new Employee { EmpId = 2, Name = "Pooja", Dept = "HR", Salary = 76567.0m });
            employeeList.Add(new Employee { EmpId = 3, Name = "Poo", Dept = "Sales", Salary = 56567.0m });

            while (true)
            {
                Console.WriteLine("\n Employee Portal");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. Display all Employee");
                Console.WriteLine("3. Search by Id");
                Console.WriteLine("4. Remove Employee");
                Console.WriteLine("5. Sort Employee by salary ");
                Console.WriteLine("6. Reverse Employee List");
                Console.WriteLine("7. Exit");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Employee Id,Name and Dept");
                        employee.EmpId = Convert.ToInt32(Console.ReadLine());
                        employee.Name = Console.ReadLine();
                        employee.Dept = Console.ReadLine();
                        employeeList.Add(employee);
                        break;


                    case 2:
                        Console.WriteLine("Display all Employee");
                        foreach (Employee emp in employeeList)
                        {
                            Console.WriteLine($"Id: {emp.EmpId}, Name: {emp.Name}, Dept: {emp.Dept}, Salary: {emp.Salary}");
                        }
                        break;


                    case 3:
                        Console.WriteLine("Search by Id");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        Employee foundEmp = null;
                        foreach (Employee emp in employeeList)
                        {
                            if (emp.EmpId == searchId)
                            {
                                foundEmp = emp;
                                break;
                            }
                        }
                        if (foundEmp != null)
                        {
                            Console.WriteLine($"Found Employee: Id: {foundEmp.EmpId}, Name: {foundEmp.Name}, Dept: {foundEmp.Dept}, Salary: {foundEmp.Salary}");
                        }
                        else
                        {
                            Console.WriteLine("Employee Id not found");
                        }
                        break;


                    case 4:
                        Console.WriteLine("Remove Employee");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        Employee empToRemove = null;
                        foreach (Employee emp in employeeList)
                        {
                            if (emp.EmpId == removeId)
                            {
                                empToRemove = emp; break;
                            }
                        }
                        if (empToRemove != null)
                        {
                            employeeList.Remove(empToRemove);
                            Console.WriteLine("Employee removed successfully");
                        }
                        break;



                    case 5:
                        employeeList.Sort(new SalaryComparer());
                        Console.WriteLine("Employee sorted by Salary");
                        foreach (Employee emp in employeeList)
                        {
                            Console.WriteLine($"Id: {emp.EmpId}, Name: {emp.Name}, Dept: {emp.Dept}, Salary: {emp.Salary}");
                        }
                        break;


                    case 6:
                        employeeList.Reverse();
                        Console.WriteLine("Employee in reverse order:");
                        foreach (Employee emp in employeeList)
                        {
                            Console.WriteLine($"Id: {emp.EmpId}, Name: {emp.Name}, Dept: {emp.Dept}, Salary: {emp.Salary}");

                        }
                        break;


                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
                Console.ReadLine();
            }

        }

        public class SalaryComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                return ((Employee)x).Salary.CompareTo(((Employee)y).Salary);
            }
        }
    }
}
