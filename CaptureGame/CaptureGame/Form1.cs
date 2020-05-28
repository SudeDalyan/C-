using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x, y, score;
        int time = 100;

        Random number = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = number.Next(0, 700);
            y = number.Next(0, 500);
            pictureBox1.Location = new System.Drawing.Point(x, y);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score = score + 1;
            label4.Text = score.ToString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time--;
            label3.Text = time.ToString();
            if(time==0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;

            }

        }

    }
}
