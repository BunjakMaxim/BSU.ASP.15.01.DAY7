using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4BinaryFind
{
    public class BinaryFind<T>
    {
        public static int Find(T[] array, T value, IComparer<T> comparer)
        {
            int left = 0, riht = array.Length - 1, ind;

            do
            {
                ind = (riht - left) / 2 + left;
                if (comparer.Compare(array[ind], value) > 0)
                    riht = ind;
                else if (comparer.Compare(array[ind], value) < 0)
                    left = ind;
                else
                    break;

            } while (riht != left);

            return ind;
        }
    }
}
