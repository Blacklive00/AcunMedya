using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using KafeOtomasyon.DAL;
using KafeOtomasyon.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace KafeOtomasyon.BLL
{
    public class KullaniciService
    {
        private readonly KafeDbContext _context;

        public KullaniciService()
        {
            var options = new DbContextOptionsBuilder<KafeDbContext>()
                .UseSqlServer("Server=LAPTOP-T4S27CSF\\SQLEXPRESS;Database=KafeOtomasyon;Trusted_Connection=True;TrustServerCertificate=True")
                .Options;
            _context = new KafeDbContext(options);
        }

        public List<object> KullanicilariGetir()
        {
            return _context.Kullanicilar.Select(k => new
            {
                k.KullaniciId,
                k.KullaniciAdi,
                k.YetkiTipi
            }).ToList<object>();
        }

        public Kullanici KullaniciGetir(int id)
        {
            return _context.Kullanicilar.Find(id);
        }

        public SonucModel KullaniciEkle(string ad, string sifre, string yetki)
        {
            if (string.IsNullOrWhiteSpace(ad))
                return new(false, "Kullanıcı adı boş olamaz.");
            if (ad.Length < 4 || ad.Length > 20)
                return new(false, "Kullanıcı adı 4-20 karakter aralığında olmalıdır.");

            if (string.IsNullOrWhiteSpace(sifre))
                return new(false, "Şifre boş olamaz.");
            if (sifre.Length < 8 || sifre.Length > 30)
                return new(false, "Şifre 8-30 karakter aralığında olmalıdır.");

            if (string.IsNullOrWhiteSpace(yetki))
                return new(false, "Yetki seçimi yapılmalıdır.");

            if (_context.Kullanicilar.Any(k => k.KullaniciAdi == ad))
                return new(false, "Bu kullanıcı adı zaten mevcut.");

            string sifreHash = HashSifre(sifre);

            var yeni = new Kullanici
            {
                KullaniciAdi = ad,
                Sifre = sifreHash,
                YetkiTipi = yetki
            };

            _context.Kullanicilar.Add(yeni);
            _context.SaveChanges();
            return new(true, "Kullanıcı başarıyla eklendi.");
        }

        public SonucModel KullaniciGuncelle(int id, string ad, string sifre, string yetki)
        {
            var kullanici = _context.Kullanicilar.Find(id);
            if (kullanici == null)
                return new(false, "Kullanıcı bulunamadı.");

            kullanici.KullaniciAdi = ad;
            kullanici.YetkiTipi = yetki;

            if (!string.IsNullOrWhiteSpace(sifre))
            {
                if (sifre.Length < 8)
                    return new(false, "Yeni şifre en az 8 karakter olmalı.");
                kullanici.Sifre = HashSifre(sifre);
            }

            _context.SaveChanges();
            return new(true, "Kullanıcı güncellendi.");
        }

        public SonucModel KullaniciSil(int id)
        {
            var kullanici = _context.Kullanicilar.Find(id);
            if (kullanici == null)
                return new(false, "Kullanıcı bulunamadı.");

            _context.Kullanicilar.Remove(kullanici);
            _context.SaveChanges();
            return new(true, "Kullanıcı silindi.");
        }

        private string HashSifre(string input)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(bytes.Select(b => b.ToString("x2")));
        }
    }

    public record SonucModel(bool Basarili, string Mesaj);
}
