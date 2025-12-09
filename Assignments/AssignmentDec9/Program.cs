using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDec9
{
    public class Program
    {
        static void Main(string[] args)
        {
            DisconnectedCls disconnected=new DisconnectedCls();
            //task 1
            //disconnected.ShowEmployeeAndDepartment();

            //task 2
            //disconnected.EmployeeDataView();

            //task 3
            //disconnected.TotalTables();

            //task 4
            //disconnected.ReaderToDataTable();

            //task 5
            //disconnected.MergeCustomerOrders();

            //task 6
            disconnected.ReadXmlData();

            Console.ReadLine();

        }
    }
}
