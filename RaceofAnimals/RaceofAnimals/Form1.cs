using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceofAnimals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tavsansoluzaklik, kedisoluzaklik, salyongozsoluzaklik, dinsoluzaklik, kopeksoluzaklik;

        Random rastgele=new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tavsansoluzaklik = pictureBox1.Left;
            kedisoluzaklik = pictureBox2.Left;
            salyongozsoluzaklik = pictureBox3.Left;
            dinsoluzaklik = pictureBox4.Left;
            kopeksoluzaklik = pictureBox5.Left;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tavsangenislik = pictureBox1.Width;
            int kedigenislik = pictureBox2.Width;
            int salyongozgenislik = pictureBox3.Width;
            int dingenislik = pictureBox4.Width;
            int kopekgenislik = pictureBox5.Width;

            int bitisuzaklık = label6.Left;
            
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(1, 20);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(1, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(1, 20);
            pictureBox4.Left = pictureBox4.Left + rastgele.Next(1, 20);
            pictureBox5.Left = pictureBox5.Left + rastgele.Next(1, 20);

            if(pictureBox1.Left > pictureBox2.Left+ 5 && pictureBox1.Left > pictureBox3.Left +5 && pictureBox1.Left > pictureBox4.Left+5 && pictureBox1.Left > pictureBox5.Left+5)
            {
                label7.Text = "Tavşan yarışı önde götürüyor.";

            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5 && pictureBox2.Left > pictureBox4.Left + 5 && pictureBox2.Left > pictureBox5.Left + 5)
            {
                label7.Text = "Kedi yarışı önde götürüyor.";

            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox4.Left + 5 && pictureBox3.Left > pictureBox5.Left + 5)
            {
                label7.Text = "Salyangoz yarışı önde götürüyor.";

            }
            if (pictureBox4.Left > pictureBox2.Left + 5 && pictureBox4.Left > pictureBox3.Left + 5 && pictureBox4.Left > pictureBox1.Left + 5 && pictureBox1.Left > pictureBox5.Left + 5)
            {
                label7.Text = "Dinazor yarışı önde götürüyor.";

            }
            if (pictureBox5.Left > pictureBox2.Left + 5 && pictureBox5.Left > pictureBox3.Left + 5 && pictureBox5.Left > pictureBox4.Left + 5 && pictureBox5.Left > pictureBox1.Left + 5)
            {
                label7.Text = "Köpek yarışı önde götürüyor.";

            }



            if(tavsangenislik + pictureBox1.Left >= bitisuzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tavşan Yarışı Kazandı.");
            }
            if (kedigenislik + pictureBox2.Left >= bitisuzaklık) 
            {
                timer1.Enabled = false;
                MessageBox.Show("Kedi Yarışı Kazandı.");
            }
            if (salyongozgenislik + pictureBox3.Left >= bitisuzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("Salyangoz Yarışı Kazandı.");
            }
            if(dingenislik+pictureBox4.Left >= bitisuzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("Dinazor Yarışı Kazandı.");
            }
            if(kopekgenislik+pictureBox5.Left >= bitisuzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("Köpek Yarışı Kazandı.");
            }
        }
        
    }
}
