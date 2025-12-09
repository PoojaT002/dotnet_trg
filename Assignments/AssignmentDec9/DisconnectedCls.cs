using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDec9
{
    public class DisconnectedCls
    {
        SqlConnection con;
        SqlDataAdapter daEmp, daDept;
        DataSet ds;
        DataTable dt;


        public DisconnectedCls()
        {
            con = new SqlConnection("uid=sa;pwd=Infinite@2025;database=infinitedb;server=ICS-LT-9Q8M9K3");
            ds = new DataSet();
        }


        //task 1 

        public void ShowEmployeeAndDepartment()
        {
            daEmp = new SqlDataAdapter("select * from employee", con);
            daDept = new SqlDataAdapter("select * from department", con);

            daEmp.Fill(ds, "emp");
            daDept.Fill(ds, "dept");

            Console.WriteLine("Employee Table:");
            foreach (DataRow row in ds.Tables["emp"].Rows)
            {
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4]);
            }

            Console.WriteLine("\nDepartment Table:");
            foreach (DataRow row in ds.Tables["dept"].Rows)
            {
                Console.WriteLine(row[0] + " " + row[1]);
            }
        }

        //taks 2

        public void EmployeeDataView()
        {
            daEmp = new SqlDataAdapter("select * from employee", con);
            dt = new DataTable();
            daEmp.Fill(dt);

            DataView dv = new DataView(dt);
            dv.RowFilter = "salary > 47000 and deptid = 10 AND empname like 'M%'";
            dv.Sort = "empname ASC";

            Console.WriteLine("Filtered Employees:");
            foreach (DataRowView row in dv)
            {
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);
            }
        }

        //task 3

        public void TotalTables()
        {
            Console.WriteLine("Total No Of Tables in DataSet = " + ds.Tables.Count);
        }


        //task 4

        public void ReaderToDataTable()
        {
            SqlCommand cmd = new SqlCommand("select * from department", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable dtDept = new DataTable();
            dtDept.Load(dr);

            con.Close();

            Console.WriteLine("Department from datatable:");
            foreach (DataRow row in dtDept.Rows)
            {
                Console.WriteLine(row[0] + " " + row[1]);
            }
        }

        //task 5 

        public void MergeCustomerOrders()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select*from customers", con);
            SqlDataAdapter da2 = new SqlDataAdapter("select*from orders", con);

            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();

            da1.Fill(ds1, "customers");
            da2.Fill(ds2, "orders");

            ds1.Merge(ds2);

            Console.WriteLine("Merged Dataset:\n");
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (var item in row.ItemArray)
                        Console.Write(item + " ");

                    Console.WriteLine();
                }
            }
        }

        //task 6

        public void ReadXmlData()
        {
            DataSet ds = new DataSet();

            ds.ReadXml("C:\\Users\\poojati\\dotnet_trg\\Assignments\\Customer.xml");

            Console.WriteLine("xml data output\n");

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine(
                        row["CUSTID"] + " " +
                        row["CUSTNAME"] + " " +
                        row["CUSTADDRESS"] + " " +
                        row["PHONE"]
                    );
                }
            }

        }
    }
}
