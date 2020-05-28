using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;  // point é ponteiro. Aponta para um stack de memória
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }
    }
}
