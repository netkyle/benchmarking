using System;
using System.Diagnostics;
using System.Linq;

namespace Chapter2
{
    public class BenchmarkExecution
    {
        public void GetExecutionTime()
        {
            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < 100000000; i++)
            {

            }
            stopwatch.Stop();
            Console.WriteLine($"GetExecutionTime:{stopwatch.ElapsedMilliseconds} ms");

            /**output in my laptop**/
            // dotnet run
            // GetExecutionTime:428 ms
            // dotnet run -c release
            //GetExecutionTime:46 ms
        }
    }
}