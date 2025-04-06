using System;
using System.IO;
using System.Data;
using System.Text;
using System.DirectoryServices.ActiveDirectory;

namespace Projekt11
{
    public partial class Form1 : Form
    {
        //Segédváltozó:
        String[] nev = new string[1];
        int[] ules = new int[1];
        String[] tipus = new string[1];
        int[] ertekeles = new int[1];
        int num = 0;
        string key = ""; //kulcs

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { //Ez a program betöltésekor fut le:
            //Fájlkezelés:
            string path = @"Restaurants.dat";
            StreamReader szovegBe = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));

            //Beolvasás:
            while (szovegBe.Peek() != -1)
            {
                //Tömbök újraméretezése az érkezõ rekordoknak:
                Array.Resize<string>(ref nev, nev.Length + 1);
                Array.Resize<int>(ref ules, ules.Length + 1);
                Array.Resize<string>(ref tipus, tipus.Length + 1);
                Array.Resize<int>(ref ertekeles, tipus.Length + 1);
                //Új rekord behelyezése a tömbökbe:
                string sor = szovegBe.ReadLine();
                string[] rekord = sor.Split(",");
                nev[num] = rekord[0];
                ules[num] = Convert.ToInt32(rekord[1]);
                tipus[num] = rekord[2];
                ertekeles[num] = Convert.ToInt32(rekord[3]);
                //Továbblépéshez:
                num = num + 1;
            }
            //Fájl bezárása:
            szovegBe.Close();
            num = 0;
            //Kis szövegdoboz feltöltése a rekordokkal:
            fejlec();
            for (int i = 0; i < nev.GetUpperBound(0); i++)
            {
                //Típus doboz feltöltése (minden tipus csak egyszer szerepeljen:
                num++;
                if (key != tipus[i])
                {
                    lbTipus.Items.Add(tipus[i]);
                    key = tipus[i];
                }
                //Nagy szövegdoboz feltöltése az összes étterem rekorddal:
                rtbMezo.AppendText(nev[i].PadRight(25) + ules[i].ToString("n0").PadLeft(6)
                    + tipus[i].PadLeft(10) + ertekeles[i].ToString("n0").PadLeft(10) + "\n");
            }
            lRekordszam.Text = num.ToString("n0"); //Találatok számának kiírása
        }
        //Sablon fejléc a dobozba:
        public void fejlec()
        {
            rtbMezo.Clear();
            rtbMezo.AppendText("Étterem keresõ lista" + "\n");
            rtbMezo.AppendText("Keresés" + "\n\n");
            rtbMezo.AppendText("Név         Ülések      Típus       Értékelés" + "\n");
        }

        private void btnKeres_Click(object sender, EventArgs e)
        { //Keresés gomb:
            string keresett = tbKeres.Text; //A beírt szöveg, amire szûrünk
            num = 0;
            fejlec();
            for (int i = 0; i < nev.GetUpperBound(0); i++)
            {   //Csak a keresett névnek megfelelõ étterem rekordok listázódjnak:
                if (keresett.ToUpper() == nev[i].ToUpper()) //Kis-nagy betû eltérések kiküszöbölése
                {
                    num++;
                    rtbMezo.AppendText(nev[i].PadRight(25) + ules[i].ToString("n0").PadLeft(6)
                    + tipus[i].PadLeft(10) + ertekeles[i].ToString("n0").PadLeft(10) + "\n");
                }
                lRekordszam.Text = num.ToString("n0"); //Találatok számának kiírása
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        { //Kilépés gomb:
            this.Close();
        }

        private void lbTipus_SelectedIndexChanged(object sender, EventArgs e)
        { //Szûrés típus alapján (csak azokat listázza újra, amik olyan típusú éttermek):
            string valasztottElem = Convert.ToString(lbTipus.SelectedItem);
            num = 0;
            fejlec();
            for (int i = 0; i < nev.GetUpperBound(0); i++)
            {
                if (valasztottElem == tipus[i]) //Csak ha ilyan típusú
                {
                    num++;
                    rtbMezo.AppendText(nev[i].PadRight(25) + ules[i].ToString("n0").PadLeft(6)
                    + tipus[i].PadLeft(10) + ertekeles[i].ToString("n0").PadLeft(10) + "\n");
                }
                lRekordszam.Text = num.ToString("n0"); //Találatok számának kiírása
            }
        }

        private void nudErt_ValueChanged(object sender, EventArgs e)
        { //Minimum értékelés szerinti szûrés
            int minimumErtekeles = Convert.ToInt32(nudErt.Value);
            num = 0;
            fejlec();
            for (int i = 0; i < nev.GetUpperBound(0); i++)
            {
                if (minimumErtekeles <= ertekeles[i])
                {
                    num++;
                    rtbMezo.AppendText(nev[i].PadRight(25) + ules[i].ToString("n0").PadLeft(6)
                    + tipus[i].PadLeft(10) + ertekeles[i].ToString("n0").PadLeft(10) + "\n");
                }
            }
            lRekordszam.Text = num.ToString("n0");
        }
    }
}
