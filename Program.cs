using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 10, x1 = 0;
            int fir = 0, sec = 0;
            string s = null;
            List<int> lon = new List<int>();
            for (int i = 10000; i < 99999; i++)
            {
                if (IsSimple(i))
                {
                    lon.Add(i);
                }
                
            }
            foreach (var i in lon)
            {
                foreach (var z in lon)
                {
                    if (i != z & z > i)
                    {
                        x = (long)i * z;
                        s = (x).ToString();
                        if (Palindrom(s))
                        {
                            if(x1 < x)
                            {
                                x1 = x;
                                fir = i;
                                sec = z;
                            }
                            break;
                        }
                    }

                }

            }
            Console.WriteLine($" Палиндром = {x1} 1-е простое число = {fir} 2-е простое число = {sec}");
            Console.ReadKey();
        }

        private static bool IsSimple(int x)
        {
            for (int i = 2; i <= (int)(x / 2); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
        private static bool Palindrom(string s)
        {
            if (s.Length <= 2) return false;
            for (int i = 0; i < s.Length / 2; i++)
                if (s[i] != s[s.Length - i - 1])
                    return false;
            return true;
            
        }
    }
}