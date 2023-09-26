using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace not_hesaplama
{
    public partial class btnHesapla : Form
    {
        public btnHesapla()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesaplama_Click(object sender, EventArgs e)
        {
            
            int not1, not2;
            double sonuc;

            not1 = Convert.ToInt32(txtNot1.Text);
            not2 = Convert.ToInt32(txtNot2.Text);

            sonuc = (not1 + not2) / 2;

            lblSonuc.Text = sonuc.ToString();
        }
    }
}
