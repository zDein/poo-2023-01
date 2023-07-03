using System;

namespace CSharp.Entities
{
    public class Janela
    {
        public double Area { get; set; }
        public Vidro Vidro { get; set; }

        public Janela(double area)
        {
            Area = area;
        }
    }
}