using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            Professor professor1 = new Professor() { Name = "Pooja", Course = "Maths" };
            professor.Name = "Pooja";
            professor.Course = "AWS";
            professor.ShowName();
            professor.ShowCourse();
            professor.ConductResearch();
            Console.ReadLine();
        }
    }
}
