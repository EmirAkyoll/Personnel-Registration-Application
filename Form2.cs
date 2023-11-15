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

namespace Personel_Kayıt_Uygulaması_veritabanlı_
{
    public partial class FormGrafikler : Form
    {
        public FormGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9HI19T4\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");

        private void FormGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutgr1 = new SqlCommand("Select PerSEHIR,Count(*) From tablo_Personel group by PerSEHIR",baglanti);
            SqlDataReader dr1 = komutgr1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(dr1[0],dr1[1]);
            }

            baglanti.Close();

            baglanti.Open(); 

            SqlCommand komutgr2 = new SqlCommand("Select PerMESLEK,Count(*) From tablo_Personel group by PerMESLEK", baglanti);
            SqlDataReader dr2 = komutgr2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslekler"].Points.AddXY(dr2[0], dr2[1]);
            }

            baglanti.Close();
        }
    }
}
