using System;

class Program
{
    static void Main()
    {
      
        Random random = new Random();
        int sayi = random.Next(1, 101);  

       
        int tahminSayisi = 0;

        Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz! 1 ile 100 arasında bir sayı tuttum.");
        Console.WriteLine("Tahmin etmeye başlayın.");

   
        while (true)
        {
       
            Console.Write("Tahmininizi girin: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            tahminSayisi++;

           
            if (tahmin < sayi)
            {
                Console.WriteLine("Tahmininiz çok küçük! Daha büyük bir sayı söyleyin.");
            }
            else if (tahmin > sayi)
            {
                Console.WriteLine("Tahmininiz çok büyük! Daha küçük bir sayı söyleyin.");
            }
            else
            {
                Console.WriteLine($"Tebrikler! {tahminSayisi}. denemede doğru tahmin ettiniz.");
                break;
            }
        }

        Console.WriteLine($"Oyun bitti. Toplamda {tahminSayisi} tahminde doğru sayıyı buldunuz.");
    }
}
