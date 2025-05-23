using System;
using System.Windows.Forms;
using KafeOtomasyon.KafeOtomasyon.Business.Services;

namespace KafeOtomasyon.KafeOtomasyon.UI.Forms
{
    public partial class RaporlarForm : Form
    {
        private RaporService _raporService;

        public RaporlarForm()
        {
            InitializeComponent();

            // Bağlantı string'i tek yerde tutabilirsin, ya da config dosyasından çekebilirsin.
            string connectionString = "Server=LAPTOP-T4S27CSF\\SQLEXPRESS;Database=KafeOtomasyon;Trusted_Connection=True;TrustServerCertificate=True";

            _raporService = new RaporService(connectionString);
        }

        private void RaporlarForm_Load(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Now.AddDays(-7);
            dtpBitis.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var baslangicTarihi = dtpBaslangic.Value.Date;
            var bitisTarihi = dtpBitis.Value.Date.AddDays(1).AddTicks(-1);

            var raporlar = _raporService.GetSiparisRaporu(baslangicTarihi, bitisTarihi);

            dgvRaporlar.DataSource = raporlar;
        }
    }
}
