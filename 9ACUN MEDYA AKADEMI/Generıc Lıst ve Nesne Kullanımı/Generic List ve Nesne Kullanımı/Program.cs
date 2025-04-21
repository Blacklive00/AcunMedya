


// ÖDEV2: Görsel Programlama Araştırma Ödevi (Araştırma notları)
/*
  Görsel Programlama Nedir?
  - Görsel programlama, program geliştirme sürecinde grafiksel öğeler ve simgeler kullanılarak uygulamaların tasarlanmasıdır.

  Metin Tabanlı Programlamadan Farkları:
  - Metin tabanlı programlamada kod yazılırken; görsel programlamada sürükle-bırak yöntemiyle grafiksel arayüz kullanılır.
  - Öğrenmesi genellikle daha kolaydır, çünkü kullanıcılar önceden tanımlı bileşenleri kullanır.

  Kullanılan Araçlar ve Diller:
  - Scratch, App Inventor, LabVIEW, Microsoft Visual Programming Language gibi araçlar örnek verilebilir.

  Avantajları:
  - Hızlı prototipleme,
  - Kullanıcı dostu arayüz,
  - Görsel geribildirim sayesinde kolay hata ayıklama.

  Dezavantajları:
  - Karmaşık projelerde esneklik ve detaylı kontrol eksikliği,
  - Sınırlı ölçeklenebilirlik.
*/

// ÖDEV1: Generic List ve Nesne Kullanımı Ödevi

// Car nesnelerinden oluşan bir liste oluşturuluyor



using System;
using System.Collections.Generic;
using CarFuelConsumptionApp; 

namespace CarFuelConsumptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Car> cars = new List<Car>()
            {
                new Car() { Marka = "Toyota", Model = "Corolla", FuelConsumption = 6.5, TotalDistance = 5000 },
                new Car() { Marka = "BMW", Model = "X5", FuelConsumption = 9.0, TotalDistance = 5000 },
                new Car() { Marka = "Mercedes", Model = "C200", FuelConsumption = 8.2, TotalDistance = 5000 }
            };

           
            foreach (var car in cars)
            {
                double totalFuel = car.TotalFuelConsumption();
                Console.WriteLine($"Marka: {car.Marka}, Model: {car.Model}, 100 km'de Yaktığı Yakıt: {car.FuelConsumption} litre, Toplam Yakıt Tüketimi: {totalFuel} litre");
            }
        }
    }
}
