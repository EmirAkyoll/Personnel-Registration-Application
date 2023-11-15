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
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }

        BaglantiSinifi bgl = new BaglantiSinifi();

        

        private void GirisYap_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select * From tablo_YoneticiPRSNL where KullaniciAdi = @id AND Sifre = @sifre", baglanti);
            komut.Parameters.Add("@id",txtKullaniciAdi.Text);
            komut.Parameters.Add("@sifre",txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frmAnaForm = new Form1();
                frmAnaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parolanızı yanlış girdiniz!");
            }

            baglanti.Close();
        }
    }
}
