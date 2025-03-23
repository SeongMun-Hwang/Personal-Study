using System;
using System.Windows.Forms;

namespace Program
{
    class MainApp : Form
    {
        //p740
        static void Main(string[] args)
        {
            MainApp form=new MainApp();
            form.Width = 400;
            form.MouseDown += new MouseEventHandler(form_MouseDown);
            Application.Run(form);
        }
        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            Form form=(Form)sender;
            if(e.Button== MouseButtons.Left )
            {
                form.MaximizeBox = true;
                form.MinimizeBox = true;
                form.Text = "Maximize/Minimize button activated";
            }
            else if(e.Button==MouseButtons.Right )
            {
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.Text = "Maximize/Minimize button disabled";
            }
        }
    }
}