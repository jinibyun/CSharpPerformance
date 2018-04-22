using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject
{
    public class StringConcatenation
    {

        // constants
        private const int numRepetitions = 10000;

        public long MeasureA()
        {
            string s = string.Empty;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numRepetitions; i++)
            {
                s = s + "a";
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public long MeasureB()
        {
            StringBuilder sb = new StringBuilder();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numRepetitions; i++)
            {
                sb.Append("a");
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public void Testing()
        {
            // 1st run to eliminate any startup overhead
            MeasureA();
            MeasureB ();

            // measurement run
            long duration1 = MeasureA();
            long duration2 = MeasureB ();

            // display results
            Console.WriteLine("String performance: {0} milliseconds", duration1);
            Console.WriteLine ("StringBuilder performance: {0} milliseconds", duration2);
        }
    }
}
