using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethodDemo
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle : run for pre-run Checks");
        }
            
    }
    public class Car : Vehicle
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("Car : start with key");
        }
    }
    public class ElectriCar : Car
    {
        public sealed override void Start()
        {
            base.Start();
            Console.WriteLine("ElectricCar : start with button");        
        }
    }
    //public class HybridCar: ElectriCar
    //{
    //    //the following override would cause a compile time error
    //    public override void Start()
    //    {
    //        base.Start();
    //        Console.WriteLine("HybridCar: start with hybrid system");
    //    }
    //}

    public class Program
    {
        static void Main(string[] args)
        {
            ElectriCar myelectricCar = new ElectriCar();
            myelectricCar.Start();
            Console.ReadLine();
            
        }
    }
}
