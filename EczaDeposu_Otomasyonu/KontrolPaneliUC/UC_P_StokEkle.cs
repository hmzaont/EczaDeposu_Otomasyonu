using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaDeposu_Otomasyonu.KontrolPaneliUC
{
    public partial class UC_P_StokEkle : UserControl
    {
        fonksiyon fn = new fonksiyon();
        String sorgu;

        public UC_P_StokEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtStokID.Text != "" && txtStokAdi.Text != "" && txtBarkodNo.Text != "" && txtMiktar.Text != "" && txtBirimFiyat.Text != "")
            {
                String stokID= txtStokID.Text;
                String stokAdi= txtStokAdi.Text;
                String barkodNo= txtBarkodNo.Text;
                String uretimTarihi= dtpUretimTarihi.Text;
                String sonKullanmaTarihi=dtpSonKullanmaTarihi.Text;
                Int64 miktar = Int64.Parse(txtMiktar.Text);
                Int64 birimFiyat=Int64.Parse(txtBirimFiyat.Text);

                sorgu = "insert into stok (stokid,stokadi,barkodno,uretimtarihi,sonkullanmatarihi,miktar,birimfiyat) values ('" + stokID+"','"+stokAdi+"','"+barkodNo+ "','" + uretimTarihi + "','" + sonKullanmaTarihi + "','" + miktar + "','" + birimFiyat +"')";
                fn.setData(sorgu, "Stok, veri tabanina eklendi.");

            }
            else
                MessageBox.Show("Tum verileri giriniz.", "Uyari!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        public void Temizle()
        {
            txtStokID.Clear();
            txtStokAdi.Clear();
            txtBarkodNo.Clear();
            txtMiktar.Clear();
            dtpUretimTarihi.ResetText();
            dtpSonKullanmaTarihi.ResetText();
            txtBirimFiyat.Clear();
            txtBirimFiyat.Clear();
        }
    }
}
