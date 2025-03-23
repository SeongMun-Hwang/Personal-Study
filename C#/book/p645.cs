using System;
using System.IO;
using static System.Console;

namespace Program
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p645
            using (BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create)))
            {
                bw.Write(int.MaxValue);
                bw.Write("Good Morning");
                bw.Write(uint.MaxValue);
                bw.Write("Hello!");
                bw.Write(double.MaxValue);
            }
            using BinaryReader br=new BinaryReader(new FileStream("a.dat",FileMode.Open));

            WriteLine($"file size : {br.BaseStream.Length} bytes");
            WriteLine($"{br.ReadInt32()}");
            WriteLine($"{br.ReadString()}");
            WriteLine($"{br.ReadUInt32()}");
            WriteLine($"{br.ReadString()}");
            WriteLine($"{br.ReadDouble()}");

            ReadLine();
        }
    }
}