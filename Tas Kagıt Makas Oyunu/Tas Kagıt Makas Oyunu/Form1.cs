using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tas_Kagıt_Makas_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd=new Random();
        int puan1,puan2;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (rnd.Next(3))
            {
                case 0:
                    pictureBox1.Visible=true;
                    pictureBox2.Visible=false;
                    pictureBox3.Visible=false;
                    break;

                case 1:

                    pictureBox1.Visible=false;
                    pictureBox2.Visible=true;
                    pictureBox3.Visible=false;
                    break;

                case 2:
                    pictureBox1.Visible=false;
                    pictureBox2.Visible=false;
                    pictureBox3.Visible=true;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (rnd.Next(3))
            {
                case 0:
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox4.Visible = false;
                    break;

                case 1:

                    pictureBox5.Visible = false;
                    pictureBox6.Visible = true;
                    pictureBox4.Visible = false;
                    break;

                case 2:
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox4.Visible = true;
                    break;
            }
            again();

        }
        private void again()
        {

            if (pictureBox1.Visible == true & pictureBox4.Visible == true)
            {
                MessageBox.Show("Taş makası kırar. Birinci oyuncu kazandı");
                puan1 = puan1 + 10;
                puan2 = puan2 - 10;
            }
            if (pictureBox1.Visible == true & pictureBox5.Visible == true)
            {
                MessageBox.Show("Kağıt taşı sarar. İkinci oyuncu kazandı");
                puan2 = puan2 + 10;
                puan1 = puan1 - 10;
            }
            if (pictureBox2.Visible == true & pictureBox6.Visible == true)
            {
                MessageBox.Show("Kağıt taşı sarar. Birinci oyuncu kazandı");
                puan1 = puan1 + 10;
                puan2 = puan2 - 10;
            }
            if (pictureBox2.Visible == true & pictureBox4.Visible == true)
            {
                MessageBox.Show("Makas kağıdı keser. İkinci oyuncu kazandı");
                puan2 = puan2 + 10;
                puan1 = puan1 - 10;
            }
            if (pictureBox3.Visible == true & pictureBox5.Visible == true)
            {
                MessageBox.Show("Makas kağıdı keser. Birinci oyuncu kazandı");
                puan1 = puan1 + 10;
                puan2 = puan2 - 10;
            }
            if (pictureBox3.Visible == true & pictureBox6.Visible == true)
            {
                MessageBox.Show("Taş makası kırar. İkinci oyuncu kazandı");
                puan2 = puan2 + 10;
                puan1 = puan1 - 10;
            }
            if(pictureBox1.Visible==true & pictureBox6.Visible==true || pictureBox2.Visible==true & pictureBox5.Visible==true || pictureBox3.Visible==true & pictureBox4.Visible==true)
            {
                MessageBox.Show("Berabere kaldınız. Tekrar deneyiniz.");
            }
            label3.Text = puan1.ToString();
            label4.Text = puan2.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

    }

  
}
