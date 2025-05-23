using System;
using System.Linq;
using System.Windows.Forms;
using KafeOtomasyon.BLL;
using KafeOtomasyon.Entities.Models;

namespace KafeOtomasyon.KafeOtomasyon.UI.Forms
{
    public partial class KullaniciEkleForm2 : Form
    {
        private readonly KullaniciService _kullaniciService;
        private Kullanici seciliKullanici;

        public KullaniciEkleForm2()
        {
            InitializeComponent();
            _kullaniciService = new KullaniciService();
            dgvKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullanicilar.MultiSelect = false;
            cmbYetki.SelectedIndex = 0;
            dgvKullanicilar.SelectionChanged += dgvKullanicilar_SelectionChanged;
            KullanicilariYukle();
        }

        private void KullanicilariYukle()
        {
            dgvKullanicilar.DataSource = _kullaniciService.KullanicilariGetir();
            dgvKullanicilar.Columns["KullaniciId"].Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string yetki = cmbYetki.SelectedItem?.ToString();

            var sonuc = _kullaniciService.KullaniciEkle(ad, sifre, yetki);

            if (sonuc.Basarili)
            {
                MessageBox.Show(sonuc.Mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                KullanicilariYukle();
            }
            else
            {
                MessageBox.Show(sonuc.Mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKullanici == null)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ad = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string yetki = cmbYetki.SelectedItem?.ToString();

            var sonuc = _kullaniciService.KullaniciGuncelle(seciliKullanici.KullaniciId, ad, sifre, yetki);

            if (sonuc.Basarili)
            {
                MessageBox.Show(sonuc.Mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                KullanicilariYukle();
            }
            else
            {
                MessageBox.Show(sonuc.Mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (seciliKullanici == null)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Kullanıcıyı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var sonuc = _kullaniciService.KullaniciSil(seciliKullanici.KullaniciId);
                if (sonuc.Basarili)
                {
                    MessageBox.Show(sonuc.Mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    KullanicilariYukle();
                }
                else
                {
                    MessageBox.Show(sonuc.Mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvKullanicilar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKullanicilar.SelectedRows.Count > 0)
            {
                int id = (int)dgvKullanicilar.SelectedRows[0].Cells["KullaniciId"].Value;
                seciliKullanici = _kullaniciService.KullaniciGetir(id);
                if (seciliKullanici != null)
                {
                    txtKullaniciAdi.Text = seciliKullanici.KullaniciAdi;
                    cmbYetki.SelectedItem = seciliKullanici.YetkiTipi;
                    txtSifre.Clear();
                }
            }
        }

        private void Temizle()
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            cmbYetki.SelectedIndex = 0;
            seciliKullanici = null;
            dgvKullanicilar.ClearSelection();
        }
    }
}
