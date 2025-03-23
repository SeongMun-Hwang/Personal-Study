using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace CsConsole
{
    class MainApp
    {
        //p212
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        //p215
        class Product
        {
            private int price = 100;
            public ref int GetPrice()
            {
                return ref price;
            }
            public void PrintPrice()
            {
                WriteLine("Price : {0}", price);
            }
        }
        static void Main(string[] args)
        {
            //p212
            int x = 3;
            int y = 4;
            Swap(ref x, ref y);
            WriteLine("x : {0}, y : {1}",x,y);

            //p215
            Product carrot = new Product();
            ref int ref_local_price=ref carrot.GetPrice();
            int normal_local_price=carrot.GetPrice();

            carrot.PrintPrice();
            WriteLine($"Ref local price : {ref_local_price}");
            WriteLine($"Normal local price : {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            WriteLine($"Ref local price : {ref_local_price}");
            WriteLine($"Normal local price : {normal_local_price}");

            ReadLine();
        }
    }
}