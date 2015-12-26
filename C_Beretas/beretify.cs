using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace C_Beretas
{
    public partial class beretify : Form
    {
        int times = 0;
        int aggle = 1;
        public beretify()
        {
            InitializeComponent();
        }

        private void beretify_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.Left -= rnd.Next(10, 100);

              (new Thread(() =>
               {
                    for (int i = 0; i <= 100; i++)
                    {
                        
                        pictureBox1.Image = Properties.Resources.b_albanian;
                        System.Threading.Thread.Sleep(200);
                        pictureBox1.Image = Properties.Resources.b_smiley;
                        System.Threading.Thread.Sleep(200);
                    }
              })).Start();    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (times < 180)
            {
                this.Left += 50;
            }
            else if (times > 180)
            {
                this.Left -= 50;
            }
            this.Top += aggle;

        }

        private void timesss_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            times += 5;
            if (times > 360)
            {
                times = 0;
                aggle = aggle * rnd.Next(1, 10);
            }
            if (this.Top > 1000)
            {
                aggle = -2 * rnd.Next(1, 10);
            }
            if (this.Top < 0)
            {
                aggle = +2 * rnd.Next(1, 10);
            }

            if (this.Top == 560)
            {
                aggle = +5 * rnd.Next(1, 10);
            }

            if (times < 180)
            {
                this.Left += 50;
            }
            else if (times > 180)
            {
                this.Left -= 50;
            }
            this.Top += aggle;
        }
    }
}
