using System;

class Kapı
{
    public int Sayı { get; set; }
}

class Pencere
{
    public int Sayı { get; set; }
}

class Kasa
{
    public string Tür { get; set; }
}

class Marka
{
    public string Ad { get; set; }
    public string Model { get; set; }
}

class Araba
{
    public Kapı Kapı { get; set; }
    public Pencere Pencere { get; set; }
    public Kasa Kasa { get; set; }
    public Marka Marka { get; set; }
    public decimal Fiyat { get; set; }

    public Araba(Kapı kapı, Pencere pencere, Kasa kasa, Marka marka, decimal fiyat)
    {
        Kapı = kapı;
        Pencere = pencere;
        Kasa = kasa;
        Marka = marka;
        Fiyat = fiyat;
    }

    public void BilgileriYazdır()
    {
        Console.WriteLine($"Arabanın markası {Marka.Ad}, modeli {Marka.Model}, kapı sayısı {Kapı.Sayı}, pencere sayısı {Pencere.Sayı}, kasası {Kasa.Tür}, fiyatı {Fiyat} TL’dir.");
    }
}

class Program
{
    static void Main()
    {
       
        var kapı = new Kapı { Sayı = 4 };
        var pencere = new Pencere { Sayı = 4 };
        var kasa = new Kasa { Tür = "sedan" };
        var marka = new Marka { Ad = "BMW", Model = "X5" };
        var fiyat = 2000000m;

        
        var araba = new Araba(kapı, pencere, kasa, marka, fiyat);
        araba.BilgileriYazdır(); 
    }
}
