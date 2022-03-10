using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tutar = 0;
            if (checkBox1.Checked)
                tutar += 4;
            if (checkBox2.Checked)
                tutar += 8;
            if (checkBox3.Checked)
                tutar += 7;
            if (checkBox4.Checked)
                tutar += 7;
            if (checkBox5.Checked)
                tutar += 3;
            label1.Text = "Ödeyeceğiniz tutar : " + tutar;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double fiyat = double.Parse(textBox1.Text);
                double tutar = 0;
                if (radioButton1.Checked)
                    tutar = fiyat - fiyat * 20 / 100;
                if (radioButton2.Checked)
                    tutar = fiyat - fiyat * 30 / 100;
                label3.Text = "Ödenecek tutar : " + tutar + "TL";
                if (tutar <= 0)
                    label3.Text = "Girilen Tutar 0 dan küçük olamaz.";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hatalı işlem. Hata : " + hata.Message);
            }



        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                groupBox2.Visible = true;
            else
                groupBox2.Visible = false;

        }
    }
}
