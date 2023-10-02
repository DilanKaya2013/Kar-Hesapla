using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kar_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKarhesapla_Click(object sender, EventArgs e)
        {
            double satisFiyati, alısFiyati;
            satisFiyati=Convert.ToDouble(txtSatisfiyati.Text);
            alısFiyati = Convert.ToDouble(txtAlisfiyat.Text);
            double karHesapla = alısFiyati-satisFiyati;
            lblToplamkar.Text = "kar hesapla: " + karHesapla;

        }
    }
}
