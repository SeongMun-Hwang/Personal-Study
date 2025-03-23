using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    //p465
    class InvalidArgumentExeption : Exception
    {
        public InvalidArgumentExeption() { }
        public InvalidArgumentExeption(string message) : base(message) { }
        public object Argument { get; set; }
        public string Range { get; set; }
    }
    class MainApp
    {    
        //p466
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };
            foreach (uint arg in args)
            {
                if (arg > 255)
                    throw new InvalidArgumentExeption()
                    {
                        Argument = arg,
                        Range = "0-255"
                    };
            }
            return (alpha << 24 & 0xFF000000) |
                (red << 16 & 0x00FF0000) |
                (green << 8 & 0x0000FF00) |
                (blue & 0x000000FF);
        }
        static void Main(string[] args)
        {
            //p466
            try
            {
                WriteLine("0x{0:X}", MergeARGB(255, 111, 111, 111));
                WriteLine("0x{0:X}", MergeARGB(1, 65, 192, 128));
                WriteLine("0x{0:X}", MergeARGB(0, 255, 255, 300));
            }
            catch(InvalidArgumentExeption ex)
            {
                WriteLine(ex.Message);
                WriteLine($"Arguement : {ex.Argument}, Range : {ex.Range}");
            }

            ReadLine();
        }
    }
}