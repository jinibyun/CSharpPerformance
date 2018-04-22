using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject
{
    public class Exception3
    {
        // constants
        private const int elements = 1000000;

        // fields
        private List<int> numbers = new List<int>();
        private Dictionary<int, string> lookup = new Dictionary<int, string> {
            { 0, "zero" },
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" }
        };

        public void PrepareList()
        {
            Random random = new Random();
            for (int i = 0; i < elements; i++)
            {
                numbers.Add(random.Next(11));
            }
        }

        public long MeasureA()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < elements; i++)
            {
                string s = null;
                try
                {
                    s = lookup[numbers[i]];
                }
                catch (KeyNotFoundException)
                {
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public long MeasureB()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < elements; i++)
            {
                string s = null;
                int key = numbers[i];
                if (lookup.ContainsKey(key))
                    s = lookup[key];
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public void Testing()
        {
            // initialization
            PrepareList();

            // measurement run
            long duration1 = MeasureA();
            long duration2 = MeasureB();

            Console.WriteLine("Lookup: {0}", duration1);
            Console.WriteLine("Lookup with check: {0}", duration2);
        }

    }
}
