using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4BinaryFind
{
    public static class BinaryFind<T>
    {
        public static int Find(T[] array, T value, IComparer<T> comparer)
        {
            if (comparer == null)
            {
                if (value is IComparer<T>)
                    comparer = (IComparer<T>)value;
                else
                    throw new ArgumentNullException();
            }

            int left = 0, riht = array.Length, ind;

            do
            {
                ind = (riht - left) / 2 + left;
                if (comparer.Compare(array[ind], value) > 0)
                    riht = ind;
                else if (comparer.Compare(array[ind], value) < 0)
                    left = ind;
                else
                    return ind;

            } while (riht > left + 1);

            return -1;
        }
    }
}
