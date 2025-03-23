using System;
using System.IO;
using static System.Console;
namespace Program
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p635
            long someValue = 0x123456789ABCDEF0;
            WriteLine("{0,-1} : 0x{1:X16}", "Original Data",someValue);

            Stream outStream = new FileStream("a.dat", FileMode.Create);
            byte[] wBytes=BitConverter.GetBytes(someValue);

            Write("{0,-13} : ", "Byte array");

            foreach (byte b in wBytes)
                Write("{0:X2} ", b);
            WriteLine();

            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();

            Stream inStream = new FileStream("a.dat",FileMode.Open);
            byte[] rbytes = new byte[8];

            int i = 0;
            while(inStream.Position<inStream.Length)
                rbytes[i++] = (byte)inStream.ReadByte();

            long readValue=BitConverter.ToInt64(rbytes, 0);

            WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
            inStream.Close();

            ReadLine();
        }
    }
}