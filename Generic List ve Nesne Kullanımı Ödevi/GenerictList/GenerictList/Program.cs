// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

using GenerictList;
using System;
using System.Collections.Generic;

namespace GenerictList;

public class Program
{

    static void Main(string[] args)
    {

        List<Car> cars = new List<Car>();

        while (cars.Count < 3 || DevamEtmekIstiyorMu())
        {
            Console.Write("Marka Adı: ");
            string markaAdi = Console.ReadLine();

            Console.Write("Model Adı: ");
            string modelAdi = Console.ReadLine();

            Console.Write("100 km de Yaktığı  Yakıt (L): ");
            string benzinHarcamasi = double.Parse(Console.ReadLine());

            Console.Write("Toplam Gidilen Mesafe (km): ");
            int toplamMesafe = int.Parse(Console.ReadLine());

            Marka marka = new Marka { Id = cars.Count + 1, Name = markaAdi, ImageUrl = $"{markaAdi.ToLower()}.jpg" };
            Model model = new Model { Id = cars.Count + 1, Name = modelAdi, ImageUrl = $"{modelAdi.ToLower()}.jpg" };
            Car car = new Car(marka, model, benzinHarcamasi, toplamMesafe);

            cars.Add(car);


        }

        Console.WriteLine("\n--- Eklenen Arabalar ---");
        foreach (var car in cars)
        {

            Console.WriteLine($"Marka: {car.Marka.Name}, Model: {car.Model.Name}, 100 km de yaktığı yakıt:
             { car.BenzinHarcamasi}, Toplam Mesafe: { car.ToplamMesafe}, Toplam Yakıt Tüketimi: { car.Hesapla():0.00} L");


    }

        static bool DevamEtmekIstiyorMu()
        {
            Console.Write("Yeni Bir Araba Eklemek İstermisniz? (e/h): ");
            string cevap = Console.ReadLine().ToLower();
            return cevap == "e";
        }
    }

}