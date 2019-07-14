using System;

namespace z3
{
    public class Class1
    {
        public static string[] OrderStringsByLength(string[] massivstr)
        {
            string temp;
            for (int i = 0; i < massivstr.Length - 1; i++)
            {
                for (int j = i + 1; j < massivstr.Length; j++)
                {
                    if (massivstr[i].Length > massivstr[j].Length)
                    {
                        temp = massivstr[i];
                        massivstr[i] = massivstr[j];
                        massivstr[j] = temp;
                    }
                }
            }
            return massivstr;
        }
    }
}
