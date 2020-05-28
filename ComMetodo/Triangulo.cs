using System;
using System.Collections.Generic;
using System.Text;

namespace ComMetodo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area() // não vai ter parametros de entrada, porque ela já está dentro da classe triângulo, o método está consumindo A, B e C
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
