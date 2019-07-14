using System;

namespace z4
{
    public class Class1
    {
        public static string RemoveDuplicateWords(string str)
        {
            char[] razd = { '.', ',', ' ', ';', '!', '?', '-', ':' };//массив из разделительных символов

            string[] words = str.Split(razd);//массив всех слов в строке
            char[] vosst = new char[words.Length];//все разделители которые встречались на пути
            string vost = null;//строка которая получится в конце
            int kurs = 0;
            int m = 0;
            while (kurs != str.LastIndexOfAny(razd))
            {
                kurs = str.IndexOfAny(razd, kurs + 1);
                vosst[m] = str[kurs];
                m++;
            }


            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "1")
                {

                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            words[j] = "1";
                        }
                    }
                }
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] != "1")
                {

                    vost = vost + words[i] + vosst[i];

                }
            }
            if (words[words.Length - 1] != "1")
            {
                vost = vost + words[words.Length - 1];
            }

            return vost;

        }
    }
}
