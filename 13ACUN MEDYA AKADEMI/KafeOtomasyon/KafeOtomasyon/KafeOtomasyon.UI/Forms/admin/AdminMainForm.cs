using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using KafeOtomasyon.KafeOtomasyon.UI.Forms.masa;
using KafeOtomasyon.KafeOtomasyon.UI.Forms.stok;
using KafeOtomasyon.KafeOtomasyon.UI.Forms.Urun;

namespace KafeOtomasyon.KafeOtomasyon.UI.Forms
{
    public partial class AdminMainForm : Form
    {


        public AdminMainForm()
        {
            InitializeComponent();

            this.Load += AdminMainForm_Load;

            // OlayYoneticisi eventine abone ol
            OlayYoneticisi.OdemeYapildi += OlayYoneticisi_OdemeYapildi;
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            MasalariYukle();
        }

        private string connectionString = "Server=LAPTOP-T4S27CSF\\SQLEXPRESS;Database=KafeOtomasyon;Trusted_Connection=True;TrustServerCertificate=True";

        private void MasalariYukle()
        {
            flowLayoutPanelMasalar.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT MasaId, Kat, MasaNo, Durum FROM Masalar ORDER BY Kat, MasaNo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int masaId = reader.GetInt32(0);
                            int kat = reader.GetInt32(1);
                            int masaNo = reader.GetInt32(2);
                            int durum = reader.GetInt32(3);

                            Button btnMasa = new Button
                            {
                                Width = 100,
                                Height = 80,
                                Margin = new Padding(5),
                                Tag = masaId,
                                Text = $"Kat: {kat}\nMasa No: {masaNo}\nDurum: {(MasaDurumu)durum}",
                                TextAlign = ContentAlignment.MiddleCenter,
                                Font = new Font("Segoe UI", 9, FontStyle.Bold)
                            };

                            switch ((MasaDurumu)durum)
                            {
                                case MasaDurumu.Bos:
                                    btnMasa.BackColor = Color.LightGreen;
                                    break;
                                case MasaDurumu.Dolu:
                                    btnMasa.BackColor = Color.IndianRed;
                                    break;
                                case MasaDurumu.Rezerve:
                                    btnMasa.BackColor = Color.Gold;
                                    break;
                            }

                            btnMasa.Click += BtnMasa_Click;

                            flowLayoutPanelMasalar.Controls.Add(btnMasa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masalar yüklenirken hata oluştu: " + ex.Message);
            }
        }



        private void OlayYoneticisi_OdemeYapildi(object sender, EventArgs e)
        {
            MasalariYukle(); // Ödeme yapıldığında masaları yenile
        }

        private void BtnMasa_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int masaId = (int)btn.Tag;

            SiparisForm siparisForm = new SiparisForm(masaId);
            siparisForm.ShowDialog();

            // Burada artık siparisForm.OdemeYapildi kontrolü yok
            // Çünkü OlayYoneticisi.OdemeYapildi event'i ile güncelleme yapılacak
        }

        private void flowLayoutPanelMasalar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ürünStokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form stok = Application.OpenForms["StokEkleForm"];

            if (stok == null)
            {
                stok = new StokEkleForm();
                stok.Show();
            }
            else
            {
                stok.BringToFront();
                stok.WindowState = FormWindowState.Normal;
                stok.Show();
            }

            this.Hide();

            stok.FormClosed += (s, args) => this.Show();
        }



        

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rapor = Application.OpenForms["RaporlarForm"];

            if (rapor == null)
            {
                rapor = new RaporlarForm();
                rapor.Show();
            }
            else
            {
                rapor.BringToFront();
                rapor.WindowState = FormWindowState.Normal;
                rapor.Show();
            }

            this.Hide();

            rapor.FormClosed += (s, args) => this.Show();




        }

        private void masalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form masa = Application.OpenForms["MasaEkleForm"];

            if (masa == null)
            {
                masa = new MasaEkleForm();
                masa.Show();
            }
            else
            {
                masa.BringToFront();
                masa.WindowState = FormWindowState.Normal;
                masa.Show();
            }

            this.Hide();

            masa.FormClosed += (s, args) => this.Show();



        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ürün = Application.OpenForms["UrunEkleForm"];

            if (ürün == null)
            {
                ürün = new UrunEkleForm();
                ürün.Show();
            }
            else
            {
                ürün.BringToFront();
                ürün.WindowState = FormWindowState.Normal;
                ürün.Show();
            }

            this.Hide();

            ürün.FormClosed += (s, args) => this.Show();
        }

        private void kişiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kullaniciForm = Application.OpenForms["KullaniciEkleForm2"];

            if (kullaniciForm == null)
            {
                kullaniciForm = new KullaniciEkleForm2();
                kullaniciForm.Show();
            }
            else
            {
                kullaniciForm.BringToFront();
                kullaniciForm.WindowState = FormWindowState.Normal;
                kullaniciForm.Show();
            }

            this.Hide();

            kullaniciForm.FormClosed += (s, args) => this.Show();




        }

        private enum MasaDurumu
        {
            Bos = 0,
            Dolu = 1,
            Rezerve = 2
        }
    }
}
