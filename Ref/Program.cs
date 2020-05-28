using System;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // ref exigie que a váriavel seja iniciada ex: colocando valor.
            Calculator.Triple(ref a); // quando retornar a conta do método o ref referenciará o resultado para a variável principal
            Console.WriteLine(a);
        }
    }
}
