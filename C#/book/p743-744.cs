using System;
using System.Windows.Forms;

namespace Program
{
    class MainApp : Form
    {
        //p743
        static void Main(string[] args)
        {
            Button button=new Button();

            button.Text = "Click Me!";
            button.Left = 100;
            button.Top = 50;

            //p744
            button.Click+=(object sender, EventArgs e)=>{
                MessageBox.Show("Clicked!");
            };

            MainApp form=new MainApp();
            form.Text = "Form & Control";
            form.Height = 150;

            form.Controls.Add(button);
            Application.Run(form);
        }
    }
}