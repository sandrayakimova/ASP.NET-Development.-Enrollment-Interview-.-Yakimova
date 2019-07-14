using System;

namespace z1
{
    public class Class1
    {
        public static long GetGCD(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                { a = a % b; }
                else
                { b = b % a; }
            }

            return a + b;
        }

    }
}
