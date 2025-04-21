using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

//Namespace(Ad Alanı) Nedir?


//Namespace, bir projedeki sınıfları, metodları ve diğer kod bileşenlerini organize etmek için kullanılan bir yapıdır.

//Avantajları:
// Çakışmayı Önler: Aynı isimde farklı sınıflar tanımlayabilmemizi sağlar.
// Kod Organizasyonu Sağlar: Büyük projelerde kodları mantıklı bir şekilde gruplar.
// Okunabilirliği Artırır: Hangi kodun nerede olduğunu daha kolay bulmamızı sağlar.

//Gerçek Hayattan Örnek:
//Bir kütüphanede kitaplar konularına göre farklı raflara dizilir. Namespace de projede kodları böyle düzenler.


//Genişletilebilirlik(Extensibility) Nedir? ,


//Bir yazılımın gelecekte yeni özellikler eklenebilir olması genişletilebilirlik anlamına gelir.

//Genişletilebilirlik Sağlama Yöntemleri:
// Modüler Kodlama: Farklı işlevleri ayrı sınıflar ve namespace’ler içine koymak.
// Arayüz(Interface) Kullanımı: Yeni özellikler eklenirken bağımsız modüllerin birlikte çalışmasını sağlamak.
// Soyutlama (Abstraction) Kullanımı: Temel işlevleri soyut sınıflarla belirlemek.
// Bağımlılığı Azaltmak: Bir bileşeni değiştirdiğimizde diğerleri etkilenmemeli.

//Gerçek Hayattan Örnek:
//Bir bilgisayarın USB portu sayesinde farklı cihazları (klavye, fare, flash bellek vb.) kolayca takabilmemiz genişletilebilirliğe örnektir.

       

using System;


namespace MatematikIslemleri
{
    public class Hesaplama
    {
    
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

    
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}


namespace ProgramCalistir
{
    using MatematikIslemleri; 

    class Program
    {
        static void Main()
        {
           
            Hesaplama hesap = new Hesaplama();

            int toplamSonucu = hesap.Topla(10, 5);
            int carpmaSonucu = hesap.Carp(10, 5);

            Console.WriteLine("Toplam Sonucu: " + toplamSonucu);
            Console.WriteLine("Çarpma Sonucu: " + carpmaSonucu);
        }
    }
}
