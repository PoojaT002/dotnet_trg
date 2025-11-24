using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNov24
{
    //exercise 1
    public class Calculator
    {
        public int Square(int a) => a * a;


        //exercise 3
        public int Multiply(int a, int b) => a * b;
    }


    //exercise 2
    public class StringHelper
    {
        public string ToUpper(string input) => input.ToUpper();
    }

    //exercise 4
    public class StudentService
    {
        public void ValidateAge(int age)
        {
            if (age < 0) throw new ArgumentException("Invalid age");
        }
    }

        //exercise 6: Collection Assertions
    public class CollectionAssertion
    {
        public List<int> GetEvenNumbers() => new List<int> { 2, 4, 6, 8 };


    }

    //exercise 8: Testing Asynchronous Method

    public class Asyn()
    {
        public async Task<int> GetMarksAsync()
        {
            await Task.Delay(100);
            return 90;
        }
    }

    




}


