using Microsoft.EntityFrameworkCore;
using KafeOtomasyon.Entities.Models;

namespace KafeOtomasyon.DAL
{
    public class KafeDbContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<UrunGrup> UrunGruplari { get; set; }
        public DbSet<Urun2> Urunler { get; set; }
        public DbSet<Masa> Masalar { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylari { get; set; }

        public KafeDbContext(DbContextOptions<KafeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Kat ve MasaNo birleşimi için UNIQUE kısıtlaması
            modelBuilder.Entity<Masa>()
                .HasIndex(m => new { m.Kat, m.MasaNo })
                .IsUnique();

            // Sipariş ve Masa ilişkisi (Cascade Delete)
            modelBuilder.Entity<Siparis>()
                .HasOne(s => s.Masa)
                .WithMany()
                .HasForeignKey(s => s.MasaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Tablo adlarını özelleştirme (opsiyonel)
            modelBuilder.Entity<UrunGrup>().ToTable("UrunGruplari");
            modelBuilder.Entity<OdemeTuru>().ToTable("OdemeTurleri");
        }
    }
}
