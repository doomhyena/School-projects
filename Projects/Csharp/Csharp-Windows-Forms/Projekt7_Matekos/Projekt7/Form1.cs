using System.Security.Cryptography.Xml;

namespace Projekt7
{
    public partial class Form1 : Form
    {
        //Random objektum a v�letlenszer� sz�mok haszn�lata miatt:
        Random randomElem = new Random();
        //�rt�kv�ltoz�k a 4 db egyenlethez:
        int osszead1;
        int osszead2;
        int kivon1;
        int kivon2;
        int szoroz1;
        int szoroz2;
        int oszt1;
        int oszt2;
        //Kezdeti pr�balehet�s�gek sz�ma:
        int probakSzama = 3;

        //J�t�k elkezd�se funkci�:
        public void JatekKezdes()
        { //Ez a f�ggv�ny lesz beh�vva a j�t�k elkezd�sekor
          //Random �rt�ket adunk a sz�moknak �s ki is �rjuk a "?"-ek hely�re
          //�sszead�s sor:
            osszead1 = randomElem.Next(51); //Mindk�t sz�m legyen 1-50 k�zti random �rt�k
            osszead2 = randomElem.Next(51);
            lPluszA.Text = osszead1.ToString(); //"?"-ek kicser�l�se ezen sz�mokra
            lPluszB.Text = osszead2.ToString();
            nudPluszMO.Enabled = true;
            //Kivon�s sor:
            kivon1 = randomElem.Next(1, 101);
            kivon2 = randomElem.Next(1, kivon1);
            lMinuszA.Text = kivon1.ToString();
            lMinuszB.Text = kivon2.ToString();
            nudMinuszMO.Enabled = true;
            //Szorz�s sor:
            szoroz1 = randomElem.Next(2, 11);
            szoroz2 = randomElem.Next(2, 11);
            lSzorozA.Text = szoroz1.ToString();
            lSzorozB.Text = szoroz2.ToString();
            nudSzorozMO.Enabled = true;
            //Oszt�s sor:
            oszt1 = randomElem.Next(11, 21);
            oszt2 = randomElem.Next(2, 2);
            lOsztA.Text = oszt1.ToString();
            lOsztB.Text = oszt2.ToString();
            nudOsztMO.Enabled = true;
        }

        public void Visszaallit()
        { //�j j�t�k el�k�sz�t�se a mez�k alaphelyzetbe �ll�t�sa �ltal:
            btnKezd.Enabled = true;
            btnKesz.Visible = false;
            lPluszA.Text = "?";
            lPluszB.Text = "?";
            lMinuszA.Text = "?";
            lMinuszB.Text= "?";
            lSzorozA.Text = "?";
            lSzorozB.Text = "?";
            lOsztA.Text = "?";
            lOsztB.Text = "?";
            //Megold�smez�k null�z�sa:
            nudPluszMO.Value = 0;
            nudMinuszMO.Value = 0;
            nudSzorozMO.Value = 0;
            nudOsztMO.Value = 0;
            //Pr�basz�m vissza�ll�t�sa:
            lProbakSzama.Text = "3";
            probakSzama = 3;
            lProbakSzama.Visible = false;
            lProbaFelirat.Visible = false;
            //Megold�smez�k kikapcsol�sa:
            nudPluszMO.Enabled = false;
            nudMinuszMO.Enabled = false;
            nudSzorozMO.Enabled = false;
            nudOsztMO.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKezd_Click(object sender, EventArgs e)
        { //J�t�k kezd�se gomb
            JatekKezdes(); //Fentebb meg�rt seg�df�ggv�ny megh�v�sa
            btnKesz.Visible = true;
            btnKezd.Enabled = false;
            lProbakSzama.Visible = true;
            lProbaFelirat.Visible = true;
        }

        private void btnKesz_Click(object sender, EventArgs e)
        { //K�sz gomb
            //Mind a 4 megold�s helyes lett (egyszerre)?
            if ((osszead1 + osszead2 == nudPluszMO.Value) &&
                (kivon1 - kivon2 == nudMinuszMO.Value) &&
                (szoroz1 * szoroz2 == nudSzorozMO.Value) &&
                (oszt1 % oszt2 == nudOsztMO.Value))
            /*Felt�tel t�pusok:
             * �S felt�tel:
             *      jele: &&
             *      logika: az �sszes megadott felt�tel teljes�lj�n egyszerre
             * VAGY felt�tel:
             *      jele: ||
             *      logika: el�g, ha 1 db felt�tel teljes�l a felsoroltak k�z�l
             * */
            {
                //Felugr� �zenet:
                MessageBox.Show("Mindet eltl�ltad!");
                //Mez�k vissza�ll�t�sa alap�llapotba (fentebb meg�rt f�ggv�ny megh�v�sa):
                Visszaallit();
            }
            else
            { //Ha ak�r 1 megold�sunk is rossz lett
                //Maradt m�g pr�balehet�s�g�nk?
                if (probakSzama > 1)
                {
                    probakSzama -= 1; //Cs�kken a h�tral�v� lehet�s�gek sz�ma
                    lProbakSzama.Text = Convert.ToString(probakSzama); //Jelezze is ki
                    MessageBox.Show("Hib�s v�lasz(ok), sz�mold �jra!"); //K�zl�s
                }
                else
                { //Ha elfogytak a pr�b�k:
                    MessageBox.Show("V�ge a j�t�knak, nincs t�bb pr�balehet�s�g!");
                    Visszaallit();
                }
            }
        }

        private void btnSugo_Click(object sender, EventArgs e)
        { //S�g� gomb
            //2 egym�st k�vet� �zenet:
            MessageBox.Show("3 lehet�s�ged van kital�lni az egyenletek megold�sait.");
            MessageBox.Show("Ha ak�r 1 v�lasz is hib�s, akkor az eg�sz rossznak min�s�l.");
        }
    }
}
