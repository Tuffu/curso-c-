using System;

namespace CondiçãoTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            //condição ternaria se o preço for menor que 20, ativará preco * 0.1
            //se for maior que 20 acionará preco * 0.5
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.5;
            
            Console.WriteLine(desconto);
        }
    }
}
