using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EczaDeposu_Otomasyonu
{
    public partial class frmGirisPaneli : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public frmGirisPaneli()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl=new BaglantiSinif();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullaniciAdi.Text;
            string sifre=txtSifre.Text;
            con = new SqlConnection(bgl.Adres);
            com = new SqlCommand();
            con.Open();
            com.Connection= con;
            com.CommandText = "SELECT * FROM giris WHERE kullaniciadi='" + txtKullaniciAdi.Text + "' AND sifre='" + txtSifre.Text + "'";
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı!");
                KontrolPaneli kp = new KontrolPaneli();
                kp.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kullanıcı adı veya şifre hatalı! Tekrar deneyin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
        }

        private void lblSifreHatirla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum forgot=new SifremiUnuttum();
            forgot.Show();
        }

        private void frmGirisPaneli_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © 2023 Hamza ONAT. Tüm Hakları Saklıdır.", "Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
