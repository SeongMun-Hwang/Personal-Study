using static System.Console;

namespace CsConsole
{
    //p357
    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }
        public override string ToString()
        {
            return $"{From,-10}->{To,-10}:${Amount}";
        }
    }
    class CTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }
        public override string ToString()
        {
            return $"{From,-10}->{To,-10}:${Amount}";
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            //p358
            RTransaction tr1 = new RTransaction()
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };
            RTransaction tr2 = new RTransaction()
            {
                From = "Alice",
                To = "Charlie",
                Amount = 100
            };
            WriteLine(tr1);
            WriteLine(tr2);
            WriteLine();

            //p359
            RTransaction tr3 = new RTransaction() { From="Alice",To="Bob",Amount = 100};
            RTransaction tr4 = tr1 with { To = "Charlie" };
            RTransaction tr5 = tr2 with { From = "Dave", Amount = 30 };

            WriteLine(tr3);
            WriteLine(tr4);
            WriteLine(tr5);
            WriteLine();

            //362
            CTransaction trA = new CTransaction() { From = "Alice", To = "Bob", Amount = 100 };
            CTransaction trB = new CTransaction() { From = "Alice", To = "Bob", Amount = 100 };
            WriteLine(trA);
            WriteLine(trB);
            WriteLine($"trA equals to trB : {trA.Equals(trB)}");

            RTransaction tr6 = new RTransaction() { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr7 = new RTransaction() { From = "Alice", To = "Bob", Amount = 100 };
            WriteLine(tr6);
            WriteLine(tr7);
            WriteLine($"tr6 equals to tr7 : {tr6.Equals(tr7)}");

            ReadLine();
        }
    }
}