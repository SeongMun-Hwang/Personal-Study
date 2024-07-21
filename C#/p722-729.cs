using System;
using System.Windows.Forms;

namespace Program
{
    class MyForm : System.Windows.Forms.Form
    {

    }
    //p728
    class MessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x0F || m.Msg == 0xA0 || m.Msg == 0x200 || m.Msg == 0x113)
            {
                return false;
            }
            if (m.Msg == 0x201)
            {
                Application.Exit();
            }
            return true;
        }
    }
    class MainApp : Form
    { 
        static void Main(string[] args)
        {
            //p722
            Application.Run(new MainApp());

            //p724
            MainApp form = new MainApp();
            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Console.WriteLine("Closing window..");
                    Application.Exit();
                });

            Console.WriteLine("Starting window Application...");
            Application.Run(form);

            Console.WriteLine("Exiting window Application...");

            //p729
            Application.AddMessageFilter(new MessageFilter());
            Application.Run(new MainApp());
        }
    }
}