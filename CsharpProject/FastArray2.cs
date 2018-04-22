using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject
{
    public class FastArray2
    {
        // constants
        private const int numElements = 1000;

        public long MeasureA()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[,] list = new int[numElements, numElements];
            for (int i = 0; i < numElements; i++)
            {
                for (int j = 0; j < numElements; j++)
                {
                    list[i, j] = 1;
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public long MeasureB()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] list = new int[numElements * numElements];
            for (int i = 0; i < numElements; i++)
            {
                for (int j = 0; j < numElements; j++)
                {
                    // flattening two dimensional to one dimensional: even faster
                    int index = numElements * i + j;
                    list[index] = 1;
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public void Testing()
        {
            // measurement run
            long duration1 = MeasureA();
            long duration2 = MeasureB();

            Console.WriteLine("int[,]: {0}", duration1);
            Console.WriteLine("flattened int[,]: {0}", duration2);
        }
    }
}
