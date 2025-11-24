using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Nov21
{
    public class Logger
    {
        private static Logger _instance = null;
        private Logger()
        {

        }
        public static Logger Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new Logger();

                return _instance;
            }
            
        }
        public  void WriteLog(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }
}
