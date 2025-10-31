using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string FirstName, LastName,Gender;
            //int age;
            //char grade;
            //int Score1, Score2, Score3;
            //Console.WriteLine("Enter the FirstName,LastName,Gender,Age,Score1,Score2,Score3");
            //FirstName = Console.ReadLine();
            //LastName= Console.ReadLine();
            //Gender=      
            //int num = 100;
            //double value = num;
            //Console.WriteLine($" num = {num} \n value= {value}");

            //double pi = 3.14;
            //int intpi = (int)pi;

            //object obj = num;
            //int myval = (int)obj;
            int a = 100;
            int b = a;
            Console.WriteLine($"A value is {a} \t b value is ={b}");
            b = 899;
            Console.WriteLine($"A value is {a} \t b value is ={b}");

            string[] names = { "Pooja", "Tirmal" };
            string[] copyNames = names;
            Console.WriteLine($"names [0] {names[0]} \t names[1] value is ={names[1]}");

            
            copyNames[0] = "Rohit";
            Console.WriteLine($"names [0] {names[0]} value is ={names[1]}");
        }
    }
}
