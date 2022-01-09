using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar ={"kedi","köpek","kuş","maymun"};
            int[] dizi;
            dizi =new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] =10;
            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine(hayvanlar[1]);
            System.Console.WriteLine(renkler[0]);

            //Döngüler ile dizi kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            System.Console.WriteLine("Lütfen Dizinin Eleman Sayısını Giriniz");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int [] sayiDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                System.Console.WriteLine("Lütfen {0}. sayıyı giriniz", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var item in sayiDizisi)
            {
                toplam += item;
            }
            System.Console.WriteLine("Ortalama : "+ toplam/diziUzunlugu);

        }
    }
}
