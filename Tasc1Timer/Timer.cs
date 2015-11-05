using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1Timer
{
    public class Timer
    {
        public event EventHandler stopTime;
        
        public void StartTime(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            if(stopTime != null)
                stopTime(this, new EventArgs());
        }
    }
}
