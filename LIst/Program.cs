using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria"); //add por padrão adiciona ao final da lista
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco"); // insere o valor em uma posição. Primeiro vem a posição, no caso 2, e depois o valor que é marco

            foreach (string obj in list) // para cada string obj na minha lista
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count); // conta os elementos da lista

            string s1 = list.Find(x => x[0] == 'A'); // Encontra o primeiro elemento da lista. x é o predicado. No português fica: x tal que xna posição 0 seja igual a A
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); // Encontra o último elemento da lista
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); // Encontra a primeira posição do elemento
            Console.WriteLine("Fisrt position: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // Encontra o ultimo elemento da posição 
            Console.WriteLine("Fisrt position: " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5); // Encontra elementos específicos. Neste caso procuramos na lista elementos que tenham tamanho igual a 5
            Console.WriteLine("----------------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex"); //Remove da lista um elemento da lista
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); // Remove tudo que você solicitar
            Console.WriteLine("----------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
                
    }
}
