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
            //conectionsClass.EmpTransaction();

            DisconnectedCls disconnectedCls = new DisconnectedCls();
            disconnectedCls.ShowAllEmployee();

            //disconnectedCls.SearchEmployee();
            //disconnectedCls.AddEmployee();
            //disconnectedCls.DeleteEmployee();
            //disconnectedCls.UpdateEmployee();
            //disconnectedCls.FilterEmployee();
            disconnectedCls.StoreinXML();
            Console.ReadLine();
        }
    }
}
