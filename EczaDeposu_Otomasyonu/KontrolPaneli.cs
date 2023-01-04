using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaDeposu_Otomasyonu
{
    public partial class KontrolPaneli : Form
    {
        public KontrolPaneli()
        {
            InitializeComponent();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            frmGirisPaneli kgp = new frmGirisPaneli();
            kgp.Show();
            this.Hide();
        }

        private void btnGostergePaneli_Click(object sender, EventArgs e)
        {
            uC_P_KontrolPaneli1.Visible= true;
            uC_P_KontrolPaneli1.BringToFront();
        }

        private void KontrolPaneli_Load(object sender, EventArgs e)
        {
            uC_P_KontrolPaneli1.Visible= false;
            uC_P_StokEkle1.Visible= false;
            uC_P_StokMiktariniGoster1.Visible= false;
            uC_P_StoguGuncelle1.Visible = false;
            uC_P_StokGecerlilikKontrolu1.Visible= false;
            uC_P_SatisYap1.Visible= false;
            btnKontrolPaneli.PerformClick();
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            uC_P_StokEkle1.Visible= true;
            uC_P_StokEkle1.BringToFront(); 
        }

        private void btnStokGoster_Click(object sender, EventArgs e)
        {
            uC_P_StokMiktariniGoster1.Visible= true;
            uC_P_StokMiktariniGoster1.BringToFront();
        }

        private void btnStoguGuncelle_Click(object sender, EventArgs e)
        {
            uC_P_StoguGuncelle1.Visible = true;
            uC_P_StoguGuncelle1.BringToFront();
        }

        private void btnGecerlilikKontrol_Click(object sender, EventArgs e)
        {
            uC_P_StokGecerlilikKontrolu1.Visible= true;
            uC_P_StokGecerlilikKontrolu1.BringToFront();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            uC_P_SatisYap1.Visible = true;
            uC_P_SatisYap1.BringToFront() ;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2023 Hamza ONAT. Tüm Hakları Saklıdır.", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void uC_P_SatisYap1_Load(object sender, EventArgs e)
        {

        }
    }
}
