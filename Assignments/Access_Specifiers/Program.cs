using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifiers
{
       class Person
       {
        string name;
        int age;
        string loaction;

        public Person(string name,int age,string location)
        {
            this.name = name;
            this.age = age;
            this.loaction = location;
            Console.WriteLine("Person or parent class constructor");
        }

        public void getPersonDetails()
        {
            Console.Write("Enter person name: ");
            name = Console.ReadLine();
            Console.Write("Enter tha age of the person: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the location: ");
            loaction = Console.ReadLine();
         }
        public void DisplayPersonDetails()
        {
            Console.WriteLine("\nPerson Information \n-------------------");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Location : " + loaction);
        }

       }
        class Employee:Person
        {
            int employeeId;
            //string employeeName;
            double employeeSalary;
            string designation;

        public Employee(string name, int age, string location, int id, string designation, double salary):base(name,age,location)
        {
            this.employeeId = id;
            this.employeeSalary = salary;
            this.designation = designation;
            Console.WriteLine("Employee or child class constructor");
        }

            public void getEmployeeDetails()
            {
                Console.Write("\nEmployee ID: ");
                employeeId = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Employee Name: ");
                //employeeName =(Console.ReadLine());
                Console.Write("Employee Salary: ");
                employeeSalary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Employee Designation: ");
                designation = (Console.ReadLine());

                //DisplayEmployeeDetails();
            }

             public void DisplayEmployeeDetails()
            {
                Console.WriteLine("\nEmployee Details are \n---------------------- ");
                Console.WriteLine($"Id: {employeeId} \nDesignation: {designation} \nSalary: {employeeSalary}");
            }
        }
          internal class Program
          {
            static void Main(string[] args)
            {
            Employee emp = new Employee("Pooja",23, "Bangalore,202,12000,"Sr.Consultant");          
                //emp.getPersonDetails();
            //emp.getEmployeeDetails();


            //emp.DisplayPersonDetails(); // child class object cannot access parent class protected members directly .
            emp.DisplayEmployeeDetails();

            //Employee emp2 = new Employee();
            Console.ReadLine();
            }
    }
}
