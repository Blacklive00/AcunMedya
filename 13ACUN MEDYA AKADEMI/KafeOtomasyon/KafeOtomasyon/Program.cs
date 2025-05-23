using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using KafeOtomasyon.DAL;
using KafeOtomasyon.KafeOtomasyon.UI.Forms;
using KafeOtomasyon.UI.Forms;

namespace KafeOtomasyon
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // DbContext ayarlar�
            services.AddDbContext<KafeDbContext>(options =>
                options.UseSqlServer("Server=LAPTOP-T4S27CSF\\SQLEXPRESS;Database=KafeOtomasyon;Trusted_Connection=True;TrustServerCertificate=True"));

            // Formlar� ekle
            services.AddScoped<PersonelMainForm>();
            services.AddScoped<AdminMainForm>();    
            services.AddScoped<LoginForm>();
            services.AddScoped<SiparisForm>();
            services.AddScoped<UrunListeleForm>();
            services.AddScoped<RaporlarForm>();
            services.AddScoped<KullaniciEkleForm2>();  // Buray� ekledik!

            // DI servis sa�lay�c�s�n� olu�tur
            ServiceProvider = services.BuildServiceProvider();

            // Uygulama ba�latma
            ApplicationConfiguration.Initialize();
            var mainForm = ServiceProvider.GetRequiredService<LoginForm>();
            Application.Run(mainForm);
        }
    }
}
