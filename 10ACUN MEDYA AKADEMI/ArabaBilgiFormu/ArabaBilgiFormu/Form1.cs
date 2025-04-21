using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaBilgiFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Convert.ToString(textBox1.Text);
            Convert.ToString(textBox2.Text);
            Convert.ToString(textBox3.Text);
            Convert.ToString(textBox4.Text);
            Convert.ToString(textBox5.Text);
            Convert.ToString(textBox6.Text);


            MessageBox.Show("Araba Bilgileri:\n" +
                "Marka: " + textBox1.Text + "\n" +
                "Model: " + textBox2.Text + "\n" +
                "Yıl: " + textBox3.Text + "\n" +
                "Renk: " + textBox4.Text + "\n" +
                "Motor Hacmi: " + textBox5.Text + "\n" +
                "100 km’de Yaktığı Yakıt (Litre): " + textBox6.Text);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
