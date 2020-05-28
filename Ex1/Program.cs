using System;


namespace Ex1
{
    class Program
    {
        static void Main(string[] args){
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();
            
            Console.WriteLine("Dados da Primeira Pessoa");
            Console.WriteLine("Nome: ");
            x.Name = Console.ReadLine();
            Console.WriteLine("Idade: ");
            x.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Primeira Pessoa");
            Console.WriteLine("Nome: ");
            y.Name = Console.ReadLine();
            Console.WriteLine("Idade: ");
            y.Age = int.Parse(Console.ReadLine());

            if(x.Age > y.Age)
            {
                Console.WriteLine("Pessoa mais velha: " + x.Name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + y.Name);
            }
        }
    }
}
