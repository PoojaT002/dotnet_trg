using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Nov21
{
     class Program
    {
        static void Main(string[] args)
        {
            Logger log1=Logger.Instance;
            Logger log2=Logger.Instance;

            log1.WriteLog("Application started.");
            log2.WriteLog("User logged in.");

            Console.WriteLine(log1 == log2);
        }
    }
}
