using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using KafeOtomasyon.KafeOtomasyon.Entities__Model_sınıfları___Veri_Tabanı_Tabloları_.Models;

namespace KafeOtomasyon.KafeOtomasyon.UI.Forms
{
    public partial class SiparisForm : Form
    {
        private int masaNo;
        private List<SiparisKalemi> siparisler = new List<SiparisKalemi>();

        private string connectionString = "Server=LAPTOP-T4S27CSF\\SQLEXPRESS;Database=KafeOtomasyon;Trusted_Connection=True;TrustServerCertificate=True";

        public SiparisForm(int masaNo)
        {
            InitializeComponent();
            this.masaNo = masaNo;
            lblMasaBilgi.Text = $"Masa No: {masaNo}";

            // Kategori ve ürünleri yükle
            UrunGruplariniYukle();

            // Eventleri bağla
            btnEkle.Click += BtnEkle_Click;
            btnOdeme.Click += BtnOdeme_Click;
            btnKapat.Click += BtnKapat_Click;

            // DataGridView sütunlarını ayarla
            dgvSiparisler.Columns.Add("UrunAdi", "Ürün Adı");
            dgvSiparisler.Columns.Add("Miktar", "Miktar");
            dgvSiparisler.Columns.Add("Fiyat", "Birim Fiyat");
            dgvSiparisler.Columns.Add("Tutar", "Tutar");

            // Kategori seçimi değiştiğinde ürünleri yükle
            cmbUrunGruplari.SelectedIndexChanged += CmbUrunGruplari_SelectedIndexChanged;
        }

        private void UrunGruplariniYukle()
        {
            cmbUrunGruplari.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT UrunGrupId, GrupAdi FROM UrunGruplari";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    var gruplar = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        int grupId = reader.GetInt32(0);
                        string grupAdi = reader.GetString(1);

                        gruplar.Add(grupId, grupAdi);
                    }

                    cmbUrunGruplari.DataSource = new BindingSource(gruplar, null);
                    cmbUrunGruplari.DisplayMember = "Value";
                    cmbUrunGruplari.ValueMember = "Key";
                }
            }
        }

        private void CmbUrunGruplari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUrunGruplari.SelectedValue == null)
                return;

            int grupId = (int)((KeyValuePair<int, string>)cmbUrunGruplari.SelectedItem).Key;
            UrunleriYukle(grupId);
        }

        private void UrunleriYukle(int grupId)
        {
            List<Urun1> urunler = new List<Urun1>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT UrunId, UrunAdi, Fiyat, StokAdedi FROM Urunler WHERE UrunGrupId = @grupId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@grupId", grupId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string ad = reader.GetString(1);
                            decimal fiyat = reader.GetDecimal(2);
                            int stok = reader.GetInt32(3);

                            urunler.Add(new Urun1()
                            {
                                Id = id,
                                Ad = ad,
                                Fiyat = fiyat,
                                Stok = stok
                            });
                        }
                    }
                }
            }

            cmbUrunler.DataSource = urunler;
            cmbUrunler.DisplayMember = "Ad";
            cmbUrunler.ValueMember = "Id";
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (cmbUrunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.");
                return;
            }

            Urun1 secilenUrun = (Urun1)cmbUrunler.SelectedItem;
            int miktar = (int)nudMiktar.Value;

            if (secilenUrun.Stok < miktar)
            {
                MessageBox.Show("Seçilen ürünün stok miktarı yeterli değil.");
                return;
            }

            decimal tutar = secilenUrun.Fiyat * miktar;

            SiparisKalemi kalem = new SiparisKalemi
            {
                UrunAdi = secilenUrun.Ad,
                Miktar = miktar,
                BirimFiyat = secilenUrun.Fiyat,
                Tutar = tutar,
                UrunId = secilenUrun.Id
            };

            siparisler.Add(kalem);

            dgvSiparisler.Rows.Add(kalem.UrunAdi, kalem.Miktar, kalem.BirimFiyat.ToString("C"), kalem.Tutar.ToString("C"));

            ToplamTutarGuncelle();
        }

        private void ToplamTutarGuncelle()
        {
            decimal toplam = 0;
            foreach (var kalem in siparisler)
            {
                toplam += kalem.Tutar;
            }

            lblToplamTutar.Text = $"Toplam: {toplam:C}";
        }

        private void BtnOdeme_Click(object sender, EventArgs e)
        {
            if (siparisler.Count == 0)
            {
                MessageBox.Show("Sipariş listesi boş.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Siparişlerdeki her ürün için stok güncelle
                    foreach (var kalem in siparisler)
                    {
                        string stokGuncelleQuery = "UPDATE Urunler SET StokAdedi = StokAdedi - @miktar WHERE UrunId = @urunId AND StokAdedi >= @miktar";
                        using (SqlCommand cmd = new SqlCommand(stokGuncelleQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@miktar", kalem.Miktar);
                            cmd.Parameters.AddWithValue("@urunId", kalem.UrunId);

                            int affected = cmd.ExecuteNonQuery();
                            if (affected == 0)
                            {
                                throw new Exception($"'{kalem.UrunAdi}' ürününün stoku yetersiz.");
                            }
                        }
                    }

                    // Masa durumunu boş yap (Durum = 0)
                    string masaDurumGuncelleQuery = "UPDATE Masalar SET Durum = 0 WHERE MasaId = @masaNo";
                    using (SqlCommand cmd = new SqlCommand(masaDurumGuncelleQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@masaNo", masaNo);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show($"Masa {masaNo} için toplam {lblToplamTutar.Text} tutarında ödeme alındı.\nMasa durumu boş olarak güncellendi.");

                    // Siparişleri temizle ve DataGridView'i temizle
                    siparisler.Clear();
                    dgvSiparisler.Rows.Clear();
                    ToplamTutarGuncelle();

                    this.Close(); // Formu kapat
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ödeme işlemi başarısız: " + ex.Message);
                }
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            // Ödeme yapılmadan kapatıldığında masa durumu dolu olarak güncellenir
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string masaDurumGuncelleQuery = "UPDATE Masalar SET Durum = 1 WHERE MasaId = @masaNo";
                using (SqlCommand cmd = new SqlCommand(masaDurumGuncelleQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@masaNo", masaNo);
                    cmd.ExecuteNonQuery();
                }
            }

            this.Close();
        }
    }

    // Yardımcı sınıflar
   

   
}
