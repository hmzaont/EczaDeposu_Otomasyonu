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
    public partial class UC_P_KontrolPaneli : UserControl
    {
        fonksiyon fn = new fonksiyon();
        String sorgu;
        DataSet ds;
        Int64 say;

        public UC_P_KontrolPaneli()
        {
            InitializeComponent();
        }

        private void UC_P_KontrolPaneli_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
