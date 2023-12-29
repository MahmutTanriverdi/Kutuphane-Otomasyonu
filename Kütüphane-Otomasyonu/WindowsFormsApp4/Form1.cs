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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Kitaplar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        string durum = "";
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Kitaplar (kitapAd, yazar,tür, sayfaSayisi,durum ) values (@p1,@p2,@p3,@p4,@p5) ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtKitapYazar.Text);
            komut.Parameters.AddWithValue("@p3", CmbKitapTur.Text);
            komut.Parameters.AddWithValue("@p4", TxtKitapSayfa.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtKitapId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtKitapYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbKitapTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtKitapSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Kitaplar where kitapId=" + TxtKitapId.Text, bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Kitaplar Set kitapAd=@p1, yazar=@p2, tür=@p3, sayfaSayisi=@p4, durum=@p5 where kitapId=@p6 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtKitapYazar.Text);
            komut.Parameters.AddWithValue("@p3", CmbKitapTur.Text);
            komut.Parameters.AddWithValue("@p4", TxtKitapSayfa.Text);
            if (radioButton1.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            if (radioButton2.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", durum);
            }
            komut.Parameters.AddWithValue("@p6", TxtKitapId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Kitaplar where kitapAd like '%" + TxtKitapBul.Text + "%'", bgl.baglanti());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void TxtKitapBul_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Kitaplar where kitapAd like '%" + TxtKitapBul.Text + "%' ",bgl.baglanti());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            bgl.baglanti().Close();
        }
    }
}
