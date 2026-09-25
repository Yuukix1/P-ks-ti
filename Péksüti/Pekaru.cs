using System.Globalization;

namespace PekaruAlkalmazas
{
    // 1. Pekaru osztály (ős osztály)
    public class Pekaru
    {
        public string Nev { get; set; }
        public bool Edes { get; set; }
        public double AlapAr { get; set; }
        public bool Akcios { get; set; }

        // Alapértelmezett konstruktor
        public Pekaru()
        {
            Nev = "Ismeretlen";
            Edes = false;
            AlapAr = 0;
            Akcios = false;
        }

        // Paraméteres konstruktor
        public Pekaru(string nev, bool edes, double alapAr, bool akcios)
        {
            Nev = nev;
            Edes = edes;
            AlapAr = alapAr;
            Akcios = akcios;
        }

        // Ár kiszámítása: akciós esetén féláron van
        public virtual double Ar()
        {
            return Akcios ? AlapAr / 2 : AlapAr;
        }

        public override string ToString()
        {
            string akciosSzoveg = Akcios ? "Akciós" : "Nem akciós";
            string edesSzoveg = Edes ? "Édes" : "Sós";

            return string.Format(CultureInfo.InvariantCulture,
                "Pékárú neve: {0}, {1}, {2}, Alapár: {3} Ft/db, Ár: {4}Ft/db",
                Nev, akciosSzoveg, edesSzoveg, AlapAr, Ar());
        }
    }
}
