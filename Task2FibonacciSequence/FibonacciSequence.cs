using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2FibonacciSequence
{
    public static class FibonacciSequence
    {
        public static IEnumerable<int> Sequence(int maxNumber)
        {
            int i = 0; 
            int a = 0, b = 1;
            
            yield return a;

            while(i++ < maxNumber)
            {
                a += b;
                b = a - b;

                yield return a; 
            }
        }
    }
}
