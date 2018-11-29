using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yerine_Koyma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_anahtarolustur_Click(object sender, EventArgs e)
        {
            tx_anahtar.Text = "";
            while(tx_anahtar.TextLength < 26)
            {
                Random rastgele = new Random();
                char harf = (char)rastgele.Next(97, 123); //harf elde etme

                if (!(tx_anahtar.Text.Contains(harf)))
                {
                    tx_anahtar.Text += harf;
                }

            }
        }

        private void btn_sifrele_Click(object sender, EventArgs e)
        {
            tx_sirelimesaj.Text = "";
            for (int i = 0; i< tx_acikmesaj.TextLength; i++)
            {
                int yerine_koyma = tx_acikmesaj.Text[i] - 97;
                char sirelenen_harf = tx_anahtar.Text[yerine_koyma];
                tx_sirelimesaj.Text += sirelenen_harf;
            }
        }
    }
}
