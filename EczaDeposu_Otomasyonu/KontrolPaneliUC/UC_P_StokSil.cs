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
    public partial class UC_P_StokSil : UserControl
    {
        fonksiyon fn = new fonksiyon();
        String sorgu;
        public UC_P_StokSil()
        {
            InitializeComponent();
        }

        private void UC_P_StokMiktariniGoster_Load(object sender, EventArgs e)
        {
            sorgu = "select * from stok";
            setDataGridViev(sorgu);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            sorgu="select * from stok where stokadi like '"+txtAra.Text+"%'";
            setDataGridViev(sorgu);

        }
        private void setDataGridViev(String sorgu)
        {
            DataSet ds = fn.getData(sorgu);
            StokMiktarTablo.DataSource = ds.Tables[0];
        }

        String stokID;
        private void StokMiktarTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                stokID = StokMiktarTablo.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediginizden emin misiniz?", "Stok Kaydi Silme Islemi!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sorgu = "delete from stok where stokid = '" + stokID + "'";
                fn.setData(sorgu,"Stok Kaydi Silindi.");
                UC_P_StokMiktariniGoster_Load(this, null);

            }

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            UC_P_StokMiktariniGoster_Load(this, null);
        }
    }
}
