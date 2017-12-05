using System;

namespace ConsoleApp9
{
    class Program
    {
        internal sealed class MyClass
        {
            public void MyMethod(Int32 t, Int32 b, Int32 a, ref Int32[,] m, ref  Int32 count)
            {
                if (a < 1 || t < 1) return;
                for (Int32 i = 0; i < t; i++)
                {
                    if (m[b, i] == 0)
                    {
                        m[b, i] = count;
                        count++;
                    }
                }
                for (Int32 i = 1; i < a; i++)
                {
                    if (m[i, t - 1] == 0)
                    {
                        m[i, t - 1] = count;
                        count++;
                    }
                }
                for (Int32 i = t-2; i >= 0; i--)
                {
                    if (m[a - 1, i] == 0)
                    {
                        m[a - 1, i] = count;
                        count++;
                    }
                }
                for (Int32 i = a - 2; i > 0; i--)
                {
                    if (m[i, b] == 0)
                    {
                        m[i, b] = count;
                        count++;
                    }
                }
                MyMethod((t - 1), b + 1, a - 1, ref m, ref count);
            }
        }
        static void Main(string[] args)
        {
            Int32 a, t, b = 0, count = 1;
            Console.Write("Enter the width of the two-dimensional array = ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the hight of the two-dimensional array= ");
            a = Convert.ToInt32(Console.ReadLine());
            Int32[,] mas = new Int32[a, t];
            MyClass my = new MyClass();
            my.MyMethod(t, b, a,  ref mas, ref count);
            for (Int32 i = 0; i < a; i++)
            {
                for (Int32 j = 0; j < t; j++)
                {
                    Console.Write("{0:000}     ", mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
