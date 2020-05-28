using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureGame2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a, b, score;
        int time= 120;
        Random number = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score = score + 5;
            label3.Text = score.ToString();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            score = score + 1;
            label3.Text = score.ToString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = number.Next(70, 800);
            b = number.Next(70, 800);
            pictureBox1.Location = new System.Drawing.Point(a, b);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            a = number.Next(70, 600);
            b = number.Next(70, 600);
            pictureBox2.Location = new System.Drawing.Point(a, b);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            time--;
            label4.Text = time.ToString();

            if(time==0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
               
                label5.Text = score.ToString();
                score = 0;
                label3.Text = score.ToString();
                
                
            }
        }

    }
}
