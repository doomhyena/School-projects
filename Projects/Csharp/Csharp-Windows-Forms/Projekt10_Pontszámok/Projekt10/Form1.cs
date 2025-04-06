using System;
using System.IO;
using System.Data;
using System.Text;

namespace Projekt10
{
    public partial class Form1 : Form
    {
        //�ltal�nosan el�rhet� v�ltoz�k (n�vnek, pontsz�mank, indexnek):
        String[] Nev = new string[1];
        double[] Pontszam = new double[1];
        int num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tiKilep_Click(object sender, EventArgs e)
        { //Kil�p�s men�pont
            Close();
        }

        private void fejlec()
        { //A fejl�c felirat lesz a sz�vegdoboz tetej�n�l
            rtbMezo.AppendText("J�t�kos pontsz�mok:" + "\n");
            rtbMezo.AppendText("(ezek a rekordok)" + "\n\n");
            rtbMezo.AppendText("N�v                                 Pontsz�m" + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        { //A program ind�t�sakor ezek futnak le
            //Fejl�c sz�veg berak�sa a dobozba:
            fejlec();
            //F�jl beolvas�sa:
            string path = @"AlienInvaders.dat";
            StreamReader szovegBe = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));
            //A beolvas�s ideje alatt ne lehessen rendezgetni az adatokat:
            tiNev.Enabled = false;
            tiPont.Enabled = false;
            //Sorok fel�p�t�se:
            while (szovegBe.Peek() != -1)
            {
                //T�mb�k �jram�retez�se:
                Array.Resize<string>(ref Nev, Nev.Length + 1);
                Array.Resize<double>(ref Pontszam, Pontszam.Length + 1);
                //Rekordok beolvas�sa �s t�mbh�z ad�sa:
                string sor = szovegBe.ReadLine();
                string[] rekord = sor.Split(',');
                Nev[num] = rekord[0];
                Pontszam[num] = Convert.ToDouble(rekord[1]);
                num++;
            }
            //File bez�r�sa a m�velet v�g�n:
            szovegBe.Close();
            Array.Resize<string>(ref Nev, Nev.Length - 1);
            Array.Resize<double>(ref Pontszam, Pontszam.Length - 1);
        }

        private void tiBetolt_Click(object sender, EventArgs e)
        { //Bet�lt�s m�velete
            //Esetleges el�z� tartalom kiv�tele:
            rtbMezo.Clear();
            fejlec();
            //Egy ciklussal beolvasunk minden adatot a dobozba:
            for (int i = 0; i < Nev.GetUpperBound(0); i++)
            {
                rtbMezo.AppendText(Nev[i].PadRight(25) + Pontszam[i].ToString("n0").PadLeft(10) + "\n");
            }
            //Ne lehessen �jra bet�lteni a k�vetkez� m�dos�t�sig:
            tiBetolt.Enabled = false;
            //A bet�lt�s ut�n legyen �jra el�rhet� a 2 rendez�si opci�:
            tiNev.Enabled = true;
            tiPont.Enabled = true;
        }

        private void tiNev_Click(object sender, EventArgs e)
        { //Rendez�s n�v alapj�n
            for (int i = 0; i < Nev.GetUpperBound(0); i++)
            {
                for (int j = 0; j < Nev.GetUpperBound(0) - i; j++)
                {
                    int k = j + 1;
                    //Sorrend cser�je, ha az aktu�lis helyen sz�ks�ges:
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
            //Meg is kell jelen�teni az �jrarendezett list�t az eddigi hely�n:
            //El�z� tartalom ki�r�t�se:
            rtbMezo.Clear();
            fejlec();
            //�j tartalom berak�sa soronk�nt:
            for (int i = 0; i < Nev.GetUpperBound(0); i++)
            {
                rtbMezo.AppendText(Nev[i].PadRight(25) + Pontszam[i].ToString("n0").PadLeft(10) + "\n");
            }
        }

        private void tiPont_Click(object sender, EventArgs e)
        { //Rendez�s pontsz�m alapj�n
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
