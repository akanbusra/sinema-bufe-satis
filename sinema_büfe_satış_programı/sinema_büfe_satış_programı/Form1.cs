using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_büfe_satış_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        int kasa=0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, çay, su, bilet, toplam;

            mısır = Convert.ToInt16(txtmısır.Text) ;
            çay = Convert.ToInt16(txtçay.Text);
            su = Convert.ToInt16(txtsu.Text);
            bilet = Convert.ToInt16(txtbilet.Text);

            toplam = mısır * 4 + çay * 1 + su * 2 + bilet * 8;
            labeltoplam.Text = toplam.ToString();

            kasa = kasa + toplam;
            labelkasa.Text = kasa.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbilet.Text = "";
            txtmısır.Text = "";
            txtsu.Text = "";
            txtçay.Text = "";
            txtmısır.Focus();
        }
    }
}
