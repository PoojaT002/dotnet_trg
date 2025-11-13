using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNov11
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public static BankAccount operator +(BankAccount a1, BankAccount a2)
        {
            return new BankAccount("NEW123", "Merged Account", a1.Balance + a2.Balance);
        }

        public static BankAccount operator -(BankAccount acc, decimal amount)
        {
            decimal newBalance = acc.Balance - amount;
            if(newBalance < 0)
            {
                Console.WriteLine("Withdrawal denied! Insufficient funds.");
                newBalance=acc.Balance;
            }
            return new BankAccount(acc.AccountNumber, acc.AccountHolder, newBalance);
        }

        public static bool operator == (BankAccount a1, BankAccount a2)
        {
            return a1.Balance == a2.Balance;
        }
        public static bool operator !=(BankAccount a1, BankAccount a2)
        {
            return !(a1 == a2);
        }
        public override bool Equals(object obj)
        {
            if(obj is BankAccount other)
            return Balance == other.Balance;
            return false;
        }
        public override int GetHashCode()
        {
            return Balance.GetHashCode();
        }
        public override string ToString()
        {
            return $"Account Holder: {AccountHolder} , Account Number: {AccountNumber} , Balance: Rs{Balance}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("A101", "Pooja", 5000m);
            BankAccount acc2 = new BankAccount("A102", "Sona", 3000m);

            Console.WriteLine("-----Initial Accounts-----");
            Console.WriteLine(acc1);
            Console.WriteLine(acc2);

            BankAccount merged = acc1 + acc2;
            Console.WriteLine("\nAfter Merging Balance (+):");
            Console.WriteLine(merged);

            BankAccount afterWithdraw = acc1 - 2000m;
            Console.WriteLine("\nAfter Withdrawal Balance (-):");
            Console.WriteLine(afterWithdraw);

            
        }
    }
}
