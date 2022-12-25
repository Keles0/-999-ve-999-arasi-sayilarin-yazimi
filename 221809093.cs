// -999 ve 999 arasındaki sayıları yazı ile yazdırır.
using System;
namespace or214
{
    class Program
    {
        public static void Main(string[] args)
        {
            short a;
            string t="";
            string s = " ";
            int b = 0;
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] Yuzler = { "Yüz", "İkiYüz", "ÜçYüz", "DörtYüz", "BeşYüz", "AltıYüz", "YediYüz", "SekizYüz", "DokuzYüz" };
            Console.Write("Bir Sayı Giriniz: ");//-999 ve 999 arası
            a = short.Parse(Console.ReadLine());
            while (a > 999 || a < -999)// doğru sayı aralığında olup olmadığını teyit için whıle döngüsü
            {
                Console.Write("-999 ve 999 aralığında değer giriniz\n");
                a = short.Parse(Console.ReadLine()); // -999 ve 999 arası
            }

            if (a < 0)// eğer sayı negatif ise eksi yazdır ve kod üstünde pozitif sayıya dönüştür
            {
                t = "Eksi";
                int p = a * -1;
                a = (short)p;


            }
            if (a / 100 >= 1)
            { //sayı üç basamaklı ise yüzler stringden gerekli olan elemanı al

                s = Yuzler[(a / 100) - 1];

                b = a % 100;// onlar stringi için mod alma
            }

            b = a % 100;

            if (b / 10 >= 1)
            { 

                s = s + Onlar[(b / 10) - 1];
            }//sayı iki basamaklı ise onlar stringden gerekli olan elemanı al // mod
            if (b % 10 != 0)
            { //Sayının son basamağı sıfır değilse yaz 65 % 10 = 5-1 
                s = s + Birler[(b % 10) - 1];
            }//s= sayı bir basamaklı ise birler stringden gerekli olan elemanı al // mod

            Console.WriteLine(t+s);//yüzonaltı-seksensekiz- eksidokuzyüzdoksandokuz
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}