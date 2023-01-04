using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace EczaDeposu_Otomasyonu
{
    public partial class SifremiUnuttum : Form
    {
        SqlConnection baglan;
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();
        private void btnSifreyiGonder_Click(object sender, EventArgs e)
        {
            string k_adi = txtKullaniciAdi.Text;
            string eposta = txtEposta.Text;
            baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from giris", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (k_adi == oku["kullaniciadi"].ToString() && eposta == oku["email"].ToString())
                {
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String mailadresim = ("mail_adresi_giriniz!");
                    String sifre = ("mail_adresinin_sifresini_giriniz.");
                    String smtpsrvr = "smtp-mail.outlook.com";
                    String kime = (oku["email"].ToString());
                    String konu = ("Şifre Hatırlatma");
                    String yaz = ("Şifreniz: " + oku["sifre"].ToString());
                    smtpserver.Credentials = new NetworkCredential(mailadresim, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresim);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);

                    MessageBox.Show("Şifreniz, sistemde kayıtlı olan e-posta adresinize gönderildi.");
                    this.Hide();
                }
                else
                    MessageBox.Show("Kullanıcı adı ve e-posta eşleşmiyor.");
            }
            baglan.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
