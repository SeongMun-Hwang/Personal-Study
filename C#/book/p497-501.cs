using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    //p497
    delegate void Evenethandler(string message);
    class MyNotifier
    {
        public event Evenethandler SomethingHappened;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
                SomethingHappened(String.Format("{0} : 짝", number));
        }
    }
    //p500
    delegate int MyDelegate(int a, int b);
    //p501
    delegate void MyDelegate2(int a);
    class Market
    {
        public event MyDelegate2 CustomerEvent;
        public void BuySomething(int CustomerNo)
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);
        }
    }
    class MainApp
    {    
        static public void MyHandeler(string message)
        {
            WriteLine(message);
        }
        static void Main(string[] args)
        {
            //p497
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new Evenethandler(MyHandeler);
            for(int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
            WriteLine();

            //p500
            MyDelegate Callback;
            Callback = delegate (int a, int b)
            {
                return a + b;
            };
            WriteLine(Callback(3, 4));

            Callback = delegate (int a, int b)
            {
                return a - b;
            };
            WriteLine(Callback(7, 5));
            WriteLine();

            //p501
            Market market = new Market();
            market.CustomerEvent += new MyDelegate2(delegate(int customerNo)
            {
                WriteLine($"축하합니다! {customerNo}번째 고객 이벤트에 당첨되셨습니다!");
            });
            for(int customerNo=0; customerNo<100; customerNo+=10)
                market.BuySomething(customerNo);

            ReadLine();
        }
    }
}