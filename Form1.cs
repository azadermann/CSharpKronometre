using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpKronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        int sıra = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Text = " ";
            timer1.Enabled = false;
            timer1.Interval = 1000;
            AraZamanButton.Enabled = false;
        }

        private void BaslatButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            AraZamanButton.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label2.Text = sayac.ToString();
        }

        private void AraZamanButton_Click(object sender, EventArgs e)
        {
            sıra++;
            if (sayac == 10)
            {
                timer1.Enabled = false;

            }
            listBox1.Items.Add(sıra + ". Tur > " + label2.Text);


        }

        private void DurdurButton_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            listBox1.Items.Add(sıra + 1 + " Durdurulan Tur > " + label2.Text);
        }

        private void SıfırlaButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            sayac = 0;
            sıra = 0;
            label2.Text = "0";
            AraZamanButton.Enabled = false;
        }
    }
}
