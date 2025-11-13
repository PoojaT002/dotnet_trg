using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SavingsAccount mysavings = new SavingsAccount("SA123", 1000);
            //mysavings.Deposit(500);
            //mysavings.CalculateInterest();

            //CurrentAccount currentAccount = new CurrentAccount("CA123", 5000);
            //currentAccount.Deposit(1000);
            //currentAccount.CalculateInterest();

            PersonalDetails personalDetails = new PersonalDetails();
            personalDetails.GetPersonalDetails();

            Console.ReadLine();
        }
    }
}
