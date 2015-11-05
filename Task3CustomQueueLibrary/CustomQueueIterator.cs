using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3CustomQueueLibrary
{
    class CustomQueueIterator<T> : IEnumerator<T>
    {
        private readonly CustomQueue<T> queue;
        private CustomQueue<T>.ListNode naw;

        public CustomQueueIterator(CustomQueue<T> q)
        {
            queue = q;
        }

        public T Current
        {
            get { return naw.value;}
        }

        object System.Collections.IEnumerator.Current
        {
            get {return Current; }
        }

        public bool MoveNext()
        {
            if (naw == null)
            {
                naw = queue.start;
                return true;
            }
            else
            {
                naw = naw.nexListNode;
                if (naw != null)
                    return true;
            }
            return false;
        }

        public void Reset()
        {
            naw = null;
        }

        public void Dispose()
        {
        }
    }
}
