using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14ACUN_MEDYA_AKADEMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=.\SQLEXPRESS;Database=HastaRandevuDB;Trusted_Connection=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
            // Saatleri yükle
            cmbSaat.Items.AddRange(new string[] { "09:00", "10:00", "11:00", "13:00", "14:00", "15:00" });

            // Branşları getir
            SqlCommand komut = new SqlCommand("SELECT * FROM Branslar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBrans.DisplayMember = "BransAdi";
            cmbBrans.ValueMember = "Id";
            cmbBrans.DataSource = dt;
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Doktorlar WHERE BransID = @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbBrans.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDoktor.DisplayMember = "DoktorAdi";
            cmbDoktor.ValueMember = "Id";
            cmbDoktor.DataSource = dt;
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHastaAdi.Text) || string.IsNullOrWhiteSpace(txtHastaSoyadi.Text) || cmbSaat.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz giriniz.");
                return;
            }

            DateTime secilenTarih = dtTarih.Value.Date;
            string secilenSaat = cmbSaat.SelectedItem.ToString();
            DateTime randevuTarihi = DateTime.Parse(secilenTarih.ToShortDateString() + " " + secilenSaat);

            // Aynı doktorun aynı saatte randevusu var mı?
            SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM Randevular WHERE DoktorID = @doktor AND Tarih = @tarih", baglanti);
            kontrol.Parameters.AddWithValue("@doktor", cmbDoktor.SelectedValue);
            kontrol.Parameters.AddWithValue("@tarih", randevuTarihi);

            baglanti.Open();
            int kayitVarMi = (int)kontrol.ExecuteScalar();
            baglanti.Close();

            if (kayitVarMi > 0)
            {
                MessageBox.Show("Bu doktor seçilen tarih ve saatte zaten randevulu!");
                return;
            }

            // Kayıt ekle
            SqlCommand komut = new SqlCommand("INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih) VALUES (@adi, @soyadi, @brans, @doktor, @tarih)", baglanti);
            komut.Parameters.AddWithValue("@adi", txtHastaAdi.Text);
            komut.Parameters.AddWithValue("@soyadi", txtHastaSoyadi.Text);
            komut.Parameters.AddWithValue("@brans", cmbBrans.SelectedValue);
            komut.Parameters.AddWithValue("@doktor", cmbDoktor.SelectedValue);
            komut.Parameters.AddWithValue("@tarih", randevuTarihi);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Randevu başarıyla oluşturuldu.");
        }
    }
}
