using Day3Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Client.config", false);
            //Get all registere client types
            var entries = RemotingConfiguration.GetRegisteredWellKnownClientTypes();
            //if(entries.Length ==0)
            //{
            //    WriteLine("No client types registered in config");
            //    return;
            //}
            //use the registered URL from config
            var remoteType = entries[0];
            IMyinter ob = (IMyinter)Activator.GetObject(remoteType.ObjectType, remoteType.ObjectUrl);

            WriteLine("connected to remote object...");
            var all = ob.ShowAllStudents();
            WriteLine("=== ALL STUDENTS ===");
            
                WriteLine(all);
            
            Write("\n Enter student Id: ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                var stud = ob.GetStudent(id);
                Console.WriteLine($"Found: {stud}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
            Console.ReadLine();
        }
    }
}