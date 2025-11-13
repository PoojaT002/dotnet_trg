using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsDemo
{
    public class InfiniteEmployee:IComparable<InfiniteEmployee>
    {
        public int Empid { get; set;}
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }

        public int CompareTo(InfiniteEmployee other)
        {
            return this.Empid.CompareTo(other.Empid);
        }

    }
    
    internal class IComparableDemo
    {
        static void Main(string[] args)
        {
            List<InfiniteEmployee> infiniteEmployees = new List<InfiniteEmployee>();
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 2, Name = "Sakthivel", Salary = 9000, Age = 21, Location = "Hydrebad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 3, Name = "Madavi", Salary = 800000, Age = 23, Location = "Bangalore" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807012, Name = "Deepti Sahu", Salary = 21000, Age = 23, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807018, Name = "Kanishka Chandran", Salary = 37500, Age = 20, Location = "Hyderabad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807023, Name = "Deepalakshmi", Salary = 60000, Age = 21, Location = "Hyderabad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807031, Name = "Aasritha", Salary = 80000, Age = 21, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 6, Name = "Sairam", Salary = 18000, Age = 23, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807001, Name = "Humera", Salary = 21000, Age = 24, Location = "Bangalore" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807013, Name = "Akshay", Salary = 29000, Age = 23, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807004, Name = "keerthi", Salary = 21000, Age = 22, Location = "Hyderabad" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807000, Name = "R Syeda Mehraj Fatima", Salary = 21000, Age = 23, Location = "Banglore" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807014, Name = "Mani", Salary = 20000, Age = 26, Location = "Chennai" });
            infiniteEmployees.Add(new InfiniteEmployee { Empid = 1807002, Name = "Pooja", Salary = 21000, Age = 23, Location = "Bangalore" });

            Console.WriteLine("Employee Details are: ");
            foreach(var emp in infiniteEmployees)
            {
                Console.WriteLine($" EmpId: {emp.Empid}, Name: {emp.Name}, Salary: {emp.Salary}, Age: {emp.Age}, Location: {emp.Location}");
            }

            infiniteEmployees.Sort();
            Console.WriteLine("\n Employee Details after sorting by Salary:");
            foreach( var emp in infiniteEmployees)
            {
                Console.WriteLine($" EmpId: {emp.Empid}, Name: {emp.Name}, Salary: {emp.Salary}, Age: {emp.Age}, Location: {emp.Location}");
            }
        }

    }
}
