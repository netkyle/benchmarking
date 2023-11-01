using System;
using System.Diagnostics;
using System.Linq;

namespace Chapter2
{
    public class InAccurateTimeStamping
    {
        public void Sort_BadBenchmark(int volume)
        {
            var list = Enumerable.Range(0, volume).ToList();
            DateTime start = DateTime.Now;
            list.Sort();
            DateTime end = DateTime.Now;
            TimeSpan elapsedTime = end - start;
            Console.WriteLine($"Sort_BadBenchmark:{elapsedTime.TotalMilliseconds} ms");
        }

        public void Sort_BetterBenckmark(int volume)
        {
            var list = Enumerable.Range(0, volume).ToList();
            var stopwatch = Stopwatch.StartNew();
            list.Sort();
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            Console.WriteLine($"Sort_BetterBenckmark:{elapsedTime.TotalMilliseconds} ms");
        }

        public void GetTimeDiffForBenchmark()
        {
            long startTicks = Stopwatch.GetTimestamp();
            // Do something 
            long endTicks = Stopwatch.GetTimestamp();
            double elapsedSeconds = (endTicks - startTicks) * 1.0 / Stopwatch.Frequency;

            Console.WriteLine($"GetTimeDiffForBenchmark:{elapsedSeconds} s");
        }
    }
}
