using static System.Console;

namespace CsConsole
{
    //p352
    class Transaction
    {
        //init 접근자 : 프로퍼티를 변경할 수 있지만, 초기화시만 가능
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }
        public override string ToString()
        {
            return $"{From,-10}->{To,-10} : ${Amount}";
        }
    }
    //354
    class BirthdayInfo
    {
        public required string Name { get; set; }
        public required DateTime Birthday { get; init; }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            //352
            Transaction tr1 = new Transaction {From="Alice",To="bob",Amount=100 };
            Transaction tr2 = new Transaction {From= "bob", To="Chalie",Amount=50 };
            Transaction tr3 = new Transaction {From= "Chalie", To="Alice",Amount=50 };

            WriteLine(tr1);
            WriteLine(tr2);
            WriteLine(tr3);
            WriteLine();

            //355
            BirthdayInfo birth = new BirthdayInfo() { Name = "Hwang", Birthday = new DateTime(1999, 12, 23) };
            WriteLine("Name : {0}", birth.Name);
            WriteLine("Birthday : {0}",birth.Birthday.ToShortDateString());
            WriteLine("Age : {0}", birth.Age);

            ReadLine();
        }
    }
}