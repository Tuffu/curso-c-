using System;
using System.Globalization;

namespace Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Digite o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circuferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferencia: " +circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
