using FluentValidation;
using KafeOtomasyon.Entities.Models;

namespace KafeOtomasyon.BLL.Validations
{
    public class KullaniciValidator : AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            RuleFor(k => k.KullaniciAdi)
                .NotEmpty().WithMessage("Kullanıcı adı boş olamaz.")
                .MaximumLength(50).WithMessage("Kullanıcı adı 50 karakterden uzun olamaz.");

            RuleFor(k => k.Sifre)
                .NotEmpty().WithMessage("Şifre boş olamaz.")
                .MaximumLength(100).WithMessage("Şifre 100 karakterden uzun olamaz.")
                .MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalı.");

            RuleFor(k => k.YetkiTipi)
                .NotEmpty().WithMessage("Yetki tipi boş olamaz.")
                .Must(y => y == "Admin" || y == "Personel")
                .WithMessage("Yetki tipi sadece 'Admin' veya 'Personel' olabilir.");
        }
    }
}
