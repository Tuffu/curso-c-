using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3]; // como instanciar uma matriz.

            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank);

            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));
        }
    }
}
