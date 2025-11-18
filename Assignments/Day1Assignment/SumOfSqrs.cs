using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day1Assignment
{
   public static class SumOfSqrs
    {
        public static int SumOfSquares(this IEnumerable<int> numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n * n;
            }
            return sum;
        }
    }
}
