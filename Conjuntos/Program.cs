using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>(); // o conjunto não aceita repetições
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            //A.IntersectWith(B);
            //A.UnionWith(B);
            //A.ExceptWith(B);
            
            foreach (int x in A)  //para cada int x no inteiro A
            {
                Console.WriteLine(x);
            }
           // B.Remove(4); // remove elementos

            /*Console.WriteLine("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());
            Console.ReadLine();

            if (B.Contains(N))
            {
                Console.WriteLine(N + " pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine(N + " não pertence ao conjunto B");
            }*/
        }
    }
}
