using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTestDec12
{
    public class Program
    {
        static void Main(string[] args)
        {

            //connected

            ArchConnected arch = new ArchConnected();
            //task 1
            //arch.DisplayCourse();

            //task 2
            //arch.AddStudent();

            //task 3
            //arch.SearchStudentbyDept();

            //task 4
            //arch.DisplayCourseStudent();

            //task 5
            //arch.UpdateGrades();



            //Disconnected

            DisconnectedClass disconnected = new DisconnectedClass();

            //task 1
            //disconnected.LoadStudAndCourse();

            //task 2
            //disconnected.ModifyCourse();

            //task 3
            //disconnected.InsertNewCourse();

            //task 4
            //disconnected.DeleteStudent();

            //stored procedure
            disconnected.StoredProcedure();

            Console.ReadLine();

        }
    }
}
