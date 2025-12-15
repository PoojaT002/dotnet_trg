using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    public class CrudDemo
    {
        Model1 dc = new Model1();
        public void Display()
        {

            var res = from t in dc.IPLs
                      select t;

            foreach (var item in res)
            {
                Console.WriteLine(item.TeamID + ":" + item.TeamName + ":" + item.State + ":" + item.Captain);
            }
        }




        public void Insert()
        {


            IPL ob = new IPL() { TeamID = 1, TeamName = "RCB", Captain = "Virat", State = "Karnataka" };

            dc.IPLs.Add(ob);
            int i = dc.SaveChanges();
            Console.WriteLine("total rows inserted is " + i);
        }
    }

}

