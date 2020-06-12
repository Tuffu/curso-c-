using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException ) // sempre é bom colocar o tipo específico do tratamento, assim fica mais fácil tratar o problema
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}
