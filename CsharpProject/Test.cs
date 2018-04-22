using System;

namespace CsharpProject
{
    // This class is just about basic with IL
    public class Test
    {
        public void BoxingAndUnboxing()
        {
            int a = 1234;
            object b = a;
            int c = (int)b;

            Console.WriteLine(c);

        }

        public void ImmutableString()
        {
            string a = "abc";
            string b = a;

            b += "d";

            // if string is a value type, a = "abc"
            // if string is a reference type, a = "abcd"
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public void IntermediateLanaguage()
        {
            // calculate powers of two
            int number = 2;
            for (int i = 0; i < 16; i++)
            {
                number = number * 2;
            }

        }

    }
}
