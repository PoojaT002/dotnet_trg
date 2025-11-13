using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNov10
{
    class InterestCalculator
    {
        public double CalculateInterest(double principle,double rate)
        {
            double time = 1;
            double si = (principle * rate * time) / 100;
            return si;
        }
        public double CalculateInterest(double principle,double rate,double time)
        {
            double si = (principle * rate * time) / 100;
            return si;
        }
        public double CalculateInterest(double principle, double rate, double time, int n)
        {
            double amount = principle * Math.Pow((1 + (rate / (n * 100))), n * time);
            double ci = amount - principle;
            return ci;
        }
        
        static void Main(string[] args)
        {
            InterestCalculator calc = new InterestCalculator();

            double si1 = calc.CalculateInterest(10000, 5);
            Console.WriteLine("Simple Interest (1 year): " + si1);

            double si2 = calc.CalculateInterest(10000, 5, 2);
            Console.WriteLine("Simple Interest (2 year): " + si2);

            double ci = calc.CalculateInterest(10000, 5, 2, 4);
            Console.WriteLine("Compound Interest : " + ci);



        }
    }
}
