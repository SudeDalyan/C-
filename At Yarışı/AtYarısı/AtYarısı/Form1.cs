using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsoluzaklik, ikinciatsoluzaklik, ucuncuatsoluzaklik;
        Random rst = new Random();


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsoluzaklik = pictureBox1.Left;
            ikinciatsoluzaklik = pictureBox2.Left;
            ucuncuatsoluzaklik = pictureBox3.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;


            pictureBox1.Left = pictureBox1.Left + rst.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rst.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rst.Next(5, 15);
           
            if ( pictureBox1.Left > 700 || pictureBox2.Left > 700 || pictureBox3.Left > 700 )
            {
                timer1.Enabled = false;
            }

            if (pictureBox1.Left >= 700)
            {
                MessageBox.Show("KAZANAN 1 NUMARALI AT");
            }
            if (pictureBox2.Left >= 700)
            {
                MessageBox.Show("KAZANAN 2 NUMARALI AT");
            }
            if (pictureBox3.Left >= 700)
            {
                MessageBox.Show("KAZANAN 3 NUMARALI AT");
            }
        }
    }
}
