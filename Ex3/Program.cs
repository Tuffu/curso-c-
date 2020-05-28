using System;
using System.Globalization;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();
           

            Console.WriteLine("Entre com a altura do retângulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
            Console.WriteLine("AREA = " + x.Area().ToString(), CultureInfo.InvariantCulture);
            Console.WriteLine("Perímetro = " + x.Perimetro().ToString(),("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + x.Diagonal().ToString(),("F2", CultureInfo.InvariantCulture));
        }
    }
}
