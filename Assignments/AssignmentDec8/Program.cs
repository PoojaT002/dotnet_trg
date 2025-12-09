using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDec8
{
    public class Program
    {
        static void Main(string[] args)
        {

            //task 1

            ConnectedArchitecture connectedArchitecture = new ConnectedArchitecture();
            //Console.Write("Enter start date (yyyy-mm-dd):");
            //string s1 = Console.ReadLine();

            //Console.Write("Enter end date (yyyy-mm-dd):");
            //string s2 = Console.ReadLine();

            //DateTime d1, d2;


            //bool a = DateTime.TryParse(s1, out d1);
            //bool b = DateTime.TryParse(s2, out d2);

            //if (a && b)
            //{
            //    connectedArchitecture.GetTransactions(d1, d2);
            //}
            //else
            //{
            //    Console.Write("Invalid date format");
            //}

            //task 2

            //connectedArchitecture.GetCommonRecords();

            //task 3

            connectedArchitecture.InsertRecordsusingtrans();

            //task 4

            //connectedArchitecture.InsertEmployeeFetchIdentity();

            //Task 5
            //connectedArchitecture.DisplayEmployeesDepartments();

            //Task 6
            connectedArchitecture.GetEmployeeDetailsUsing();


            Console.ReadLine();
        }
    }
}

