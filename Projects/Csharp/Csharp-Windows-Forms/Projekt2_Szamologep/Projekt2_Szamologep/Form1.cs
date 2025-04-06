//Modulok beimportálása: using ModulNeve (itt fent)
using System;
using System.Globalization; //Ez a modul a lenti CultureInfo miatt kellett

namespace Projekt2_Szamologep
{
    public partial class Form1 : Form
    {
        //A számológép mûküdéséhez létre kell hozni pár segédváltozót:
        decimal ertek1 = 0, ertek2 = 0; //Tizedes értékek a 2 számnak
        string muvelet = ""; //Külön érték a mûveleti jelnek
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {//A CE gomb kiüríti a teljes eredményezõt:
            tbEredmenyMezo.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {//A C gomb kiüríti a teljes eredményezõt és a mögöttesen tárolt számokat is:
            tbEredmenyMezo.Text = "";
            ertek1 = 0;
            ertek2 = 0;
        }
        //A számjegyek/tizedespont megnyomására az adott érték kerüljön be a fenti mezõbe:
        //      - Az értékeket string-ként adjuk hozzá, mert itt még csak az egyenlet összerakása zajlik
        //      - Ne másolás-beillesztéssel oldjuk meg a sokszorozást, mert akkor hibás lesz a program
        private void btnTizedes_Click(object sender, EventArgs e)
        {
            tbEredmenyMezo.Text += ".";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbEredmenyMezo.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbEredmenyMezo.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbEredmenyMezo.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbEredmenyMezo.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbEredmenyMezo.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbEredmenyMezo.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbEredmenyMezo.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbEredmenyMezo.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbEredmenyMezo.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbEredmenyMezo.Text += "9";
        }

        private void btnEgyenlo_Click(object sender, EventArgs e)
        {//Bevitt egyenlet kiszámítása:
            if (tbEredmenyMezo.Text == "") //Ha nincs mit kiszámolni
            {
                tbEredmenyMezo.Text = "Hiba";
            }
            else //Egyéb (normál) esetben:
            {
                ertek2 = decimal.Parse(tbEredmenyMezo.Text, CultureInfo.InvariantCulture);
                //A CultureInfo azért kell, hogy minden ország billenyûzetével használható legyen
                //A CultureInfo használatához fent be kell importálni a szükséges modult

                //Utána a megadott mûveleti jel szerint számolunk:
                if (muvelet == "PLUS")
                {
                    tbEredmenyMezo.Text = Convert.ToString(ertek1 + ertek2);
                    //Convert.ToString(): string-gé alakítás (mint a Python-ban az str())
                }
                else if (muvelet == "MINUS")
                {
                    tbEredmenyMezo.Text = Convert.ToString(ertek1 - ertek2);
                }
                else if (muvelet == "MULT")
                {
                    tbEredmenyMezo.Text = Convert.ToString(ertek1 * ertek2);
                }
                else if (muvelet == "PERC")
                {
                    tbEredmenyMezo.Text = Convert.ToString(ertek1 * (ertek2 / 100));
                }
                else if (muvelet == "DIV")
                {
                    tbEredmenyMezo.Text = Convert.ToString(ertek1 / ertek2);
                }
            }
        }

        private void btnPlusz_Click(object sender, EventArgs e)
        {/*A + gomb megnyomására meghívódik egy lentebb megírt, "MuveletMegad()" 
          * nevû függvény, amely értelmezi az elvégzendõ számítást.    */
            MuveletMegad("PLUS", "+");
        }

        private void btnMinusz_Click(object sender, EventArgs e)
        {
            MuveletMegad("MINUS", "-");
        }

        private void btnSzoroz_Click(object sender, EventArgs e)
        {
            MuveletMegad("MULT", "x");
        }

        private void btnOszt_Click(object sender, EventArgs e)
        {
            MuveletMegad("DIV", "/");
        }

        private void btnSzazalek_Click(object sender, EventArgs e)
        {
            MuveletMegad("PERC", "%");
        }

        private void MuveletMegad(string muvelet, string muveletCim)
        {
            if (tbEredmenyMezo.Text != "")
            {
                ertek1 = decimal.Parse(tbEredmenyMezo.Text, CultureInfo.InvariantCulture);
                tbEredmenyMezo.Text = "";
                this.muvelet = muvelet; //this: aktuálisan kezelt elem
            }
            else
            {//MessageBox.Show("Sablon szöveg") --> ez egy felugró ablakot fog mutatni:
                MessageBox.Show("Javítsd ki a bevitt értékket!");
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {//Programból való kilépés gomb:
            Application.Exit();
        }

        private void cbBekapcsol_CheckedChanged(object sender, EventArgs e)
        { //Ez a pipa tesz mindent szerkeszthetõvé/blokkoltá:
            //Ha bepipáljuk, akkor mindent megnyit:
            if (cbBekapcsol.Checked == true)
            {
                btn0.Enabled = true;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
                tbEredmenyMezo.Enabled = true;
                btnPlusz.Enabled = true;
                btnMinusz.Enabled = true;
                btnOszt.Enabled = true;
                btnSzazalek.Enabled = true;
                btnTizedes.Enabled = true;
                btnSzoroz.Enabled = true;
                btnEgyenlo.Enabled = true;
                btnC.Enabled = true;
                btnCE.Enabled = true;
                btnKilep.Enabled = true;
                cbBekapcsol.Text = "Kikapcsol";
            }
            else
            {
                btn0.Enabled = false;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                tbEredmenyMezo.Enabled = false;
                btnPlusz.Enabled = false;
                btnMinusz.Enabled = false;
                btnOszt.Enabled = false;
                btnSzazalek.Enabled = false;
                btnTizedes.Enabled = false;
                btnSzoroz.Enabled = false;
                btnEgyenlo.Enabled = false;
                btnC.Enabled = false;
                btnCE.Enabled = false;
                btnKilep.Enabled = false;
                cbBekapcsol.Text = "Bekapcsol";
            }
        }
    }
}
/* Megjegyzések:
    - using System.ModulNév --> Bizonyos funkciókat fent be kell importálni (mint a math vagy a tkinter a pythonnál)
    - private: ez az elem csak adott osztályban elérhetõ
    - public: ez az elem a program bármely részérõl elérhetõ
    - void: olyan függvény, ami nem tér vissza konkrét értékkel, csak mögöttes számítást végez
    - Elnevezési séma: típusrövidítés + betöltött szerep
        btnBezaras --> gomb, ami bezárja a programot
        cbBekapcsol --> checkBox, ami bekapcsolja az elemek elérhetõségét
        tbEredmenyMezõ --> textBox, ami mutatja az eredményt
*/