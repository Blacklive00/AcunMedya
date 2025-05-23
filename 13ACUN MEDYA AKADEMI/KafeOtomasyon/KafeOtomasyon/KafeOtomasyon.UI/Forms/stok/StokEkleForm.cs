using KafeOtomasyon.DAL;
using KafeOtomasyon.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KafeOtomasyon.KafeOtomasyon.UI.Forms.stok
{
    public partial class StokEkleForm : Form
    {
        private readonly KafeDbContext _context;

        public StokEkleForm()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<KafeDbContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-T4S27CSF\\SQLEXPRESS;Database=KafeOtomasyon;Trusted_Connection=True;TrustServerCertificate=True");

            _context = new KafeDbContext(optionsBuilder.Options);

            dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUrunler.MultiSelect = false;
        }

        private void StokEkleForm_Load(object sender, EventArgs e)
        {
            UrunleriYukle();
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
                    GrupAdi = u.UrunGrup.GrupAdi,
                    u.StokAdedi
                })
                .ToList();

            dgvUrunler.DataSource = liste;
            dgvUrunler.Columns["UrunId"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) // Stok Ekle Butonu
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen stok artırmak için bir ürün seçin.");
                return;
            }

            int id = (int)dgvUrunler.SelectedRows[0].Cells["UrunId"].Value;
            var urun = _context.Urunler.Find(id);

            if (urun == null)
            {
                MessageBox.Show("Seçilen ürün bulunamadı.");
                return;
            }

            int eklenecekAdet = (int)nudStokMiktar.Value;

            if (eklenecekAdet <= 0)
            {
                MessageBox.Show("Lütfen 0'dan büyük bir stok miktarı girin.");
                return;
            }

            urun.StokAdedi += eklenecekAdet;
            _context.SaveChanges();

            MessageBox.Show($"{urun.UrunAdi} ürününün stoğu {eklenecekAdet} adet artırıldı.");

            UrunleriYukle(); // tabloyu güncelle
        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçim işlemi yapılabilir, ama ek gerek yok
        }

        private void nudStokMiktar_ValueChanged(object sender, EventArgs e)
        {
            // İsteğe bağlı
        }

        private void lblStokMiktar_Click(object sender, EventArgs e)
        {
            // İsteğe bağlı
        }
    }
}
