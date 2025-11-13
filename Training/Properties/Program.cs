using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        private int age; //variable
        private string name;
        private double salary = 45000;
        private string password = "admin123";
        public int Age //property(uppercase)
        {

            set
            {
                if (value < 0 || value > 120)
                    throw new Exception("Age should be between 0 to 120");
                age = value;//write only property
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        // read only property
        public double Salary
        {
            get { return salary; } 
        }
        public string Password
        {
            set { password = value; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Enter the Age:");
            student.Age = Convert.ToInt32(Console.ReadLine());
            student.Age = 30;
            student.Name = "Pooja";
            //student salary=9000;

            Console.WriteLine(" Student Informations ");
            Console.WriteLine(" Name: " + student.Name);
            //Console.WriteLine(" Age: " + student.Age);
            Console.WriteLine(" Stiphen: " + student.Salary);
            //Console.WriteLine(" Password: " + student.Password);
        }
    }
}
