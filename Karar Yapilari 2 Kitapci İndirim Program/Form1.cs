using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari_2_Kitapci_İndirim_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 kitapadet;
            double toplam;
            kitapadet = Convert.ToInt32(textBox3.Text);
            if (kitapadet > 0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 10) - (kitapadet * 10 * 0.20);
                label2.Text = toplam + "Tl";
            }
            if (kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 10) - (kitapadet * 10 * 0.40);
                label2.Text = toplam + "Tl";
            }
            if (kitapadet >= 41)
            {
                toplam = (kitapadet * 10) - (kitapadet * 10 * 0.50);
                label2.Text = toplam + "Tl:";
            }

        }
    }
}
    //KİTAPFİYAT 10