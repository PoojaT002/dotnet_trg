using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolidDemo
{
    public class Manager : IWork, IEat, IManage
    {
        public void Work()
        {
            Console.WriteLine("Manager is working.......");
        }
        public void Eat()
        {
            Console.WriteLine("Manager is eating......");
        }
        public void ManageTeam()
        {
            Console.WriteLine("Manager is managing the team......");
        }
    }
}
