using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNov21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter notification type (email/sms/push):");
            string type=Console.ReadLine();

            INotification notify= NotificationFactory.GetNotification(type);

            if(notify!=null)
            {
                notify.Send();
            }
            else
            {
                Console.WriteLine("Invalid notification type");
            }
        }
    }
}
