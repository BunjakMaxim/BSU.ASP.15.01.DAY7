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
        public void BinatryFindIntNull()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int ind = BinaryFind<int>.Find(a, 11, new ComparerInt());
            Assert.AreEqual(ind, -1);
        }

        [Test]
        public void BinatryFindDouble()
        {
            double[] a = new double[] { 0.0, 1.0, 1.5, 2.5, 3.7, 4.0};
            int ind = BinaryFind<double>.Find(a, 3.7, new ComparerDouble());
            Assert.AreEqual(ind, 4);
        }

        [Test]
        public void BinatryFindPoint()
        {
            Point[] a = new Point[] { new Point(1, 2), new Point(2, 3), new Point(3, 4), new Point(4, 5) };
            int ind = BinaryFind<Point>.Find(a, new Point(2, 3), null); 
            Assert.AreEqual(ind, 1);
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

    class Point : IComparer<Point>
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Compare(Point x, Point y)
        {
            return (x.x - y.x) + (x.y - y.y);
        }
    }
}