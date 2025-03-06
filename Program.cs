﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Dersleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello World");
            //Console.Write("Benim adım İrem Özdemir");

            //Console.WriteLine("Kişi tanıtım kartı");
            //Console.WriteLine();
            //Console.WriteLine("Adınız: İrem");
            //Console.WriteLine("Soyadınız: Özdemir");
            //Console.WriteLine("Mesleğiniz: Öğrenci");

            //Değişkenler
            //Bellek --> Ram Geçici Bellek
            //Sayısal,Alfabetik,Lojik Veriler,Karakter...

            //string

            //Değişken_Türü  Değişken_ismi

            //string city;
            //city = "Dublin";
            //Console.Write(city);

            //string capital, country;
            //capital = "Ankara";
            //country = "Türkiye";
            //Console.Write(capital + " " + country);

            //camel Case
            //string nameSurname;
            //nameSurname = "İrem Özdemir";
            //Console.Write(nameSurname);

            //string job;
            //job = "Software Engineer";
            //Console.Write("Meslek:" + job);

            //int değişkenler

            //int number;
            //number = 20;
            //Console.Write(number);

            //int n1, n2, total;
            //n1 = 40;
            //n2 = 85;
            //total = n1 + n2;
            //Console.Write(total);

            //int number1, number2, addition, extraction, multiplication, division;
            //number1 = 20;
            //number2 = 5;
            //addition = number1 + number2;
            //extraction = number1 - number2;
            //multiplication = number1 * number2;
            //division = number1 / number2;
            //Console.WriteLine("Toplam: " + addition);
            //Console.WriteLine("Fark: " + extraction);
            //Console.WriteLine("Çarpım: " + multiplication);
            //Console.WriteLine("Bölüm: " + division);

            Console.Write("Lütfen adınızı yazınız: ");
            string ad;
            ad = Console.ReadLine();

            Console.Write("Hoş geldiniz " + ad);

            string ulke, sehir;
            Console.Write("Ülke: ");
            ulke = Console.ReadLine();
            Console.Write("Şehir: ");
            sehir = Console.ReadLine();

            Console.Write(ulke + " " + sehir);

            //Convert Cast
            //Convert.DönüşümTürü(Dönüştürelecek_Değer);

            int sayi;
            Console.Write("Sayıyı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            Console.Write(sayi);

            int s1;
            Console.Write("Sayıyı girin: ");
            s1 = Convert.ToInt16(Console.ReadLine());

            Console.Write(s1);

            int s1, s2, sonuc;
            Console.Write("Sayı 1: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 2: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            sonuc = s1 + s2;

            Console.Write("Toplam: " + sonuc);

            int kisa, uzun, alan, cevre;
            Console.Write("Kısa Kenar: ");
            kisa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun Kenar: ");
            uzun = Convert.ToInt32(Console.ReadLine());
            alan = kisa * uzun;
            cevre = 2 * (kisa + uzun);
            Console.Write("Alan: " + alan + " Çevre: " + cevre);


            //double
            double sayi = 4.008969;
            Console.Write(sayi);

            double s1, s2, s3;
            double ort;
            Console.Write("Sınav1:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sınav2:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sınav3:");
            s3 = Convert.ToInt32(Console.ReadLine());
            ort = (s1 + s2 + s3) / 3;
            Console.Write("Ortalama:" + ort);

            Console.Write("Sayıyı giriniz:");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.Write(sayi);

            //char değişkenler
            char sehir;
            sehir = 'a';
            Console.Write(sehir);

            char karakter;
            Console.Write("Karakter girişi yapınız:");
            karakter = Convert.ToChar(Console.ReadLine());
            Console.Write(karakter);

            //Karar Yapıları
            //if else
            //if the weather is rainy
            //you take your umbrella
            //else
            //you don't take your umbrella

            //şifre kontrolü
            //operatör == eşit mi
            //scope

            string sifre;
            Console.Write("Şifreyi giriniz:");
            sifre = Console.ReadLine();
            if (sifre == "abcd")
            {
                Console.Write("Şifre başarılı, sisteme hoş geldiniz.");
            }
            else
            {
                Console.Write("Şifre hatalı, lütfen tekrar deneyiniz.");
            }

            int s1, s2, ort;
            string durum;
            Console.Write("Sınav1:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sınav2:");
            s2 = Convert.ToInt32(Console.ReadLine());
            ort = (s1 + s2) / 2;
            if (ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            Console.Write("Öğrenci Ortalaması:" + ort + " Öğrenci Sınav Durumu:" + durum);

            //Operatörler
            /*
            
            == eşit mi
            <= küçük veya eşit mi
            >= büyük veya eşit mi
            !=eşit değilse
            && ve
            || veya
            = atama
            + - * / aritmetik operatörler
            % mod   (10%3 ==> 1)

            */

            string kullanici, sifre;
            Console.Write("Kullanıcı Adı:");
            kullanici = Console.ReadLine();
            Console.Write("Şifre:");
            sifre = Console.ReadLine();
            if (kullanici == "admin" && sifre == "1234")
            {
                Console.Write("Giriş Başarılı");
            }
            else
            {
                Console.Write("Giriş Hatalı");
            }

            string anahtar;
            Console.Write("Anahtar kelimeyi girin:");
            anahtar = Console.ReadLine();
            if (anahtar != "muğla" || anahtar != "istanbul" || anahtar != "balıkesir")
            {
                Console.Write("İşlem başarılı");
            }
            else
            {
                Console.Write("İşlem hatalı");
            }


            int sonuc = 25 % 4;
            Console.Write(sonuc);


            int s1, s2, s3;
            int ortalama;
            string durum;

            Console.Write("Lütfen Sınav1 Notunu Girin:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Sınav2 Notunu Girin:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Sınav3 Notunu Girin:");
            s3 = Convert.ToInt32(Console.ReadLine());

            ortalama = (s1 + s2 + s3) / 3;
            if (ortalama <= 49)
            {
                durum = "Kötü";
                Console.Write(durum);
            }
            if (ortalama > 49 && ortalama <= 70)
            {
                durum = "Orta";
                Console.Write(durum);
            }
            if (ortalama > 70)
            {
                durum = "İyi";
                Console.Write(durum);
            }

            Console.Write("Sayıyı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.Write("Çift sayı");
            }
            else
            {
                Console.Write("Tek sayı");
            }

            //Switch Case

            //0 - 35  36 - 50  51 - 70  71 - 85  86 - 100

            //örnekler

            string fruit;
            Console.Write("Enter your fruit name:");
            fruit = Console.ReadLine();
            switch (fruit)
            {
                case "apple": Console.Write("elma"); break;
                case "orange": Console.Write("portakal"); break;
                case "strawberry": Console.Write("çilek"); break;
                case "melon": Console.Write("kavun"); break;
                default: Console.Write("bulunamadı"); break;
            }

            int s1, s2, s3, ort;
            Console.Write("Sınav1:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sınav2:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sınav3:");
            s3 = Convert.ToInt32(Console.ReadLine());
            ort = (s1 + s2 + s3) / 3;
            switch (ort)
            {
                case 50: Console.Write("Kötü"); break;
                case 75: Console.Write("Orta"); break;
                case 100: Console.Write("İyi"); break;
            }


            //Döngüler

            //For - While - Do While - Foreach

            //++ operatörü değeri 1 arttırır.

            //For
            //1:Başlangıç 2:Bitiş 3:Artış - Azalış Miktarı



            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Merhaba Dünya");
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }



            Console.ReadLine();
        }
    }
}
