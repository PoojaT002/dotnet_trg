using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Demo


{


    public delegate void PrintDelegate(int Number);


    public delegate void GreetMessage(string str);


    internal class ActionDelegate


    {

        public  static void Main(string[] args)


        {


            //action delegate

            //PrintDelegate printDel=new PrintDelegate(ConsolePrint);


            //or

            PrintDelegate printDel = ConsolePrint;


            printDel(100);

            //ActionDelegate example 2


            Action<int> printAction = ConsolePrint;


            printAction(200);

            //Action Delegate with anonymous method


            Action<string> greetAction = delegate (string name)


            {


                Console.WriteLine("Hello from anonymous method " + name);


            };

            greetAction("John");

            //example for lambda expression with action delegate


            Action<string> greet = name => Console.WriteLine("Hello from lambda expression " + name);


            greet("Alice");

            GreetMessage greetMessage = GreetMessage;


            greetMessage("Bob");

            Console.ReadLine();

        }

        public static void ConsolePrint(int i)


        {


            Console.WriteLine("ConsolePrint Function: " + i);

        }


        public static void GreetMessage(string name)


        {


            Console.WriteLine("Hello " + name + ", Welcome to Action Delegate Demo!");


        }


    }


}

