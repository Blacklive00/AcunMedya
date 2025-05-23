using KafeOtomasyon.DAL;
using KafeOtomasyon.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KafeOtomasyon.KafeOtomasyon.UI.Forms.masa
{
    public partial class MasaEkleForm : Form
    {
        private readonly KafeDbContext _context;
        private Masa seciliMasa = null;

        public MasaEkleForm()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<KafeDbContext>();
            optionsBuilder.UseSqlServer("Server=LAPTOP-T4S27CSF\\SQLEXPRESS;Database=KafeOtomasyon;Trusted_Connection=True;TrustServerCertificate=True");
            _context = new KafeDbContext(optionsBuilder.Options);

            dgvMasalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMasalar.MultiSelect = false;
            dgvMasalar.CellClick += DgvMasalar_CellClick;
            this.Load += MasaEkleForm_Load;
        }

        private void MasaEkleForm_Load(object sender, EventArgs e)
        {
            MasalariYukle();

            // Enum değerlerini ComboBox'a otomatik ekle
            cmbDurum.Items.Clear();
            cmbDurum.Items.AddRange(Enum.GetNames(typeof(MasaDurumu)));
        }

        private void MasalariYukle()
        {
           
            // Önce veritabanından enum değerinin int haliyle çekiyoruz
            var masalar = _context.Masalar
                .Select(m => new
                {
                    m.MasaId,
                    m.Kat,
                    m.MasaNo,
                    Durum = (int)m.Durum
                })
                .ToList();

            // Sonra bellekte enum karşılığını string olarak çeviriyoruz
            var liste = masalar.Select(m => new
            {
                m.MasaId,
                m.Kat,
                m.MasaNo,
                Durum = ((MasaDurumu)m.Durum).ToString()
            }).ToList();

            dgvMasalar.DataSource = liste;
            dgvMasalar.Columns["MasaId"].Visible = false;
            ClearForm();
        }

        

        private void btnMasaEkle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cmbKat.Text.Trim(), out int kat))
            {
                MessageBox.Show("Geçerli bir kat numarası girin.");
                return;
            }

            if (!int.TryParse(txtmasano.Text.Trim(), out int no))
            {
                MessageBox.Show("Geçerli bir masa numarası girin.");
                return;
            }

            if (_context.Masalar.Any(m => m.Kat == kat && m.MasaNo == no))
            {
                MessageBox.Show("Bu kat ve masa numarası zaten mevcut.");
                return;
            }

            if (!Enum.TryParse<MasaDurumu>(cmbDurum.Text, out MasaDurumu durum))
            {
                MessageBox.Show("Geçerli bir masa durumu seçin.");
                return;
            }

            var masa = new Masa { Kat = kat, MasaNo = no, Durum = durum };
            _context.Masalar.Add(masa);
            _context.SaveChanges();

            MessageBox.Show("Masa eklendi.");
            MasalariYukle();
        }

        private void btnMasaGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliMasa == null)
            {
                MessageBox.Show("Lütfen güncellenecek bir masa seçin.");
                return;
            }

            if (!int.TryParse(cmbKat.Text.Trim(), out int kat))
            {
                MessageBox.Show("Geçerli bir kat numarası girin.");
                return;
            }

            if (!int.TryParse(txtmasano.Text.Trim(), out int no))
            {
                MessageBox.Show("Geçerli bir masa numarası girin.");
                return;
            }

            if (_context.Masalar.Any(m => m.Kat == kat && m.MasaNo == no && m.MasaId != seciliMasa.MasaId))
            {
                MessageBox.Show("Bu kat ve masa numarası zaten mevcut.");
                return;
            }

            if (!Enum.TryParse<MasaDurumu>(cmbDurum.Text, out MasaDurumu durum))
            {
                MessageBox.Show("Geçerli bir masa durumu seçin.");
                return;
            }

            seciliMasa.Kat = kat;
            seciliMasa.MasaNo = no;
            seciliMasa.Durum = durum;

            _context.SaveChanges();

            MessageBox.Show("Masa güncellendi.");
            MasalariYukle();
        }

        private void btnMasaSil_Click(object sender, EventArgs e)
        {
            if (seciliMasa == null)
            {
                MessageBox.Show("Lütfen silinecek bir masa seçin.");
                return;
            }

            var sonuc = MessageBox.Show(
                $"Kat {seciliMasa.Kat}, Masa No {seciliMasa.MasaNo} silinecek. Onaylıyor musunuz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                _context.Masalar.Remove(seciliMasa);
                _context.SaveChanges();

                MessageBox.Show("Masa silindi.");
                MasalariYukle();
            }

        }

        private void ClearForm()
        {
            cmbKat.Text = string.Empty;
            txtmasano.Clear();
            cmbDurum.Text = string.Empty;
            seciliMasa = null;
            dgvMasalar.ClearSelection();
        }

        private void DgvMasalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dgvMasalar.Rows[e.RowIndex].Selected = true;
            int id = (int)dgvMasalar.Rows[e.RowIndex].Cells["MasaId"].Value;
            seciliMasa = _context.Masalar.Find(id);

            if (seciliMasa != null)
            {
                cmbKat.Text = seciliMasa.Kat.ToString();
                txtmasano.Text = seciliMasa.MasaNo.ToString();
                cmbDurum.Text = seciliMasa.Durum.ToString();
            }
        }
    }
}
