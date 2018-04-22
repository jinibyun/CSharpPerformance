using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject
{
    public class Exception
    {
        // constants
        private const int repetitions = 1000000;

        public long MeasureA()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int count = 0;
            for (int r = 0; r < repetitions; r++)
            {
                count = count + 1;
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public long MeasureB()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int count = 0;
            for (int r = 0; r < repetitions; r++)
            {
                try
                {
                    count = count + 1;
                    throw new InvalidOperationException();
                }
                catch (InvalidOperationException)
                {

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

            Console.WriteLine("Normal: {0}", duration1);
            Console.WriteLine("With exceptions: {0}", duration2);
        }

    }
}
