using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Timer;
using Task2FibonacciSequence;
using Task3CustomQueueLibrary;
using Task4BinaryFind;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.StartTime(2);
            timer.stopTime += TimeOut;
            timer.StartTime(5);

            Console.WriteLine();
            foreach (var f in FibonacciSequence.Sequence(10))
                Console.WriteLine(f);

            CustomQueue<int> queue = new CustomQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(14);
            foreach(var q in queue)
            {
                Console.WriteLine(q);
            }

            Console.ReadKey();
        }

        private static void TimeOut(Object sender, EventArgs e)
        {
            Console.WriteLine("Время вышло!");
        }
    }
}
