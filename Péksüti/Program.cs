using System;
using System.Collections.Generic;
using System.Linq;

namespace PekaruAlkalmazas
{
    // 3. Főprogram
    class Program
    {
        static void Main(string[] args)
        {
            // Legalább 5 db példány létrehozása Pekaru és Kenyerek osztályokból
            var pekaruk = new List<Pekaru>
            {
                new Pekaru("Barackos Túrós párna", true, 299, true),
                new Pekaru("Sajtos rúd", false, 259, false),
                new Pekaru("Kakaós csiga", true, 279, false),
                new Kenyerek("Házi Vekni", 459, false, 800),
                new Kenyerek("Teljes kiőrlésű kenyér", 690, true, 1000),
                new Kenyerek("Rozskenyér", 520, false, 700)
            };

            Console.WriteLine("=== Pékáruk listája ===");
            foreach (var p in pekaruk)
            {
                Console.WriteLine(p.ToString());
            }

            // 1. Mennyibe kerülnek a listában lévő Pékáruk, ha mindenből kettőt veszek?
            double osszAr = pekaruk.Sum(p => p.Ar() * 2);
            Console.WriteLine();
            Console.WriteLine($"1. Ha mindenből kettőt veszek, összesen {osszAr} Ft-ba kerülnek a pékáruk.");

            // 2. Csak a NEM kenyereket jelenítsd meg!
            Console.WriteLine();
            Console.WriteLine("2. A NEM kenyér típusú pékáruk:");
            foreach (var p in pekaruk.Where(p => !(p is Kenyerek)))
            {
                Console.WriteLine(p.ToString());
            }

            // 3. Melyik a legolcsóbb kenyér a listában?
            var legolcsobbKenyer = pekaruk.OfType<Kenyerek>().OrderBy(k => k.Ar()).FirstOrDefault();
            Console.WriteLine();
            if (legolcsobbKenyer != null)
            {
                Console.WriteLine($"3. A legolcsóbb kenyér: {legolcsobbKenyer}");
            }
            else
            {
                Console.WriteLine("3. Nincs kenyér a listában.");
            }

            Console.WriteLine();
            Console.WriteLine("Nyomj meg egy billentyűt a kilépéshez...");
            Console.ReadKey();
        }
    }
}
