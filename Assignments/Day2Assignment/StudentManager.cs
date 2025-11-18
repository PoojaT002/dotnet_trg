using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    public class StudentManager
    {
        Dictionary<int, Student> students = new Dictionary<int, Student>()
        {
            [1] = new Student { Name = "Amit", Class = "9th", TotalMarks = 400, Gender = 'M' },
            [2] = new Student { Name = "Pooja", Class = "10th", TotalMarks = 450, Gender = 'F' },
            [3] = new Student { Name = "Preeti", Class = "10th", TotalMarks = 480, Gender = 'F' },
            [4] = new Student { Name = "Amruta", Class = "9th", TotalMarks = 380, Gender = 'F' }
        };

        void WriteLine(string msg) =>Console.WriteLine(msg);

        public async Task ShowAllStudents()
        {
            try
            {
                foreach (var s in students)
                    WriteLine(s.Value.ToString());
            }
            catch(Exception ex)
            {
                await Task.Delay(1000);
                WriteLine("Error: " + ex.Message);
            }
        }
        public async Task<Student> GetStudentAsync(int id=0)
        {
            try
            {
                if (id == 0)
                    return new Student { Name = "Default", Class = "NA", TotalMarks = 0, Gender = '-' };

                if (!students.TryGetValue(id, out var student st))
                    return null;

                if (st.TotalMarks < 300)
                    throw new Exception("Marks are less than 500");

                return st;
            }
            catch(Exception ex) when (ex.Message.Contains("less than 500"))
            {
                await Task.Delay(1000);
                WriteLine("Marks are too low");
                return null;
            }
            catch (Exception ex) 
            {
                await Task.Delay(1000);
                WriteLine("Error: " + ex.Message);
                return null;
            }

        }
    }
}
