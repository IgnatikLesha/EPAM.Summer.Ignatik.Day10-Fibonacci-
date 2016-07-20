using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    public static class Numbers
    {
        private static int FibonacciNumber(int n)
        {
            if( n <= 0)
                throw new ArgumentException();
            return n > 1 ? FibonacciNumber(n - 1) + FibonacciNumber(n - 2) : n;
        }

        public static IEnumerator GetFibonacciNumbers(int n)
        {
            if(n <=0 )
                throw new ArgumentException();

            for (int i = 0; i < n; i++)
            {
                yield return FibonacciNumber(i);
            }
        }

    }
}
