using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var timestaping=new InAccurateTimeStamping();
            timestaping.GetTimeDiffForBenchmark();
            timestaping.Sort_BadBenchmark(10000);
            timestaping.Sort_BetterBenckmark(10000);

            Console.ReadKey();
        }
    }
}
