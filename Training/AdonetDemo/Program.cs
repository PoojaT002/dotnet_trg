using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonetDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectionsClass conectionsClass = new ConnectionsClass();
            //conectionsClass.Showprocedure();
            //conectionsClass.AddEmployee();
            //conectionsClass.DeleteEmployee();
            //conectionsClass.UpdateEmployee();
            conectionsClass.EmpTransaction();
            Console.ReadLine();
        }
    }
}
