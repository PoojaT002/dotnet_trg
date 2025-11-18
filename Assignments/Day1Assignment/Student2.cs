using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace Day1Assignment
{

    public partial class Student
    {
        public void DisplayDetails()
        {
            WriteLine("Name: " + Name);
            WriteLine("Age: " + Age);
        }
    }
}
