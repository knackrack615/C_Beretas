using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_Beretas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal times = numericUpDown1.Value;
            c_beretas_coding(times);
            webBrowser1.Navigate("https://www.youtube.com/watch?v=KMU0tzLwhbE");
        }

        public void c_beretas_coding(decimal times)
        {
            Screen myScreen = Screen.PrimaryScreen;
            int mywith = (myScreen.WorkingArea.Width);
            int myheight = (myScreen.WorkingArea.Height);
            int get_times = Convert.ToInt32(times);
            Random rnd = new Random();

            for (int i = 1; i <= get_times; i++ )
            {
                int newwidth = rnd.Next(0, mywith);
                int newheight = rnd.Next(0, myheight);
                beretify Box = new beretify();
                Box.Location = new Point(mywith, myheight);
                Box.Show();
                System.Threading.Thread.Sleep(100);
            }
            
        }
    }
}
