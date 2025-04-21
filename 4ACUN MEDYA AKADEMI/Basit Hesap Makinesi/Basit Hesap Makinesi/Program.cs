using System;

namespace BasitHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
            string islem = Console.ReadLine();

            switch (islem)
            {
                case "+":
                    Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
                    break;
                case "-":
                    Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
                    break;
                case "*":
                    Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
                    break;
                case "/":
                    if (sayi2 != 0)
                    {
                        Console.WriteLine("Sonuç: " + (sayi1 / (double)sayi2));
                    }
                    else
                    {
                        Console.WriteLine("Bir sayıyı 0'a bölemezsiniz!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi!");
                    break;
            }
        }
    }
}
