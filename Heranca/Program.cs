using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinesAccount account = new BusinesAccount(8010, "Bob", 100.0, 500.0);
            Console.WriteLine(account.Balance);
        }
    }
}
