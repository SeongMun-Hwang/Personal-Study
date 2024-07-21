using System;
using System.Windows.Forms;

namespace Program
{
    class MainApp : Form
    { 
        static void Main(string[] args)
        {
            //p734
            MainApp form=new MainApp();
            form.Width = 300;
            form.Height = 200;

            form.MouseDown += new MouseEventHandler(form_MouseDown);
            Application.Run(form);
        }
        static void form_MouseDown(object sender, MouseEventArgs e) { 
            Form form= (Form)sender;
            int oldWidth=form.Width;
            int oldHeight=form.Height;

            if(e.Button == MouseButtons.Left)
            {
                if (oldWidth < oldHeight)
                {
                    form.Width = oldHeight;
                    form.Height=oldWidth;
                }
            }
            //p735
            else if(e.Button== MouseButtons.Right)
            {
                if (oldHeight < oldWidth)
                {
                    form.Width = oldHeight;
                    form.Height = oldWidth;
                }
            }
            Console.WriteLine("Window size had changed");
            Console.WriteLine($"Width : {form.Width}, Height : {form.Height}");
        }
    }
}