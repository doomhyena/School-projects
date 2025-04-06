using System;
using System.Data;
using System.Text;
using System.IO;
using System.Globalization;

namespace Projekt12_NépességStat
{
    public partial class Form1 : Form
    {
        //Általános segédváltozók:
        String[] megye = new string[1]; //string[1] --> 1 elemű string tömb
        double[] nepesseg = new double[1];
        double[] terulet = new double[1];
        double[] suruseg = new double[1];
        double[] gyerekSzazalek = new double[1];
        int[] gyerekek = new int[1];
        int num = 0;
        double teljesNepesseg = 0;
        double teljesTerulet = 0;
        double teljesSuruseg = 0;
        double osszGyerekSzazlek = 0;
        double osszesGyerek = 0;
        string nepsurusegString = "";

        public Form1()
        {
            InitializeComponent();

            //Fájl beolvasása:
            string path = @"SDCounties.dat";
            StreamReader szovegBe = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));
            //Egyelőre ne lehessen reportokat kérni:
            miGyerekek.Enabled = false;
            miNepsuruseg.Enabled = false;
            //Rekordok feldolgozása soronként:
            while (szovegBe.Peek() != -1) //"Ameddig nem ér az adathalmaz végére..."
            {
                //Tömbök növelése/újraméretezése plusz 1 elemmel az új rekord számára:
                Array.Resize<string>(ref megye, megye.Length + 1);
                Array.Resize<double>(ref terulet, terulet.Length + 1);
                Array.Resize<int>(ref gyerekek, gyerekek.Length + 1);
                Array.Resize<double>(ref nepesseg, nepesseg.Length + 1);
                Array.Resize<double>(ref suruseg, suruseg.Length + 1);
                Array.Resize<double>(ref gyerekSzazalek, gyerekSzazalek.Length + 1);
                //Új rekordok behelyetése a tömbbe:
                string sor = szovegBe.ReadLine();
                string[] rekord = sor.Split(',');
                megye[num] = rekord[0];
                nepesseg[num] = Convert.ToDouble(rekord[1]);
                terulet[num] = Convert.ToDouble(rekord[2]);
                gyerekek[num] = Convert.ToInt32(rekord[3]);
                suruseg[num] = nepesseg[num] / terulet[num]; //beolvasás helyrtt kiszámoljuk
                gyerekSzazalek[num] = gyerekek[num] / nepesseg[num];
                num++;
            }
            //Fájl bezársa:
            szovegBe.Close();
            //További számítások:
            for (int i = 0; i < megye.GetUpperBound(0); i++)
            {
                teljesNepesseg = teljesNepesseg + nepesseg[i];
                teljesTerulet = teljesTerulet + terulet[i];
                teljesSuruseg = teljesNepesseg / teljesTerulet;
                nepsurusegString = megye[i].PadRight(15) + nepesseg[i].ToString("n0").PadLeft(10) +
                    terulet[i].ToString("n0").PadLeft(10) + suruseg[i].ToString("f1").PadLeft(10) + "\n";
            }
            rtbMezo.AppendText("Adatok: " + teljesNepesseg.ToString("n0").PadLeft(17) +
                teljesTerulet.ToString("n0").PadLeft(10) + teljesSuruseg.ToString("f1").PadLeft(10) + "\n");
        }

        private void miKilep_Click(object sender, EventArgs e)
        { //Kilépés opció
            this.Close(); //this = aktuális ablak példány
        }

        private void miBetolt_Click(object sender, EventArgs e)
        { //Betöltés opció:
            //Változók nullázása:
            teljesNepesseg = 0;
            teljesTerulet = 0;
            //Fejléc összerakása:
            rtbMezo.Clear();
            rtbMezo.AppendText("            Állam népessége" + "\n");
            rtbMezo.AppendText("            Statisztikai report" + "\n\n");
            rtbMezo.AppendText("                Gyerekek száma" + "\n");
            rtbMezo.AppendText("Megye   Népesség    Terület     Gyerekszám" + "\n");
            //Rekordok listázása a dobozban:
            for (int i = 0; i < megye.GetUpperBound(0); i++)
            {
                teljesNepesseg = teljesNepesseg + nepesseg[i];
                teljesTerulet = teljesTerulet + terulet[i];
                osszesGyerek = osszesGyerek + gyerekek[i];
                rtbMezo.AppendText(megye[i].PadRight(15) + nepesseg[i].ToString("n0").PadLeft(10) +
                    terulet[i].ToString("n0").PadLeft(10) + gyerekek[i].ToString("f1").PadLeft(10) + "\n");
            }
            //Összesített adatok:
            rtbMezo.AppendText("Összesítve: " + teljesNepesseg.ToString("n0").PadLeft(17) +
                teljesTerulet.ToString("n0").PadLeft(10) + osszesGyerek.ToString("f1").PadLeft(10) + "\n");
            //Gombo állítgatása:
            miBetolt.Enabled = false;
            miGyerekek.Enabled = true;
            miNepsuruseg.Enabled = true;
        }

        private void miNepsuruseg_Click(object sender, EventArgs e)
        { //Népsűrűség reportolása
            //Segédváltozók nullázása:
            teljesNepesseg = 0;
            teljesTerulet = 0;
            teljesSuruseg = 0;
            //Szövegdoboz formázása:
            rtbMezo.Clear();
            rtbMezo.AppendText("            Állami népesség" + "\n");
            rtbMezo.AppendText("            Statisztikai jelentés" + "\n\n");
            rtbMezo.AppendText("Megye       Népesség    Terület     Sűrűség" + "\n");
            rtbMezo.AppendText(nepsurusegString);
        }

        private void miGyerekek_Click(object sender, EventArgs e)
        { //Gyerekek reportolása:
            //Segédváltozók nullázása:
            teljesNepesseg = 0;
            teljesTerulet = 0;
            osszGyerekSzazlek = 0;
            osszesGyerek = 0;
            //Szövegdoboz formázása:
            rtbMezo.Clear();
            rtbMezo.AppendText("            Állami népesség" + "\n");
            rtbMezo.AppendText("            Statisztikai jelentés" + "\n\n");
            rtbMezo.AppendText("Megye       Népesség    Gyerekek     Százalék" + "\n");
            //Jelentés felépítése:
            for (int i = 0; i < megye.GetUpperBound(0); i++)
            {
                teljesNepesseg = teljesNepesseg + nepesseg[i];
                teljesTerulet = teljesTerulet + terulet[i];
                osszesGyerek = osszesGyerek + gyerekek[i];
                osszGyerekSzazlek = osszesGyerek / teljesNepesseg;
                rtbMezo.AppendText(megye[i].PadRight(15) + nepesseg[i].ToString("n0").PadLeft(10) +
                    terulet[i].ToString("n0").PadLeft(10) + gyerekSzazalek[i].ToString("p1") + "\n");
            }
            //Lezáró összesítés a teljes népességre, összes gyerekkel, azok százalékával:
            rtbMezo.AppendText("Összesítve: " + teljesNepesseg.ToString("n0").PadLeft(17) + 
                osszesGyerek.ToString("n0").PadLeft(10) + osszGyerekSzazlek.ToString("p1").PadLeft(10) + "\n");
        }
    }
}
