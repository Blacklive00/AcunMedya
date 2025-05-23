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

            // DbContext ayarlarý
            services.AddDbContext<KafeDbContext>(options =>
                options.UseSqlServer("Server=LAPTOP-T4S27CSF\\SQLEXPRESS;Database=KafeOtomasyon;Trusted_Connection=True;TrustServerCertificate=True"));

            // Formlarý ekle
            services.AddScoped<PersonelMainForm>();
            services.AddScoped<AdminMainForm>();    
            services.AddScoped<LoginForm>();
            services.AddScoped<SiparisForm>();
            services.AddScoped<UrunListeleForm>();
            services.AddScoped<RaporlarForm>();
            services.AddScoped<KullaniciEkleForm2>();  // Burayý ekledik!

            // DI servis saðlayýcýsýný oluþtur
            ServiceProvider = services.BuildServiceProvider();

            // Uygulama baþlatma
            ApplicationConfiguration.Initialize();
            var mainForm = ServiceProvider.GetRequiredService<LoginForm>();
            Application.Run(mainForm);
        }
    }
}
