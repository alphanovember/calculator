using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorv2
{
    public partial class Form1 : Form
    {
        public string islem = String.Empty;
        public double sayi1 = 0;
        public Form1()
        {
            InitializeComponent();

        }
        private void Ekle(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Islem(object sender, EventArgs e)
        {
            islem = (sender as Button).Text;
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text =String.Empty;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            islem = String.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double sayi2 = Convert.ToDouble(textBox1.Text);

            double sonuc = 0;
            calculations islemler = new calculations();

            switch (islem)
            {
                case "+":
                    sonuc = islemler.add(sayi1, sayi2);
                    break;
                case "-":
                    sonuc = islemler.sub(sayi1, sayi2);
                    break;
                case "*":
                    sonuc = islemler.mul(sayi1, sayi2);
                    break;
                case "/":
                    sonuc = islemler.div(sayi1, sayi2);
                    break;
                default:
                    MessageBox.Show("İşlem seçmelisiniz!", "Hata");
                    break;
            }
           textBox1.Text = sonuc.ToString();
        }
    }
}
