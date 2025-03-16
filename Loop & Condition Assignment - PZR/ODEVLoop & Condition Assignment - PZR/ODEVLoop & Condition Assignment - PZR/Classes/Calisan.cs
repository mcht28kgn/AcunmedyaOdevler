using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEVLoop___Condition_Assignment___PZR.Classes
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
}
