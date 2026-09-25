using System.Globalization;

namespace PekaruAlkalmazas
{
    // 2. Kenyerek osztály
    public class Kenyerek : Pekaru
    {
        public int Suly { get; set; }

        public Kenyerek() : base()
        {
            Edes = false; // a kenyér sosem édes
            Suly = 0;
        }

        public Kenyerek(string nev, double alapAr, bool akcios, int suly)
            : base(nev, false, alapAr, akcios) // edes mindig false
        {
            Suly = suly;
        }

        public override string ToString()
        {
            string akciosSzoveg = Akcios ? "Akciós" : "Nem akciós";

            return string.Format(CultureInfo.InvariantCulture,
                "Pékárú neve: {0}, {1}, Súly: {2} g, Alapár: {3} Ft/db, Ár: {4}Ft/db",
                Nev, akciosSzoveg, Suly, AlapAr, Ar());
        }
    }
}
