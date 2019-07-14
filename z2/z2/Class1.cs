using System;

namespace z2
{
    public class Class1
    {
        public static int CountOfVowels(string str)
        {
            int vowelCount = 0;
            int k = str.Length;
            for (int i = 0; i < k; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
