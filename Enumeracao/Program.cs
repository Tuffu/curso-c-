﻿using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
using System;

namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayments
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PedingPayments.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
            
        }
    }
}