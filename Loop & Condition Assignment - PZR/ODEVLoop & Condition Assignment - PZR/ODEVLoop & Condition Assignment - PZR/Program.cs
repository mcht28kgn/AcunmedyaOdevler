//1.ÖDEV

/*
using System;

namespace YasKategorisi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yaşınızı girin: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            string sonuc = YasKategoriBelirle(yas);
            Console.WriteLine(sonuc);

            Console.ReadLine(); 
        }

        static string YasKategoriBelirle(int yas)
        {
            if (yas < 0 || yas > 99)
            {
                return "Ya hiç doğmadınız ya da çoktan öldünüz...";
            }
            else if (yas >= 0 && yas < 18)
            {
                return "Küçüksünüz";
            }
            else if (yas >= 18 && yas < 35)
            {
                return "Gençsiniz";
            }
            else if (yas >= 35 && yas < 55)
            {
                return "Yetişkinsiniz";
            }
            else if (yas >= 55 && yas < 75)
            {
                return "Yaşlısınız";
            }
            else 
            {
                return "Çok yaşlısınız";
            }
        }
    }
}
*/


//2.ÖDEV

/*
using System;

namespace ArabaDurumu
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Arabanızın yaşını girin: ");
            int arabaYasi = Convert.ToInt32(Console.ReadLine());

            string durum = ArabaDurumunuBelirle(arabaYasi);
            Console.WriteLine(durum);

            Console.ReadLine(); 
        }

        static string ArabaDurumunuBelirle(int yas)
        {
            if (yas < 0 || yas > 30)
            {
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            }
            else if (yas >= 0 && yas < 10)
            {
                return "Arabanız yeni";
            }
            else if (yas >= 10 && yas < 20)
            {
                return "Servise götürmeniz gerekebilir";
            }
            else 
            {
                return "Arabanız hurdaya çıkabilir";
            }
        }
    }
}
*/


// 3.ÖDEV ARAŞTIRMA ÖDEVİ 

//4.ÖDEV

/*


using System;
using System.Collections.Generic;

namespace CalisanMaasHesaplama
{
    
    public class Calisan
    {
        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Meslek { get; set; }
        public string Departman { get; set; }
        public double Maas { get; set; }

        
        public Calisan(string ad, string soyad, string meslek, string departman, double maas)
        {
            Ad = ad;
            Soyad = soyad;
            Meslek = meslek;
            Departman = departman;
            Maas = maas;
        }

        
        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad: {Ad} | Soyad: {Soyad} | Meslek: {Meslek} | Departman: {Departman} | Maaş: {Maas} TL");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Calisan> calisanlar = new List<Calisan>();

            
            calisanlar.Add(new Calisan("Ahmet", "Yılmaz", "Genel Müdür", "Yönetim", 50000));
            calisanlar.Add(new Calisan("Ayşe", "Kara", "Müdür", "Pazarlama", 30000));
            calisanlar.Add(new Calisan("Mehmet", "Demir", "Programcı", "Yazılım", 20000));
            calisanlar.Add(new Calisan("Zeynep", "Çelik", "Stajyer", "Yazılım", 5000));

            double toplamMaas = 0;

            Console.WriteLine("ÇALIŞAN LİSTESİ:\n");

            
            foreach (var calisan in calisanlar)
            {
                calisan.BilgileriGoster();
                toplamMaas += calisan.Maas;
            }

            Console.WriteLine("\n-----------------------------");
            Console.WriteLine($"Toplam Ödenen Maaş: {toplamMaas} TL");

            Console.ReadLine(); 
        }
    }
}
*/

//5.ÖDEV

using System;
using System.Collections.Generic;


public class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public double BenzinTuketimi { get; set; } 
    public double Mesafe { get; set; } 

    
    public Araba(string marka, string model, double benzinTuketimi, double mesafe)
    {
        Marka = marka;
        Model = model;
        BenzinTuketimi = benzinTuketimi;
        Mesafe = mesafe;
    }

    
    public double HesaplaBenzinTuketimi()
    {
       
        return (Mesafe * BenzinTuketimi) / 100;
    }

   
    public void ArabaBilgileriniYazdir()
    {
        Console.WriteLine($"{Marka} {Model} - Benzin Tüketimi: {BenzinTuketimi} L/100km, Gidilen Mesafe: {Mesafe} km");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        List<Araba> arabalar = new List<Araba>
        {
            new Araba("Toyota", "Corolla", 6.5, 500),  
            new Araba("Ford", "Focus", 7.0, 300),     
            new Araba("Honda", "Civic", 5.8, 100),    
            new Araba("BMW", "3 Series", 8.2, 400)   
        };

        double toplamBenzinTuketimi = 0;

        
        foreach (var araban in arabalar)
        {
            araban.ArabaBilgileriniYazdir();
            double benzinTuketimi = araban.HesaplaBenzinTuketimi();
            Console.WriteLine($"Toplam Benzin Tüketimi: {benzinTuketimi} L\n");
            toplamBenzinTuketimi += benzinTuketimi;
        }

      
        Console.WriteLine($"Tüm Arabaların Toplam Benzin Tüketimi: {toplamBenzinTuketimi} L");
        Console.ReadLine();
    }
}

