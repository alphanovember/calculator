using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && radioButton1.Checked!=false || radioButton2.Checked != false || radioButton3.Checked != false || radioButton4.Checked != false)
            {

                double sayi1 = Convert.ToDouble(textBox1.Text);
                double sayi2 = Convert.ToDouble(textBox2.Text);
                double sonuc;

                if (radioButton1.Checked == true) // TOPLAMA
                {
                    sonuc = sayi1 + sayi2;
                    textBox3.Text = Convert.ToString(sonuc);
                }
                if (radioButton2.Checked == true) // ÇIKARMA
                {
                    sonuc = sayi1 - sayi2;
                    textBox3.Text = Convert.ToString(sonuc);
                }
                if (radioButton3.Checked == true) // BÖLME
                {
                    sonuc = sayi1 / sayi2;
                    textBox3.Text = Convert.ToString(sonuc);
                }
                if (radioButton4.Checked == true) // ÇARPMA
                {
                    sonuc = sayi1 * sayi2;
                    textBox3.Text = Convert.ToString(sonuc);

                }
            }
            else
                MessageBox.Show("LÜTFEN SAYILARI VEYA İŞLEM SEÇİMİNİZİ KONTROL EDİN!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}
