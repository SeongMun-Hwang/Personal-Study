using System.Collections;
using static System.Console;

namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p165
            int i = 10;
            while(i> 0)
            {
                WriteLine($"i : {i--}");
            }

            //p173
            int[] arr = new int[] { 0, 1, 2, 3, 4 };
            foreach(int a in arr)
            {
                WriteLine($"a : {a}");
            }

            //179
            for(int j=0; j < 5; j++)
            {
                if (j == 4)
                    continue;
                WriteLine($"continue : {j}");
            }

            //185
            object foo = 23;
            if(foo is int)
                WriteLine(foo);

            ReadLine();
        }
    }
}