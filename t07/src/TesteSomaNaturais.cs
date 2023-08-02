using System;

namespace CSharp.Entities
{
    class TesteSomaNaturais
    {
        public static long SomaNaturais(int n)
        {
            int c = 1;
            int s = 0;

            while (c <= n)
            {
                s += c;
                c++;
            }

            return s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SomaNaturais(10));
        }
    }
}