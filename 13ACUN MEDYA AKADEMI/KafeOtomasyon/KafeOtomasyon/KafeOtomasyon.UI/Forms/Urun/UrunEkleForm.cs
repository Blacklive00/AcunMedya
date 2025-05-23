using KafeOtomasyon.DAL;
using KafeOtomasyon.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KafeOtomasyon.KafeOtomasyon.UI.Forms.Urun
{
    public partial class UrunEkleForm : Form
    {
        private readonly KafeDbContext _context;
        private Urun2 seciliUrun = null;

        public UrunEkleForm()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<KafeDbContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-T4S27CSF\\SQLEXPRESS;Database=KafeOtomasyon;Trusted_Connection=True;TrustServerCertificate=True");

            _context = new KafeDbContext(optionsBuilder.Options);

            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.MultiSelect = false;
            dgvUrunler.CellClick += dgvUrunler_CellClick;
        }

        private void UrunEkleForm_Load(object sender, EventArgs e)
        {
            GrupListesiniYukle();
            UrunleriYukle();
        }

        private void GrupListesiniYukle()
        {
            cmbUrunGrubu.DisplayMember = "GrupAdi";
            cmbUrunGrubu.ValueMember = "UrunGrupId";
            cmbUrunGrubu.DataSource = _context.UrunGruplari.ToList();
        }

        private void UrunleriYukle()
        {
            var liste = _context.Urunler
                .Include(u => u.UrunGrup)
                .Select(u => new
                {
                    u.UrunId,
                    u.UrunAdi,
                    u.Fiyat,
                    GrupAdi = u.UrunGrup.GrupAdi
                })
                .ToList();

            dgvUrunler.DataSource = liste;
            dgvUrunler.Columns["UrunId"].Visible = false;

            Temizle();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string ad = txtUrunAdi.Text.Trim();
            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Ürün adı boş olamaz.");
                return;
            }

            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Geçerli bir fiyat girin.");
                return;
            }

            if (cmbUrunGrubu.SelectedItem == null)
            {
                MessageBox.Show("Lütfen ürün grubu seçin.");
                return;
            }

            int grupId = (int)cmbUrunGrubu.SelectedValue;

            bool varMi = _context.Urunler.Any(u => u.UrunAdi == ad && u.UrunGrupId == grupId);
            if (varMi)
            {
                MessageBox.Show("Bu üründen zaten mevcut. Lütfen farklı bir ürün girin.");
                return;
            }

            var urun = new Urun2
            {
                UrunAdi = ad,
                Fiyat = fiyat,
                UrunGrupId = grupId
            };

            _context.Urunler.Add(urun);
            _context.SaveChanges();

            MessageBox.Show("Ürün eklendi.");
            UrunleriYukle();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliUrun == null)
            {
                MessageBox.Show("Lütfen güncellenecek bir ürün seçin.");
                return;
            }

            string ad = txtUrunAdi.Text.Trim();
            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Ürün adı boş olamaz.");
                return;
            }

            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Geçerli bir fiyat girin.");
                return;
            }

            int grupId = (int)cmbUrunGrubu.SelectedValue;

            bool varMiGuncelle = _context.Urunler
                .Any(u => u.UrunAdi == ad && u.UrunGrupId == grupId && u.UrunId != seciliUrun.UrunId);
            if (varMiGuncelle)
            {
                MessageBox.Show("Bu isimde bir ürün zaten mevcut. Güncelleme yapılmadı.");
                return;
            }

            seciliUrun.UrunAdi = ad;
            seciliUrun.Fiyat = fiyat;
            seciliUrun.UrunGrupId = grupId;

            _context.SaveChanges();

            MessageBox.Show("Ürün güncellendi.");
            UrunleriYukle();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (seciliUrun == null)
            {
                MessageBox.Show("Lütfen silinecek ürünü seçin.");
                return;
            }

            var sonuc = MessageBox.Show($"{seciliUrun.UrunAdi} silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                _context.Urunler.Remove(seciliUrun);
                _context.SaveChanges();

                MessageBox.Show("Ürün silindi.");
                UrunleriYukle();
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dgvUrunler.Rows[e.RowIndex].Selected = true;

            int id = (int)dgvUrunler.Rows[e.RowIndex].Cells["UrunId"].Value;
            seciliUrun = _context.Urunler.Find(id);

            if (seciliUrun != null)
            {
                txtUrunAdi.Text = seciliUrun.UrunAdi;
                txtFiyat.Text = seciliUrun.Fiyat.ToString("0.00");
                cmbUrunGrubu.SelectedValue = seciliUrun.UrunGrupId;
            }
        }

        private void Temizle()
        {
            txtUrunAdi.Clear();
            txtFiyat.Clear();
            if (cmbUrunGrubu.Items.Count > 0)
                cmbUrunGrubu.SelectedIndex = 0;

            seciliUrun = null;
            dgvUrunler.ClearSelection();
        }
    }
}
