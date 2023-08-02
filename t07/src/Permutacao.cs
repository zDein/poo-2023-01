using System;

namespace CSharp.Entities
{
    class Permutacao
    {
        static void PermutacaoCode(string p, string S)
        {
            if(S.Length == 1)
            {
                Console.WriteLine(p + S);
            }
            else
            {
                string Slinha;
                string pLinha;

                for(int i = 0; i < S.Length; i++)
                {
                    Slinha = S.Substring(0, i) + S.Substring(i + 1);
                    pLinha = p + S[i];
                    PermutacaoCode(pLinha, Slinha);
                }
            }
        }

        static void Main(string[] args)
        {
            PermutacaoCode("", args[0]);
        }
    }
}