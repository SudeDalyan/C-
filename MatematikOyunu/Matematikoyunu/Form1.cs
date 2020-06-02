using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematikoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sy1, sy2, sy3;
        int islem, s4, s5, s6;
        int puan = 0;

        private void basla()
        {
            Random rnd = new Random();
            sy1 = rnd.Next(0, 30);
            sy2 = rnd.Next(0, 30);
            islem = rnd.Next(0, 4);
            s4 = rnd.Next(0, 3);
            s5 = rnd.Next(Convert.ToInt32(sy3 - 1), Convert.ToInt32(sy3 + 1));
            s6 = rnd.Next(Convert.ToInt32(sy3 - 1), Convert.ToInt32(sy3 + 1));


            label2.Text = sy1.ToString();
            label4.Text = sy2.ToString();

            if(islem==0)
            {
                label3.Text="+";
                sy3 = sy1 + sy2;
                label6.Text = sy3.ToString();               

            }
            if(islem==1)
            {
                label3.Text="-";
                sy3 = sy1 - sy2;
                label6.Text = sy3.ToString();
                
            }
            if(islem==2)
            {
                label3.Text="/";
                sy3 = sy1 / sy2;
                label6.Text = sy3.ToString();
              
            }
            if(islem==3)
            {
                label3.Text = "x";
                sy3 = sy1 * sy2;
                label6.Text = sy3.ToString();               
            }
        

            if(s4==0)
            {
                button1.Text = sy3.ToString();
                button2.Text = s5.ToString();
                button3.Text = s6.ToString();


            }
            if(s4==1)
            {
                button2.Text = sy3.ToString();
                button3.Text = s5.ToString();
                button1.Text = s6.ToString();
            }
            if(s4==2)
            {
                button3.Text = sy3.ToString();
                button1.Text = s5.ToString();
                button2.Text = s6.ToString();
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            basla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text==sy3.ToString())
            {
                puan = puan + 10;
                MessageBox.Show("Kazandınız" + sy3.ToString());
                label8.Text = puan.ToString();
                
            }
            else
            {
                puan = puan - 10;
                MessageBox.Show("Kaybettiniz" + sy3.ToString());
                label8.Text = puan.ToString();
            }
            basla();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == sy3.ToString())
            {
                puan = puan + 10;
                MessageBox.Show("Kazandınız" + sy3.ToString());
                label8.Text = puan.ToString();

            }
            else
            {
                puan = puan - 10;
                MessageBox.Show("Kaybettiniz" + sy3.ToString());
                label8.Text = puan.ToString();
            }
            basla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == sy3.ToString())
            {
                puan = puan + 10;
                MessageBox.Show("Kazandınız" + sy3.ToString());
                label8.Text = puan.ToString();

            }
            else
            {
                puan = puan - 10;
                MessageBox.Show("Kaybettiniz" + sy3.ToString());
                label8.Text = puan.ToString();
            }
            basla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler Puanınız :" + puan.ToString());

        }


    }
}
