using System;
using System.Globalization;
namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            Console.WriteLine("Funcionario: " + func);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(percent);

            Console.WriteLine("Dados Atualizados: " + func);
        }
    }
}
