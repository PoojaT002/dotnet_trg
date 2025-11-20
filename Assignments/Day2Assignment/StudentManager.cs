using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Day2Assignment
{
    public class StudentManager
    {
        Dictionary<int, Student> students = new Dictionary<int, Student>()
        {
            [1] = new Student { Name = "Amit", Class = "9th", TotalMarks = 450, Gender = 'M' },
            [2] = new Student { Name = "Pooja", Class = "10th", TotalMarks = 280, Gender = 'F'  },
            [3] = new Student { Name = "Preeti", Class = "10th", TotalMarks = 520, Gender = 'F'  },
            [4] = new Student { Name = "Amruta", Class = "9th", TotalMarks = 200, Gender = 'F' }
        };

        public void ShowAllStudents()
        {
            foreach (var s in students)
                WriteLine($"ID: {s.Key} => {s.Value.ToString()}");
        }

        public async Task<Student> GetStudentAsync(int id=0)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (!students.ContainsKey(id))
                    {
                        return new Student
                        {
                            Name = "Default",
                            Class = "N/A",
                            TotalMarks = 0,
                            Gender = '-'
                        };
                    }
                    var st = students[id];
                    if (st.TotalMarks < 300)
                        throw new Exception("less than 500");
                    return st;
                });
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("less than 500"))
                {
                    await Task.Delay(10);
                    WriteLine("Error: " + ex.Message);
                }
                return null;
            }
        }
    }
}
