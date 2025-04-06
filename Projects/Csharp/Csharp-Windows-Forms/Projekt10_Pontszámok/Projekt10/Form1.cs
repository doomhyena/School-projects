using System;
using System.IO;
using System.Data;
using System.Text;

namespace Projekt10
{
    public partial class Form1 : Form
    {
        //Általánosan elérhetõ változók (névnek, pontszámank, indexnek):
        String[] Nev = new string[1];
        double[] Pontszam = new double[1];
        int num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tiKilep_Click(object sender, EventArgs e)
        { //Kilépés menüpont
            Close();
        }

        private void fejlec()
        { //A fejléc felirat lesz a szövegdoboz tetejénél
            rtbMezo.AppendText("Játékos pontszámok:" + "\n");
            rtbMezo.AppendText("(ezek a rekordok)" + "\n\n");
            rtbMezo.AppendText("Név                                 Pontszám" + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        { //A program indításakor ezek futnak le
            //Fejléc szöveg berakása a dobozba:
            fejlec();
            //Fájl beolvasása:
            string path = @"AlienInvaders.dat";
            StreamReader szovegBe = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));
            //A beolvasás ideje alatt ne lehessen rendezgetni az adatokat:
            tiNev.Enabled = false;
            tiPont.Enabled = false;
            //Sorok felépítése:
            while (szovegBe.Peek() != -1)
            {
                //Tömbök újraméretezése:
                Array.Resize<string>(ref Nev, Nev.Length + 1);
                Array.Resize<double>(ref Pontszam, Pontszam.Length + 1);
                //Rekordok beolvasása és tömbhöz adása:
                string sor = szovegBe.ReadLine();
                string[] rekord = sor.Split(',');
                Nev[num] = rekord[0];
                Pontszam[num] = Convert.ToDouble(rekord[1]);
                num++;
            }
            //File bezárása a mûvelet végén:
            szovegBe.Close();
            Array.Resize<string>(ref Nev, Nev.Length - 1);
            Array.Resize<double>(ref Pontszam, Pontszam.Length - 1);
        }

        private void tiBetolt_Click(object sender, EventArgs e)
        { //Betöltés mûvelete
            //Esetleges elõzõ tartalom kivétele:
            rtbMezo.Clear();
            fejlec();
            //Egy ciklussal beolvasunk minden adatot a dobozba:
            for (int i = 0; i < Nev.GetUpperBound(0); i++)
            {
                rtbMezo.AppendText(Nev[i].PadRight(25) + Pontszam[i].ToString("n0").PadLeft(10) + "\n");
            }
            //Ne lehessen újra betölteni a következõ módosításig:
            tiBetolt.Enabled = false;
            //A betöltés után legyen újra elérhetõ a 2 rendezési opció:
            tiNev.Enabled = true;
            tiPont.Enabled = true;
        }

        private void tiNev_Click(object sender, EventArgs e)
        { //Rendezés név alapjén
            for (int i = 0; i < Nev.GetUpperBound(0); i++)
            {
                for (int j = 0; j < Nev.GetUpperBound(0) - i; j++)
                {
                    int k = j + 1;
                    //Sorrend cseréje, ha az aktuális helyen szükséges:
                    if (string.Compare(Nev[j], Nev[k]) >= 0)
                    {
                        string nevSeged = Nev[j];
                        Nev[j] = Nev[k];
                        Nev[k] = nevSeged;
                        double pontSeged = Pontszam[j];
                        Pontszam[j] = Pontszam[k];
                        Pontszam[k] = pontSeged;
                    }
                }
            }
            //Meg is kell jeleníteni az újrarendezett listát az eddigi helyén:
            //Elõzõ tartalom kiürítése:
            rtbMezo.Clear();
            fejlec();
            //Új tartalom berakása soronként:
            for (int i = 0; i < Nev.GetUpperBound(0); i++)
            {
                rtbMezo.AppendText(Nev[i].PadRight(25) + Pontszam[i].ToString("n0").PadLeft(10) + "\n");
            }
        }

        private void tiPont_Click(object sender, EventArgs e)
        { //Rendezés pontszám alapján
            for (int i = 0; i < Nev.GetUpperBound(0); i++)
            {
                for (int j = 0; j < Nev.GetUpperBound(0) - i; j++)
                {
                    int k = j + 1;
                    if (Pontszam[j] < Pontszam[k])
                    {
                        double pontSeged = Pontszam[j];
                        Pontszam[j] = Pontszam[k];
                        Pontszam[k] = pontSeged;
                        string nevSeged = Nev[j];
                        Nev[j] = Nev[k];
                        Nev[k] = nevSeged;
                    }
                }
            }

            rtbMezo.Clear();
            fejlec();
            for (int i = 0; i < Nev.GetUpperBound(0); i++)
            {
                rtbMezo.AppendText(Nev[i].PadRight(25) + Pontszam[i].ToString("n0").PadLeft(10) + "\n");
            }
        }
    }
}
