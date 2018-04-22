using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject
{
    public class Exception2
    {
        // constants
        private const int elements = 1000000;
        private const int digits = 5;

        // fields
        private char[] digitArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'X' };
        private List<string> numbers = new List<string>();

        public void PrepareList()
        {
            Random random = new Random();
            for (int i = 0; i < elements; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int d = 0; d < digits; d++)
                {
                    int index = random.Next(11);
                    sb.Append(digitArray[index]);
                }
                numbers.Add(sb.ToString());
            }
        }

        public long MeasureA()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < elements; i++)
            {
                try
                {
                    int.Parse(numbers[i]);
                }
                catch (FormatException)
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
                int result = 0;
                int.TryParse(numbers[i], out result);
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

            Console.WriteLine("int.Parse: {0}", duration1);
            Console.WriteLine("int.TryParse: {0}", duration2);
        }

    }
}
