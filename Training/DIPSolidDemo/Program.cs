using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolidDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDatabase db = new SqlDatabase();
            OrderProcessor op =new OrderProcessor(db);

            op.Process();
        }
    }
}
