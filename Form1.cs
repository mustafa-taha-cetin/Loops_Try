using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Döngüler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            
            for (i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i + ". break point");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam, i;
            toplam = 0;
            for (i = 1; i < 11; i++)
            {
                toplam = toplam + i;
                label1.Text = "sonuç = " + toplam;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam, i;
            toplam = 0;
            for (i = 0; i < 11; i+=2)
            {
                toplam = toplam + i;
                label2.Text = "çift sayıların toplamı " + toplam;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    listBox2.Items.Add(i + " sayısı ikiye bölündü");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(maskedTextBox1.Text);
            for (int i = 1; i < 1000; i++)
            {
                if(sayi % i == 0)
                {
                    listBox3.Items.Add(i + " sayısına tam bölünür");
                }
            }
        }
    }
}
