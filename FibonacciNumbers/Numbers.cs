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
        public static int Fibonacci(int n)
        {
            return n > 1 ? Fibonacci(n - 1) + Fibonacci(n - 2) : n;
        }

        public static IEnumerator GetNumbers(int n)
        {
            if(n <=0 )
                throw new ArgumentException();

            for (int i = 0; i < n; i++)
            {
                yield return Fibonacci(i);
            }
        }

    }
}
