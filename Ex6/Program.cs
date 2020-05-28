using System;
using System.Dynamic;
using System.Globalization;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito(s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoIncial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoIncial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
                        
            Console.WriteLine();
            Console.Write("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double depos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(depos);

            Console.WriteLine();
            Console.Write("Dados atualizados da Conta: ");
            Console.Write(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saq);

            Console.WriteLine();
            Console.Write("Dados atualizados da Conta: ");
            Console.Write(conta);
        }
    }
}
