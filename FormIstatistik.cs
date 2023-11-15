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
    public partial class FormIstatistik : Form
    {
        public FormIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9HI19T4\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");

        private void FormIstatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) from tablo_Personel",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                label7.Text = dr1[0].ToString();
            }
            dr1.Close();
            baglanti.Close();

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) from tablo_Personel where PerDURUM = 1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label8.Text = dr2[0].ToString();
            }
            dr2.Close();
            baglanti.Close();

            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select Count(*) from tablo_Personel where PerDURUM = 0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label9.Text = dr3[0].ToString();
            }

            baglanti.Close();


            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("Select count(distinct(PerSEHIR)) from tablo_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                label10.Text = dr4[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("select sum(PerMAAS) from tablo_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                label11.Text = dr5[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("Select AVG(PerMAAS) from tablo_Personel where PerDURUM = 0", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                label12.Text = dr6[0].ToString();
            }

            baglanti.Close();
        }
    }
}