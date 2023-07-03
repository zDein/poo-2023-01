using System;

namespace CSharp.Entities
{
    class Permutacao
    {
        public static void Permutacao(string p, string S)
        {
            if(S.length() == 1)
            {
                Console.WriteLine(p + S);
            }
            else
            {
                string Slinha;
                string pLinha;

                for(int i = 0; i < S.length(); i++)
                {
                    Slinha = S.Substring(0, i) + S.Substring(i + 1);
                    pLinha = p + S[i + 1];
                    Permutacao(pLinha, SLinha);
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        Permutacao(new string[], args[0]);
    }
}