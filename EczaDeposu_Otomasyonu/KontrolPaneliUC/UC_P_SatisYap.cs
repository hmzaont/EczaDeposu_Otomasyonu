using DGVPrinterHelper;
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
    public partial class UC_P_SatisYap : UserControl
    {
        fonksiyon fn=new fonksiyon();
        String sorgu;
        DataSet ds;
        public UC_P_SatisYap()
        {
            InitializeComponent();
        }

        private void UC_P_SatisYap_Load(object sender, EventArgs e)
        {
            listBoxStokVerileri.Items.Clear();
            sorgu = "select stokadi from stok where miktar > '0'";
            ds =  fn.getData(sorgu);

            for(int i=0; i < ds.Tables[0].Rows.Count; i++) 
            {
                listBoxStokVerileri.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            UC_P_SatisYap_Load(this, null); 
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            listBoxStokVerileri.Items.Clear();
            sorgu = "select stokadi from stok where stokadi like '" + txtAra.Text + "%' and miktar > '0'";
            ds= fn.getData(sorgu);

            for(int i=0; i < ds.Tables[0].Rows.Count; i++) 
            {
                listBoxStokVerileri.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxStokVerileri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBirimSayisi.Clear();

            String isim = listBoxStokVerileri.GetItemText(listBoxStokVerileri.SelectedItem);

            txtStokAdi.Text = isim;
            sorgu = "select stokid,sonkullanmatarihi,birimfiyat from stok where stokadi = '" + isim + "'";
            ds = fn.getData(sorgu);
            txtStokID.Text = ds.Tables[0].Rows[0][0].ToString();
            dtpSonKullanmaTarihi.Text = ds.Tables[0].Rows[0][1].ToString();
            txtBirimFiyat .Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtToplamFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBirimSayisi_TextChanged(object sender, EventArgs e)
        {
            if (txtBirimSayisi.Text != "")
            {
                Int64 birimFiyat=Int64.Parse(txtBirimFiyat.Text);
                Int64 birimSayisi = Int64.Parse(txtBirimSayisi.Text);
                Int64 toplamMiktar = birimFiyat * birimSayisi;
                txtHesaplananFiyat.Text= toplamMiktar.ToString();
            }
            else
            {
                txtHesaplananFiyat.Clear();
            }
        }

        protected int n, toplamMiktar = 0;
        protected Int64 miktar, yeniMiktar;

        

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (txtStokID.Text != "")
            {
                sorgu = "select miktar from stok where stokid = '" + txtStokID.Text + "'";
                ds = fn.getData(sorgu);

                miktar = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                yeniMiktar = miktar - Int64.Parse(txtBirimSayisi.Text);

                if (yeniMiktar >= 0)
                {
                    n = TabloStok.Rows.Add();
                    TabloStok.Rows[n].Cells[0].Value = txtStokID.Text;
                    TabloStok.Rows[n].Cells[1].Value = txtStokAdi.Text;
                    TabloStok.Rows[n].Cells[2].Value = dtpSonKullanmaTarihi.Text;
                    TabloStok.Rows[n].Cells[3].Value = txtBirimFiyat.Text;
                    TabloStok.Rows[n].Cells[4].Value = txtBirimSayisi.Text;
                    TabloStok.Rows[n].Cells[5].Value = txtHesaplananFiyat.Text;

                    toplamMiktar = toplamMiktar + int.Parse(txtHesaplananFiyat.Text);
                    ToplamFiyat.Text = toplamMiktar.ToString() + "₺";

                    sorgu = "update stok set miktar = '" + yeniMiktar + "' where stokid = '" + txtStokID.Text + "'";
                    fn.setData(sorgu, "Stok Sepete Eklendi.");
                }
                else 
                {
                    MessageBox.Show("Stokta yok.\nSadece " + miktar + " adet kaldi.", "Uyari!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                hepsiniTemizle();
                UC_P_SatisYap_Load(this, null); 
            }
            else 
                MessageBox.Show("Stok Seciniz.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        int degerMiktari;
        String degerID;
        protected Int64 birimsayisi;

        

        private void TabloStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                degerMiktari = int.Parse(TabloStok.Rows[e.RowIndex].Cells[5].Value.ToString());
                degerID = TabloStok.Rows[e.RowIndex].Cells[0].Value.ToString();
                birimsayisi = Int64.Parse(TabloStok.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception ex) 
            {

            }
        }

        

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(degerID != null) 
            {
                try
                {
                    TabloStok.Rows.RemoveAt(this.TabloStok.SelectedRows[0].Index);
                }
                catch(Exception ex)
                {

                }
                finally
                {
                    sorgu = "select miktar from stok where stokid = '" + degerID + "'";
                    ds = fn.getData(sorgu);
                    miktar = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    yeniMiktar = miktar + birimsayisi;

                    sorgu="update stok set miktar = '"+yeniMiktar+"' where stokid = '"+degerID+"'";
                    fn.setData(sorgu, "Stok Sepetten Kaldirildi.");
                    toplamMiktar = toplamMiktar - degerMiktari;
                    ToplamFiyat.Text = toplamMiktar.ToString()+" ₺"; 
                }
                UC_P_SatisYap_Load(this, null);
            }
        }
        private void btnOdemeYapYazdir_Click(object sender, EventArgs e)
        {
            DGVPrinter yazdir = new DGVPrinter();
            yazdir.Title = "NA Ecza Deposu";
            yazdir.SubTitle = String.Format("Tarih: {0}", DateTime.Now.ToString());
            yazdir.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            yazdir.PageNumbers = true;
            yazdir.PageNumberInHeader= false;
            yazdir.PorportionalColumns= true;
            yazdir.HeaderCellAlignment = StringAlignment.Near;
            yazdir.Footer = "Toplam Odenecek Tutar : " + ToplamFiyat.Text;
            yazdir.FooterSpacing= 15;
            yazdir.PrintDataGridView(TabloStok);

            toplamMiktar = 0;
            ToplamFiyat.Text = "0 ₺";
            TabloStok.DataSource = 0;



        }
        private void hepsiniTemizle()
        {
            txtStokID.Clear();
            txtStokAdi.Clear();
            dtpSonKullanmaTarihi.ResetText();
            txtBirimFiyat.Clear();
            txtBirimSayisi.Clear();

        }
    }
}
