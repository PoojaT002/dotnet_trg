using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolidDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            IWork worker = new Worker();
            IEat eat = new Worker();
            worker.Work();
            eat.Eat();

            IManage manager = new Manager();
            manager.Work();
            eat.Eat();
            manager.ManageTeam();
        }
    }
}
