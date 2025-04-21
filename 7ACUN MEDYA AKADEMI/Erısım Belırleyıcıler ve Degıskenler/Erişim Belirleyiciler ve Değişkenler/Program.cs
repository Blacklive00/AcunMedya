//using System.Runtime.ConstrainedExecution;
//using System;

//erişim Belirleyiciler(Access Modifiers)
//C# dilinde erişim belirleyiciler, bir sınıfın veya üyenin (değişken, metot vb.) nereden erişilebilir olduğunu belirler.

//Erişim Belirleyici	Açıklama	Gerçek Hayattan Örnek
//public Her yerden erişilebilir.Bir halka açık park gibi, herkes girebilir.
//private Sadece tanımlandığı sınıf içinde erişilebilir.	Bir kişinin banka şifresi gibi, sadece o kişi kullanabilir.
//protected Aynı sınıf ve ondan türetilen alt sınıflar erişebilir.	Aile içi bilgiler gibi, sadece aile bireyleri bilebilir.
//internal Aynı projedeki diğer sınıflar erişebilir, ancak farklı projeler erişemez.	Bir şirketin iç belgeleri gibi, sadece çalışanlar görebilir.
//OOP’de Erişim Belirleyicilerin Rolü
//Kapsülleme (Encapsulation): Dışarıdan doğrudan erişilmesini istemediğimiz verileri korumamıza yardımcı olur.

//Güvenlik: Yanlışlıkla verilere dışarıdan erişilmesini veya değiştirilmesini önler.

//Kod Organizasyonu: Hangi verilere ve metotlara nereden erişileceğini belirleyerek kodun daha düzenli olmasını sağlar.




using System;

// Kullanıcı sınıfı tanımlanıyor
class User
{
    // Özel değişkenler (Encapsulation - Kapsülleme uygulanıyor)
    private string adSoyad;
    private int yas;

    // Genel olarak erişilebilir Email değişkeni
    public string Email { get; set; }

    // Getter ve Setter metotları
    public void SetAdSoyad(string isim)
    {
        adSoyad = isim;
    }

    public string GetAdSoyad()
    {
        return adSoyad;
    }

    public void SetYas(int kullaniciYas)
    {
        if (kullaniciYas > 0) // Negatif yaş girilmesini önlemek için kontrol
        {
            yas = kullaniciYas;
        }
        else
        {
            Console.WriteLine("Geçersiz yaş girdiniz!");
        }
    }

    public int GetYas()
    {
        return yas;
    }

    // Kullanıcının bilgilerini ekrana yazdıran metod
    public void BilgileriGoster()
    {
        Console.WriteLine("Ad Soyad: " + adSoyad);
        Console.WriteLine("Yaş: " + yas);
        Console.WriteLine("Email: " + Email);
    }
}

class Program
{
    static void Main()
    {
        // Kullanıcı nesnesi oluşturuluyor
        User kullanici = new User();

        // Bilgiler set ediliyor
        kullanici.SetAdSoyad("Ahmet Yılmaz");
        kullanici.SetYas(25);
        kullanici.Email = "ahmet@example.com";

        // Kullanıcı bilgileri ekrana yazdırılıyor
        kullanici.BilgileriGoster();
    }
}
