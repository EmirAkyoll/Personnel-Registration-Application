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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BaglantiSinifi bgl = new BaglantiSinifi();

       


        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            this.tablo_PersonelTableAdapter.Fill(this.personelVeriTabanıDataSet.tablo_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into tablo_Personel (PerAD,PerSOYAD,PerSEHIR,PerMAAS,PerDURUM,PerMESLEK) values (@ad,@soyad,@sehir,@maas,@durum,@meslek)", baglanti);
            komut.Parameters.AddWithValue("@ad",txtAD.Text);
            komut.Parameters.AddWithValue("@soyad",txtSOYAD.Text);
            komut.Parameters.AddWithValue("@sehir",cmbxSehir.Text);
            komut.Parameters.AddWithValue("@maas",maskedMAAS.Text);
            komut.Parameters.AddWithValue("@meslek",txtMESLEK.Text);
            komut.Parameters.AddWithValue("@durum",label8.Text);
            komut.ExecuteNonQuery();
            
            baglanti.Close();

            MessageBox.Show("Personel eklendi.");
        }

        private void secenekEvli_CheckedChanged(object sender, EventArgs e)
        {
            if (secenekEvli.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void secenekBekar_CheckedChanged(object sender, EventArgs e)
        {
            if (secenekBekar.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAD.Text = "";
            txtSOYAD.Text = "";
            cmbxSehir.Text = "";
            maskedMAAS.Text = "";
            secenekEvli.Checked = false;
            secenekBekar.Checked = false;
            txtMESLEK.Text = "";
            txtAD.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbxSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedMAAS.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMESLEK.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }


        private void label8_TextChanged_1(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                secenekEvli.Checked = true;
                secenekBekar.Checked = false;
            }
            if (label8.Text == "False")
            {
                secenekBekar.Checked = true;
                secenekEvli.Checked = false;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("Delete From tablo_Personel where PerID = @id", baglanti);
            komutsil.Parameters.AddWithValue("@id", txtID.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);

            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("Update tablo_Personel set PerAD = @alan1, PerSOYAD = @alan2, PerSEHIR = @alan3, PerMAAS = @alan4, PerDURUM = @alan5, PerMESLEK = @alan6 where PerID = @alan7", baglanti);
            komutguncelle.Parameters.AddWithValue("@alan7", txtID.Text);
            komutguncelle.Parameters.AddWithValue("@alan1", txtAD.Text);
            komutguncelle.Parameters.AddWithValue("@alan2", txtSOYAD.Text);
            komutguncelle.Parameters.AddWithValue("@alan3", cmbxSehir.Text);
            komutguncelle.Parameters.AddWithValue("@alan4", maskedMAAS.Text);
            komutguncelle.Parameters.AddWithValue("@alan5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@alan6", txtMESLEK.Text);
            komutguncelle.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Personel bilgileri güncellendi.");
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FormIstatistik frm_ist = new FormIstatistik();
            frm_ist.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FormGrafikler frmGra = new FormGrafikler();
            frmGra.Show();
        }
    }
}
