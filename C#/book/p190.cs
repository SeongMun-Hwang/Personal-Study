using System.Collections;
using static System.Console;
using System;

namespace CsConsole
{
    class MainApp
    {
        class OrderItem
        {
            public int Amount { get; set; }
            public int Price { get; set; }
        }
        static double GetPrice(OrderItem item) => item switch
        {
            OrderItem { Amount: 0 } or OrderItem { Price: 0 } => 0.0,
            OrderItem { Amount: >= 100 } or OrderItem { Price: >= 10_000 }
            => item.Amount * item.Price * 0.8,
            not OrderItem { Amount: < 100 }
            => item.Amount * item.Price * 0.9,
            _ => item.Amount * item.Price,
        };
        static void Main(string[] args)
        {
            WriteLine(GetPrice(new OrderItem() { Amount = 0, Price = 10_000 }));
            WriteLine(GetPrice(new OrderItem() { Amount = 100, Price = 10_000 }));
            WriteLine(GetPrice(new OrderItem() { Amount = 100, Price = 9_000 }));
            WriteLine(GetPrice(new OrderItem() { Amount = 1, Price = 1_000 }));
            ReadLine();
        }
    }
}