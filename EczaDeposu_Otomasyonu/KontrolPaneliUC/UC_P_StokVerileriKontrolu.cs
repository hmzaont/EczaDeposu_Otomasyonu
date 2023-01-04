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
    public partial class UC_P_StokVerileriKontrolu : UserControl
    {
        fonksiyon fn=new fonksiyon();
        String sorgu;
        public UC_P_StokVerileriKontrolu()
        {
            InitializeComponent();
        }

        private void cbKontrolEt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKontrolEt.SelectedIndex == 0)
            {
                sorgu = "select * from stok";
                DataSet ds = fn.getData(sorgu);
                TabloEtiketAyar.DataSource= ds.Tables[0];
                etiket.Text = "Tum Stok Verileri";
                etiket.ForeColor = Color.Black;
            }
        }
    }
}
