using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day3Assignment1;
using static System.Console;

namespace RemotingLib
{
    public class ServiceClass : MarshalByRefObject, IMyinter
    {
        Dictionary<int, Student> students = new Dictionary<int, Student>()
        {
            [1] = new Student { Name = "Amit", Class = "9th", TotalMarks = 450, Gender = 'M' },
            [2] = new Student { Name = "Pooja", Class = "10th", TotalMarks = 280, Gender = 'F' },
            [3] = new Student { Name = "Preeti", Class = "10th", TotalMarks = 520, Gender = 'F' },
            [4] = new Student { Name = "Amruta", Class = "9th", TotalMarks = 200, Gender = 'F' }
        };

       

        public string ShowAllStudents()
        {
            string result = "";
            foreach (var s in students)
                result += $"ID: {s.Key} => {s.Value.ToString()}\n";

            return result;
        }

        public Student GetStudent(int id = 0)
        {
            try
            {
                if (id == 0)
                {
                    return new Student
                    {
                        Name = "Mahe",
                        Class = "Inter",
                        TotalMarks = 540,
                        Gender = 'F'
                    };
                }
                if (!students.ContainsKey(id))
                {
                    throw new Exception("Student not found");
                }
                Student stu = students[id];
                if (stu.TotalMarks < 300)
                {
                    throw new Exception("Mark less than 300");
                }
                return stu;
            }
            catch (Exception ex)
            {
                WriteLine($"General Error: {ex.Message}");
                return new Student();
            }
        }


    }
}

