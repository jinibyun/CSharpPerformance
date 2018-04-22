using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject
{
    public class AvoidBoxing
    {
        // constants
        private const int arraySize = 1000000;

        public long MeasureA()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int a = 1;
            for (int i = 0; i < arraySize; i++)
            {
                a = a + 1;
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public long MeasureB()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            object a = 1;
            for (int i = 0; i < arraySize; i++)
            {
                a = (int)a + 1;
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public void Testing()
        {
            // 1st run to eliminate any startup overhead
            MeasureA();
            MeasureB();

            // measurement run
            long intDuration = MeasureA();
            long objDuration = MeasureB();

            // display results
            Console.WriteLine("Integer performance: {0} milliseconds", intDuration);
            Console.WriteLine("Object performance: {0} milliseconds", objDuration);
            Console.WriteLine();
            Console.WriteLine("Method B is {0} times slower", 1.0 * objDuration / intDuration);
        }

    }
}
