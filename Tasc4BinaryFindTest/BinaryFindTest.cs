using System;
using NUnit.Framework;
using System.Collections;
using Task4BinaryFind;
using System.Collections.Generic;

namespace Tasc4BinaryFindTest
{
    [TestFixture]
    public class BinaryFindTest
    {
        [Test]
        public void BinatryFindInt()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int ind = BinaryFind<int>.Find(a, 8, new ComparerInt());
            Assert.AreEqual(ind,7);
        }

        [Test]
        public void BinatryFindDouble()
        {
            double[] a = new double[] { 0.0, 1.0, 1.5, 2.5, 3.7, 4.0};
            int ind = BinaryFind<double>.Find(a, 3.7, new ComparerDouble());
            Assert.AreEqual(ind, 4);
        }

    }

    class ComparerInt : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }

    class ComparerDouble : IComparer<double>
    {
        public int Compare(double x, double y)
        {
            return (int)(x - y);
        }
    }
}