using System;
using System.Globalization;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args){
            Funcionario x, y;

            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro Funcionário");
            Console.WriteLine("Nome: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados dos segundo funcionário");
            Console.WriteLine("Nome: ");
            y.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double avg = (x.Salario + y.Salario) / 2;

            Console.WriteLine("Salário Médio: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
