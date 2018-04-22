using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject
{
    public class FastCollection
    {
        // constants
        private const int numElements = 1000000;

        public long MeasureA()
        {
            ArrayList list = new ArrayList();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numElements; i++)
            {
                list.Add(i);
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public long MeasureB()
        {
            List<int> list = new List<int>();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numElements; i++)
            {
                list.Add(i);
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public long MeasureC()
        {
            int[] list = new int[numElements];
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numElements; i++)
            {
                list[i] = i;
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public void Testing()
        {
            // measurement run
            long duration1 = MeasureA();
            long duration2 = MeasureB();
            long duration3 = MeasureC();

            Console.WriteLine("ArrayList: {0}", duration1);
            Console.WriteLine("List<int>: {0}", duration2);
            Console.WriteLine("int[]: {0}", duration3);
        }
    }
}
