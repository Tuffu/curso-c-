using System;
using System.Globalization;
using System.Numerics;

namespace ArrayEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] vet = new Pessoa[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());                     

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Alguel #{i}:"); //{i} pega a posição atual do vetor e mostra na tela
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vet[room] = new Pessoa(name, email); 

            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null) // valida se a posição atual do vetor é nula para poder inserir a informação
                {
                    Console.WriteLine(i + " : " + vet[i]);
                }
            }
        }
    }
}
