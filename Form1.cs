using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alışveriş_indirim_tutarı__ıf_else_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitap;
            double toplam;
           kitap = Convert.ToInt32(textBox1.Text);
            
            if (kitap>=0 && kitap<=20)
            {
                toplam = (kitap * 8) - (kitap *  8 * 0.2);
                label3.Text = toplam + " TL ";
            }
            else if (kitap>20 && kitap<=40 )
            {
                toplam = (kitap * 8) - (kitap * 8 * 0.4);
                label3.Text = toplam + " TL ";
            }
            else if (kitap > 40 && kitap <= 100)
            {
                toplam = (kitap * 8) - (kitap * 8 * 0.5);
                label3.Text = toplam + " TL ";
            }
            else
            {
               label3.Text= "Stokta bu kadar Ürün malesef mevcut degil :( ";
            }
        }
    }
}
