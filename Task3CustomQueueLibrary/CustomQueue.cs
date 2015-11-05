using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3CustomQueueLibrary
{
    public class CustomQueue<T> : IEnumerable<T>
    {
        internal class ListNode
        {
            public T value;
            public ListNode nexListNode;

            public ListNode(T t)
            {
                value = t;
                nexListNode = null;
            }
        }

        internal  ListNode start;
        internal  ListNode end;

        public int Count { get; private set; } 
        public CustomQueue() 
        { 
            start = end = null; 
            Count = 0; 
        }

        public void Enqueue(T s) 
        { 
            if (Count == 0) 
                start = end = new ListNode(s); 
            else 
            { 
                end.nexListNode = new ListNode(s); 
                end = end.nexListNode; 
            } 
             
            Count++; 
        } 
 
        public T Dequeue() 
        { 
            if (Count == 0) 
                throw new System.InvalidOperationException("Очередь пуста."); 
             
            T s = start.value; 
            start = start.nexListNode;
          
            Count--;

            return s;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new System.InvalidOperationException("Очередь пуста.");

            return start.value;
        }

        public void Clear()
        {
            start = end = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomQueueIterator<T>(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
