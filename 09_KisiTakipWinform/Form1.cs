using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_KisiTakipWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            textBoxName.Text = "ibrahim";
            textBoxSurname.Text = "Yazıcı";
            

        }

        private void btnSelamla_Click(object sender, EventArgs e)
        {
            string selamStr = $"Merhaba {textBoxName.Text} {textBoxSurname.Text}";
            textBoxSonuc.Text = selamStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBoxSayi1.Text);
            int sayi2= Convert.ToInt32(textBoxSayi2.Text);
            var result = sayi1 + sayi2;
            textBoxToplam.Text = result.ToString();

        }
    }
}
