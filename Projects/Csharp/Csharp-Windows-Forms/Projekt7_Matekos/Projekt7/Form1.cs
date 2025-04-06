using System.Security.Cryptography.Xml;

namespace Projekt7
{
    public partial class Form1 : Form
    {
        //Random objektum a véletlenszerû számok használata miatt:
        Random randomElem = new Random();
        //Értékváltozók a 4 db egyenlethez:
        int osszead1;
        int osszead2;
        int kivon1;
        int kivon2;
        int szoroz1;
        int szoroz2;
        int oszt1;
        int oszt2;
        //Kezdeti próbalehetõségek száma:
        int probakSzama = 3;

        //Játék elkezdése funkció:
        public void JatekKezdes()
        { //Ez a függvény lesz behívva a játék elkezdésekor
          //Random értéket adunk a számoknak és ki is írjuk a "?"-ek helyére
          //Összeadás sor:
            osszead1 = randomElem.Next(51); //Mindkét szám legyen 1-50 közti random érték
            osszead2 = randomElem.Next(51);
            lPluszA.Text = osszead1.ToString(); //"?"-ek kicserélése ezen számokra
            lPluszB.Text = osszead2.ToString();
            nudPluszMO.Enabled = true;
            //Kivonás sor:
            kivon1 = randomElem.Next(1, 101);
            kivon2 = randomElem.Next(1, kivon1);
            lMinuszA.Text = kivon1.ToString();
            lMinuszB.Text = kivon2.ToString();
            nudMinuszMO.Enabled = true;
            //Szorzás sor:
            szoroz1 = randomElem.Next(2, 11);
            szoroz2 = randomElem.Next(2, 11);
            lSzorozA.Text = szoroz1.ToString();
            lSzorozB.Text = szoroz2.ToString();
            nudSzorozMO.Enabled = true;
            //Osztás sor:
            oszt1 = randomElem.Next(11, 21);
            oszt2 = randomElem.Next(2, 2);
            lOsztA.Text = oszt1.ToString();
            lOsztB.Text = oszt2.ToString();
            nudOsztMO.Enabled = true;
        }

        public void Visszaallit()
        { //Új játék elõkészítése a mezõk alaphelyzetbe állítása által:
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
            //Megoldásmezõk nullázása:
            nudPluszMO.Value = 0;
            nudMinuszMO.Value = 0;
            nudSzorozMO.Value = 0;
            nudOsztMO.Value = 0;
            //Próbaszám visszaállítása:
            lProbakSzama.Text = "3";
            probakSzama = 3;
            lProbakSzama.Visible = false;
            lProbaFelirat.Visible = false;
            //Megoldásmezõk kikapcsolása:
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
        { //Játék kezdése gomb
            JatekKezdes(); //Fentebb megírt segédfüggvény meghívása
            btnKesz.Visible = true;
            btnKezd.Enabled = false;
            lProbakSzama.Visible = true;
            lProbaFelirat.Visible = true;
        }

        private void btnKesz_Click(object sender, EventArgs e)
        { //Kész gomb
            //Mind a 4 megoldás helyes lett (egyszerre)?
            if ((osszead1 + osszead2 == nudPluszMO.Value) &&
                (kivon1 - kivon2 == nudMinuszMO.Value) &&
                (szoroz1 * szoroz2 == nudSzorozMO.Value) &&
                (oszt1 % oszt2 == nudOsztMO.Value))
            /*Feltétel típusok:
             * ÉS feltétel:
             *      jele: &&
             *      logika: az összes megadott feltétel teljesüljön egyszerre
             * VAGY feltétel:
             *      jele: ||
             *      logika: elég, ha 1 db feltétel teljesül a felsoroltak közül
             * */
            {
                //Felugró üzenet:
                MessageBox.Show("Mindet eltláltad!");
                //Mezõk visszaállítása alapállapotba (fentebb megírt függvény meghívása):
                Visszaallit();
            }
            else
            { //Ha akár 1 megoldásunk is rossz lett
                //Maradt még próbalehetõségünk?
                if (probakSzama > 1)
                {
                    probakSzama -= 1; //Csökken a hátralévõ lehetõségek száma
                    lProbakSzama.Text = Convert.ToString(probakSzama); //Jelezze is ki
                    MessageBox.Show("Hibás válasz(ok), számold újra!"); //Közlés
                }
                else
                { //Ha elfogytak a próbák:
                    MessageBox.Show("Vége a játéknak, nincs több próbalehetõség!");
                    Visszaallit();
                }
            }
        }

        private void btnSugo_Click(object sender, EventArgs e)
        { //Súgó gomb
            //2 egymást követû üzenet:
            MessageBox.Show("3 lehetõséged van kitalálni az egyenletek megoldásait.");
            MessageBox.Show("Ha akár 1 válasz is hibás, akkor az egész rossznak minõsül.");
        }
    }
}
