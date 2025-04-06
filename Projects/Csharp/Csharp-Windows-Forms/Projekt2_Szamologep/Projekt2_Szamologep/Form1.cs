//Modulok beimport�l�sa: using ModulNeve (itt fent)
using System;
using System.Globalization; //Ez a modul a lenti CultureInfo miatt kellett

namespace Projekt2_Szamologep
{
    public partial class Form1 : Form
    {
        //A sz�mol�g�p m�k�d�s�hez l�tre kell hozni p�r seg�dv�ltoz�t:
        decimal ertek1 = 0, ertek2 = 0; //Tizedes �rt�kek a 2 sz�mnak
        string muvelet = ""; //K�l�n �rt�k a m�veleti jelnek
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {//A CE gomb ki�r�ti a teljes eredm�nyez�t:
            tbEredmenyMezo.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {//A C gomb ki�r�ti a teljes eredm�nyez�t �s a m�g�ttesen t�rolt sz�mokat is:
            tbEredmenyMezo.Text = "";
            ertek1 = 0;
            ertek2 = 0;
        }
        //A sz�mjegyek/tizedespont megnyom�s�ra az adott �rt�k ker�lj�n be a fenti mez�be:
        //      - Az �rt�keket string-k�nt adjuk hozz�, mert itt m�g csak az egyenlet �sszerak�sa zajlik
        //      - Ne m�sol�s-beilleszt�ssel oldjuk meg a sokszoroz�st, mert akkor hib�s lesz a program
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
        {//Bevitt egyenlet kisz�m�t�sa:
            if (tbEredmenyMezo.Text == "") //Ha nincs mit kisz�molni
            {
                tbEredmenyMezo.Text = "Hiba";
            }
            else //Egy�b (norm�l) esetben:
            {
                ertek2 = decimal.Parse(tbEredmenyMezo.Text, CultureInfo.InvariantCulture);
                //A CultureInfo az�rt kell, hogy minden orsz�g billeny�zet�vel haszn�lhat� legyen
                //A CultureInfo haszn�lat�hoz fent be kell import�lni a sz�ks�ges modult

                //Ut�na a megadott m�veleti jel szerint sz�molunk:
                if (muvelet == "PLUS")
                {
                    tbEredmenyMezo.Text = Convert.ToString(ertek1 + ertek2);
                    //Convert.ToString(): string-g� alak�t�s (mint a Python-ban az str())
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
        {/*A + gomb megnyom�s�ra megh�v�dik egy lentebb meg�rt, "MuveletMegad()" 
          * nev� f�ggv�ny, amely �rtelmezi az elv�gzend� sz�m�t�st.    */
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
                this.muvelet = muvelet; //this: aktu�lisan kezelt elem
            }
            else
            {//MessageBox.Show("Sablon sz�veg") --> ez egy felugr� ablakot fog mutatni:
                MessageBox.Show("Jav�tsd ki a bevitt �rt�kket!");
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {//Programb�l val� kil�p�s gomb:
            Application.Exit();
        }

        private void cbBekapcsol_CheckedChanged(object sender, EventArgs e)
        { //Ez a pipa tesz mindent szerkeszthet�v�/blokkolt�:
            //Ha bepip�ljuk, akkor mindent megnyit:
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
/* Megjegyz�sek:
    - using System.ModulN�v --> Bizonyos funkci�kat fent be kell import�lni (mint a math vagy a tkinter a pythonn�l)
    - private: ez az elem csak adott oszt�lyban el�rhet�
    - public: ez az elem a program b�rmely r�sz�r�l el�rhet�
    - void: olyan f�ggv�ny, ami nem t�r vissza konkr�t �rt�kkel, csak m�g�ttes sz�m�t�st v�gez
    - Elnevez�si s�ma: t�pusr�vid�t�s + bet�lt�tt szerep
        btnBezaras --> gomb, ami bez�rja a programot
        cbBekapcsol --> checkBox, ami bekapcsolja az elemek el�rhet�s�g�t
        tbEredmenyMez� --> textBox, ami mutatja az eredm�nyt
*/