using static System.Console;
using System;
using System.Linq;
using System.Globalization;
using System.Net.Http.Headers;

namespace CsConsole
{
    //p294
    public static class IntergerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }
        public static int Power(this int myInt, int exponent)
        {
            int result =myInt;
            for(int i=1; i<exponent; i++) { 
                result =result*myInt;
            }
            return result;
        }
    }
    //p298
    struct Point3D
    {
        public int x;
        public int y; 
        public int z;
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return string.Format($"{x}, {y}, {z}");
        }
    }

    class MainApp
    {

        static void Main(string[] args)
        {
            //P295
            WriteLine($"3^2 : {3.Square()}");
            WriteLine($"3^4 : {3.Power(4)}");
            WriteLine($"2^10 : {2.Power(10)}");

            //p298
            Point3D p3d1;
            p3d1.x = 10;
            p3d1.y = 20;
            p3d1.z = 40;
            WriteLine(p3d1.ToString());

            Point3D p3d2 = new Point3D(100, 200, 300);
            Point3D p3d3 = p3d2;
            p3d3.z = 400;
            WriteLine(p3d2.ToString());
            WriteLine(p3d3.ToString());

            //p306
            var a = ("SuperMan", 9999);
            WriteLine($"{a.Item1}, {a.Item2}");

            var b = (Name: "Kim", Age: 16);
            WriteLine($"{b.Name}, {b.Age}, {b.Item2}");

            var (name, age) = b;
            WriteLine($"{name}, {age}");

            var (name2, age2) = ("Park", 35);
            WriteLine($"{name2}, {age2}");

            b = a;
            WriteLine($"{b.Name} {b.Age}");
            ReadLine();
        }
    }
}