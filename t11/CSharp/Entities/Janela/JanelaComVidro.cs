using System;

namespace CSharp.Entities
{
    public class JanelaComVidro : Janela
    {
        public double AreaComVidro { get; set; }

        public JanelaComVidro(double areaComVidro)
        {
            AreaComVidro = areaComVidro;
        }
    }
}