using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;

        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
