using System;
using System.Xml;
using System.Globalization;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite o Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno");
            aluno.Nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL: " + aluno.Med().ToString(), CultureInfo.InvariantCulture);

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("Faltaram " + aluno.NotaRestante().ToString(), CultureInfo.InvariantCulture);
            }
        }
    }
}
