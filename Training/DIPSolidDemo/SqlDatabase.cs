using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolidDemo
{
    public class SqlDatabase : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("Saving to SQL ");
        }
    }
}
