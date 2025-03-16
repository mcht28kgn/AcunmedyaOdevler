using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEVLoop___Condition_Assignment___PZR.Classes
{
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
}
