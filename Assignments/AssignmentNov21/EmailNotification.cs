using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNov21
{
    public class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending Email Notification...");
        }
    }
    public class SmsNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending Sms Notification...");
        }
    }
    public class PushNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending Push Notification...");
        }
    }

}
