 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaDeposu_Otomasyonu
{
    internal class fonksiyon
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection baglanti = new SqlConnection();
            BaglantiSinif bgl = new BaglantiSinif();
            baglanti.ConnectionString = bgl.Adres;
            return baglanti;
        }
        public DataSet getData(string sorgu)
        {
            SqlConnection baglanti=GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = sorgu;
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataSet ds= new DataSet();
            da.Fill(ds);
            return ds;

        }
        public void setData(String sorgu,String mesaj) 
        { 
            SqlConnection baglanti=GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            baglanti.Open();
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show(mesaj,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
        }

    }
}
