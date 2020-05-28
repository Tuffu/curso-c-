using System;
using System.Security.Cryptography;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum( 2, 3); //ao utilizar o params eu não preciso instanciar o new, usando apenas os parenteses
            int s2 = Calculator.Sum( 2, 4, 3 );

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
