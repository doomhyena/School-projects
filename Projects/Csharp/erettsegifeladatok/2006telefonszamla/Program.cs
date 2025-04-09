using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006telefonszamla
{
    public class Hivas
    {
        public string Telefonszam { get; set; }
        public TimeSpan Kezdet { get; set; }
        public TimeSpan Veg { get; set; }

        public Hivas(string telefonszam, TimeSpan kezdet, TimeSpan veg)
        {
            Telefonszam = telefonszam;
            Kezdet = kezdet;
            Veg = veg;
        }

        public int SzamlazottPercek()
        {
            return (int)Math.Ceiling((Veg - Kezdet).TotalMinutes);
        }

        public bool IsMobil()
        {
            var mobilPrefixek = new List<string> { "39", "41", "71" };
            return mobilPrefixek.Contains(Telefonszam.Substring(0, 2));
        }

        public bool IsCsucsido()
        {
            return Kezdet >= new TimeSpan(7, 0, 0) && Kezdet < new TimeSpan(18, 0, 0);
        }
    }

    public class Szamlazas
    {
        private List<Hivas> Hivasok;

        public Szamlazas(string fajlNev)
        {
            Hivasok = new List<Hivas>();
            BeolvasHivasok(fajlNev);
        }
        private void BeolvasHivasok(string fajlNev)
        {
            var sorok = File.ReadAllLines(fajlNev);

            for (int i = 0; i < sorok.Length; i += 2)
            {
                try
                {
                    if (i + 1 >= sorok.Length)
                    {
                        Console.WriteLine($"Hibás adat: hiányos bejegyzés a fájl végén.");
                        break;
                    }

                    var idok = sorok[i].Split(' ');
                    if (idok.Length < 6)
                    {
                        Console.WriteLine($"Hibás sor: {sorok[i]}");
                        continue;
                    }

                    var kezdet = new TimeSpan(int.Parse(idok[0]), int.Parse(idok[1]), int.Parse(idok[2]));
                    var veg = new TimeSpan(int.Parse(idok[3]), int.Parse(idok[4]), int.Parse(idok[5]));

                    var telefonszam = sorok[i + 1].Trim();

                    Hivasok.Add(new Hivas(telefonszam, kezdet, veg));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hiba a sorok feldolgozása közben: {sorok[i]} és {sorok[i + 1]}. Hiba: {ex.Message}");
                }
            }
        }

        public void SzamlazottPercekFajlba(string fajlNev)
        {
            using (var sw = new StreamWriter(fajlNev))
            {
                foreach (var hivas in Hivasok)
                {
                    sw.WriteLine($"{hivas.SzamlazottPercek()} {hivas.Telefonszam}");
                }
            }
        }

        public void CsucsidoStat()
        {
            int csucsidoHivasok = 0, csucsidonKivuliHivasok = 0;

            foreach (var hivas in Hivasok)
            {
                if (hivas.IsCsucsido()) csucsidoHivasok++;
                else csucsidonKivuliHivasok++;
            }

            Console.WriteLine($"Csúcsidős hívások száma: {csucsidoHivasok}");
            Console.WriteLine($"Csúcsidőn kívüli hívások száma: {csucsidonKivuliHivasok}");
        }

        public void HivasTipusPercek()
        {
            int mobilPercek = 0, vezetekesPercek = 0;

            foreach (var hivas in Hivasok)
            {
                if (hivas.IsMobil()) mobilPercek += hivas.SzamlazottPercek();
                else vezetekesPercek += hivas.SzamlazottPercek();
            }

            Console.WriteLine($"Mobil hívások percei: {mobilPercek}");
            Console.WriteLine($"Vezetékes hívások percei: {vezetekesPercek}");
        }

        public void CsucsidoKoltseg()
        {
            double csucsidoKoltseg = 0;

            foreach (var hivas in Hivasok)
            {
                if (hivas.IsCsucsido())
                {
                    csucsidoKoltseg += hivas.SzamlazottPercek() * (hivas.IsMobil() ? 69.175 : 30);
                }
            }

            Console.WriteLine($"Csúcsidős hívások költsége: {csucsidoKoltseg:F2} Ft");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string fajlNev = "HIVASOK.txt";

            var szamlazas = new Szamlazas(fajlNev);

            Console.WriteLine("Adja meg a telefonszámot:");
            string telefonszam = Console.ReadLine();
            var telefonTipus = telefonszam.StartsWith("39") || telefonszam.StartsWith("41") || telefonszam.StartsWith("71") ? "Mobil" : "Vezetékes";
            Console.WriteLine($"A megadott telefonszám típusa: {telefonTipus}");

            szamlazas.SzamlazottPercekFajlba("percek.txt");
            szamlazas.CsucsidoStat();
            szamlazas.HivasTipusPercek();
            szamlazas.CsucsidoKoltseg();
            Console.ReadKey();
        }
    }
}
