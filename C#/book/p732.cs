using System;
using System.Windows.Forms;

namespace Program
{
    class MainApp : Form
    { 
        //p732
        public void MyMouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Sender : {((Form)sender).Text}");
            Console.WriteLine($"X:{e.X}, Y:{e.Y}");
            Console.WriteLine($"Button:{e.Button}, Clicks:{e.Clicks}");
            Console.WriteLine();
        }
        public MainApp(string title)
        {
            this.Text=title;
            this.MouseDown += new MouseEventHandler(MyMouseHandler);
        }
        static void Main(string[] args)
        {
            Application.Run(new MainApp("Mouse Event Text"));
        }
    }
}