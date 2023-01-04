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
    public partial class UC_P_StokGuncelle : UserControl
    {
        fonksiyon fn=new fonksiyon();
        String sorgu;
        public UC_P_StokGuncelle()
        {
            InitializeComponent();
        }

        private void UC_P_StoguGuncelle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtStokID.Text != "")
            {
                sorgu = "select * from stok where stokid = '" + txtStokID.Text + "'";
                DataSet ds = fn.getData(sorgu);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtStokIsmi.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtBarkodNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    dtpUretimTarihi.Text = ds.Tables[0].Rows[0][4].ToString();
                    dtpSonKullanmaTarihi.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtMevcutMiktar.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtBirimFiyat.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                    MessageBox.Show("Girdiginiz ID'ye ( " + txtStokID.Text + " ) sahip stok bulunamadi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                hepsiniTemizle();
            }
        }
        
        private void hepsiniTemizle()
        {
            txtStokID.Clear();
            txtStokIsmi.Clear();
            txtBarkodNo.Clear();
            dtpUretimTarihi.ResetText();
            dtpSonKullanmaTarihi.ResetText();
            txtMevcutMiktar.Clear();
            txtBirimFiyat.Clear();

            if(txtMiktarEkle.Text != "0")
            {
                txtMiktarEkle.Text= "0";
            }
            else
            {
                txtMiktarEkle.Text= "0";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            hepsiniTemizle();
        }

        Int64 toplamMiktar;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            String stokAdi = txtStokIsmi.Text;
            String barkodNo= txtBarkodNo.Text;
            String uretimTarihi = dtpUretimTarihi.Text;
            String sonKullanmaTarihi = dtpSonKullanmaTarihi.Text;
            Int64 miktar = Int64.Parse(txtMevcutMiktar.Text);
            Int64 miktarEkle = Int64.Parse(txtMiktarEkle.Text);
            Int64 birimFiyat = Int64.Parse(txtBirimFiyat.Text);

            toplamMiktar = miktar + miktarEkle;

            sorgu = "update stok set stokadi = '" + stokAdi + "',barkodno = '" + barkodNo + "',uretimtarihi = '" + uretimTarihi + "',sonkullanmatarihi = '" + sonKullanmaTarihi + "',miktar = " + toplamMiktar + ",birimfiyat = " + birimFiyat + " where stokid = '"+txtStokID.Text+"' ";
            fn.setData(sorgu, "Stok Bilgileri Guncellendi.");
        }
    }
}
