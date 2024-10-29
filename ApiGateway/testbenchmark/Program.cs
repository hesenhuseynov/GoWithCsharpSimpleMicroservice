using BenchmarkDotNet.Running;
using System.Diagnostics;

namespace testbenchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //BenchmarkRunner.Run<ArrayReverseBenchmark>();


            List<int> numbers = Enumerable.Range(1, 1000000).ToList();
             

            // IEnumerable ile Sorgu
            Stopwatch sw1 = Stopwatch.StartNew();
            var evenNumbersEnumerable = numbers.Where(n => n % 2 == 0).ToList();
            sw1.Stop();
            Console.WriteLine($"IEnumerable Sorgu Süresi: {sw1.ElapsedMilliseconds} ms");

            





        }
    }
}
