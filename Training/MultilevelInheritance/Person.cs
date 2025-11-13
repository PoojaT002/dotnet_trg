using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class Person
    {
        public Person()
        {
            Console.Write("Person Constructor called");
        }
        public string Name;
        public void ShowName() => Console.WriteLine($"Name : {Name}");
    }

    class Teacher : Person
    {
        public Teacher()
        {
            Console.WriteLine("\nTeacher constructor");
        }
        public string Course;
        public void ShowCourse() => Console.WriteLine($"{Name} teaches { Course }");
    }

    class Professor : Teacher
    {
        public Professor()
        {
            Console.WriteLine("\nProfessor constructor");
        }
        public void ConductResearch() => Console.WriteLine($"{Name} is conducting R&D in { Course }");
    }
}