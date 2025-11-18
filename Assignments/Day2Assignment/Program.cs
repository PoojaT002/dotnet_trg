using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            StudentManager sm=new StudentManager();

            await sm.ShowAllStudents();

            var s = await sm.GetStudentAsync(2);
        }
    }
}
