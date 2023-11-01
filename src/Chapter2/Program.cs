using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // ExecuteTimestaping();
            RunBenchmarkExecution();
        }

        static void ExecuteTimestaping()
        {
            var timestaping = new InAccurateTimeStamping();
            timestaping.GetTimeDiffForBenchmark();
            timestaping.Sort_BadBenchmark(10000);
            timestaping.Sort_BetterBenckmark(10000);
        }

        static void RunBenchmarkExecution()
        {
            var benchmarkExecution = new BenchmarkExecution();
            benchmarkExecution.GetExecutionTime();
        }
    }
}
