using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Stopwatch
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Duration { get; set; }
        
        public string Start()
        {
            DateTime start = DateTime.Now;
            StartTime = start.ToString("T");
            Console.WriteLine($"Stopwatch started at {StartTime}");
            return StartTime;
        }
        public string Stop()
        {
            DateTime stop = DateTime.Now;
            EndTime = stop.ToString("T");
            Console.WriteLine($"Stopwatch Stops at {EndTime}");
            return EndTime;
        }
       
        public void DurationOfTime()
        {
            Duration = int.Parse(EndTime) - int.Parse(StartTime);
            Console.WriteLine($"Duration of the stopwatch is {Duration}" );
            
        }
    }
}
