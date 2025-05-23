using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using KafeOtomasyon.DAL;
using KafeOtomasyon.Entities.Models;
using KafeOtomasyon.KafeOtomasyon.UI.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace KafeOtomasyon.UI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly KafeDbContext _context;

        public LoginForm(KafeDbContext context)
        {
            InitializeComponent();  // Designer tarafından sağlanır
            _context = context;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // İsteğe bağlı başlangıç ayarları
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullaniciAdi = txtKullaniciAdi.Text.Trim();
            var sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sifreHash = Sha256Hash(sifre);

            var kullanici = _context.Kullanicilar
                .FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi && k.Sifre == sifreHash);

            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form hedefForm;
            if (kullanici.YetkiTipi == "Admin")
                hedefForm = Program.ServiceProvider.GetRequiredService<AdminMainForm>();
            else if (kullanici.YetkiTipi == "Personel")
                hedefForm = Program.ServiceProvider.GetRequiredService<PersonelMainForm>();
            else
            {
                MessageBox.Show("Bu kullanıcı tipi için yetkiniz yok!", "Erişim Engellendi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Giriş başarılı ({kullanici.YetkiTipi})!", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            hedefForm.Show();
            this.Hide();
        }

        private static string Sha256Hash(string input)
        {
            using var sha = SHA256.Create();
            var data = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder();
            foreach (var b in data)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }
    }
}
