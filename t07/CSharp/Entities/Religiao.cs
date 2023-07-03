using System;
using System.Generics;

namespace CSharp.Entities
{
    class Religiao
    {
        private ArrayList devotos;

        public void NovoFiel(Devoto d)
        {
            devotos.Add(d);
        }
    }

    class Devoto
    {
        public Devoto(Religiao r)
        {
            r.NovoFiel(this);
        }
    }
}