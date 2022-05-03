using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçak_Bilet_Rezervasyon_Siztemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("Rota: " + comboBox1.Text + "-" + comboBox2.Text);
            listBox1.Items.Add("Tarih: " + dateTimePicker1.Text + "-" +"Saat: "+ maskedTextBox1.Text);
            listBox1.Items.Add("Yolcu Bilgileri: " + textBox1.Text + " " + maskedTextBox2.Text + " " + maskedTextBox3.Text);
            MessageBox.Show("İşlem Başarıyla Kaydedildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
