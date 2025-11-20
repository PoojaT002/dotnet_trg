using Day2Assignment;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using static System.Console;

namespace Day2Assignment1

{

    internal class Program

    {

        static async Task Main(string[] args)

        {

            StudentManager studentmanager = new StudentManager();

            WriteLine("All Students: ");

            studentmanager.ShowAllStudents();

            WriteLine("\nGet Student by ID 2:");

            var s = await studentmanager.GetStudentAsync(2);

            WriteLine(s);

            WriteLine("\nGet Student by ID 0:");

            var defaultStud = await studentmanager.GetStudentAsync();

            WriteLine(defaultStud);

            ReadLine();

        }

    }

}

