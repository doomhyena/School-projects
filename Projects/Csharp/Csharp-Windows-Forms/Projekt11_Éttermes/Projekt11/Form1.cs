using System;
using System.IO;
using System.Data;
using System.Text;
using System.DirectoryServices.ActiveDirectory;

namespace Projekt11
{
    public partial class Form1 : Form
    {
        //Seg�dv�ltoz�:
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
        { //Ez a program bet�lt�sekor fut le:
            //F�jlkezel�s:
            string path = @"Restaurants.dat";
            StreamReader szovegBe = new StreamReader(
            new FileStream(path, FileMode.Open, FileAccess.Read));

            //Beolvas�s:
            while (szovegBe.Peek() != -1)
            {
                //T�mb�k �jram�retez�se az �rkez� rekordoknak:
                Array.Resize<string>(ref nev, nev.Length + 1);
                Array.Resize<int>(ref ules, ules.Length + 1);
                Array.Resize<string>(ref tipus, tipus.Length + 1);
                Array.Resize<int>(ref ertekeles, tipus.Length + 1);
                //�j rekord behelyez�se a t�mb�kbe:
                string sor = szovegBe.ReadLine();
                string[] rekord = sor.Split(",");
                nev[num] = rekord[0];
                ules[num] = Convert.ToInt32(rekord[1]);
                tipus[num] = rekord[2];
                ertekeles[num] = Convert.ToInt32(rekord[3]);
                //Tov�bbl�p�shez:
                num = num + 1;
            }
            //F�jl bez�r�sa:
            szovegBe.Close();
            num = 0;
            //Kis sz�vegdoboz felt�lt�se a rekordokkal:
            fejlec();
            for (int i = 0; i < nev.GetUpperBound(0); i++)
            {
                //T�pus doboz felt�lt�se (minden tipus csak egyszer szerepeljen:
                num++;
                if (key != tipus[i])
                {
                    lbTipus.Items.Add(tipus[i]);
                    key = tipus[i];
                }
                //Nagy sz�vegdoboz felt�lt�se az �sszes �tterem rekorddal:
                rtbMezo.AppendText(nev[i].PadRight(25) + ules[i].ToString("n0").PadLeft(6)
                    + tipus[i].PadLeft(10) + ertekeles[i].ToString("n0").PadLeft(10) + "\n");
            }
            lRekordszam.Text = num.ToString("n0"); //Tal�latok sz�m�nak ki�r�sa
        }
        //Sablon fejl�c a dobozba:
        public void fejlec()
        {
            rtbMezo.Clear();
            rtbMezo.AppendText("�tterem keres� lista" + "\n");
            rtbMezo.AppendText("Keres�s" + "\n\n");
            rtbMezo.AppendText("N�v         �l�sek      T�pus       �rt�kel�s" + "\n");
        }

        private void btnKeres_Click(object sender, EventArgs e)
        { //Keres�s gomb:
            string keresett = tbKeres.Text; //A be�rt sz�veg, amire sz�r�nk
            num = 0;
            fejlec();
            for (int i = 0; i < nev.GetUpperBound(0); i++)
            {   //Csak a keresett n�vnek megfelel� �tterem rekordok list�z�djnak:
                if (keresett.ToUpper() == nev[i].ToUpper()) //Kis-nagy bet� elt�r�sek kik�sz�b�l�se
                {
                    num++;
                    rtbMezo.AppendText(nev[i].PadRight(25) + ules[i].ToString("n0").PadLeft(6)
                    + tipus[i].PadLeft(10) + ertekeles[i].ToString("n0").PadLeft(10) + "\n");
                }
                lRekordszam.Text = num.ToString("n0"); //Tal�latok sz�m�nak ki�r�sa
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        { //Kil�p�s gomb:
            this.Close();
        }

        private void lbTipus_SelectedIndexChanged(object sender, EventArgs e)
        { //Sz�r�s t�pus alapj�n (csak azokat list�zza �jra, amik olyan t�pus� �ttermek):
            string valasztottElem = Convert.ToString(lbTipus.SelectedItem);
            num = 0;
            fejlec();
            for (int i = 0; i < nev.GetUpperBound(0); i++)
            {
                if (valasztottElem == tipus[i]) //Csak ha ilyan t�pus�
                {
                    num++;
                    rtbMezo.AppendText(nev[i].PadRight(25) + ules[i].ToString("n0").PadLeft(6)
                    + tipus[i].PadLeft(10) + ertekeles[i].ToString("n0").PadLeft(10) + "\n");
                }
                lRekordszam.Text = num.ToString("n0"); //Tal�latok sz�m�nak ki�r�sa
            }
        }

        private void nudErt_ValueChanged(object sender, EventArgs e)
        { //Minimum �rt�kel�s szerinti sz�r�s
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
