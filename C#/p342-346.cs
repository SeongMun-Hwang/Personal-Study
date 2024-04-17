using static System.Console;

namespace CsConsole
{
    //p342
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    //346
    class CardInfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get { 
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; 
            }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            //343
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "Hwang";
            birth.Birthday = new DateTime(1999, 12, 23);
            WriteLine($"Name : {birth.Name}");
            WriteLine($"BirthDay : {birth.Birthday.ToShortDateString()}");
            WriteLine($"Age : {birth.Age}");
            WriteLine();

            //346
            CardInfo card = new CardInfo();
            WriteLine($"Name : {card.Name}");
            WriteLine($"Birthday : {card.Birthday.ToShortDateString()}");
            WriteLine($"Age : {card.Age}");

            card.Name = "Sin";
            card.Birthday = new DateTime(1977, 9, 11);
            WriteLine($"Name : {card.Name}");
            WriteLine($"Birthday : {card.Birthday.ToShortDateString()}");
            WriteLine($"Age : {card.Age}");

            ReadLine();
        }
    }
}