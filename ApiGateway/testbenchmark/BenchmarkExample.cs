using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testbenchmark
{
    public class ArrayReverseBenchmark
    {

        private int[] data;

        [GlobalSetup]
        public void Setup()
        {
            data = new int[1000];
            Random random = new Random();
            for (int i = 0; i < data.Length; i++)
            {
               data[i] = random.Next(0,10000);

            }


        }


        [Benchmark]
        public void ReverseArray()
        {
            Array.Reverse(data);
        }

        [Benchmark]
        public int[] ManuelReverse()
        {
            int[] reversed = new int[data.Length];
            for(int i=0,j=data.Length-1; i < data.Length; i++, j--)
            {
                reversed[i] = data[j];
            }
            return reversed;
        }


   
    }
}
