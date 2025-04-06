using System.Security.AccessControl;

namespace Projekt3
{
    public partial class Form1 : Form
    {
        //A mögöttes számolásokhoz szükséges segédváltozók:
        private double rizsEgyseg;
        private double halEgyseg;
        private double husEgyseg;

        private double kedvezmeny;
        private double afa;
        private double brutto;
        private double afaSzazalek = 0.27;

        private double rizsOsszesen;
        private double halOsszesen;
        private double husOsszesen;
        private double szamlaOsszesen;
        private double afaMennyiseg;
        private double kedvMennyiseg;

        private double rizsAr = 400;
        private double halAr = 800;
        private double husAr = 1000;

        private double keretOsszeg;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrutto_Click(object sender, EventArgs e)
        { //Bruttó ár számítása gomb
            //Mindhárom termék összárának kiszámítása:
            rizsEgyseg = double.Parse(tbRizs.Text); //Szövegdobozban stringként tárolja, így át kellett alakítani
            rizsOsszesen = rizsEgyseg * rizsAr;

            halEgyseg = double.Parse(tbHal.Text);
            halOsszesen = halEgyseg * halAr;

            husEgyseg = double.Parse(tbHus.Text);
            husOsszesen = husEgyseg * husAr;

            brutto = rizsOsszesen + halOsszesen + husOsszesen; //Bruttó végösszeg
            //Ez az összeg kerüljön be az Összesen dobozba:
            tbOsszesen.Text = brutto.ToString(); //Stringként lehet csak bevinni a dobozba
        }

        private void btnNetto_Click(object sender, EventArgs e)
        { //Nettó fizetendõ gomb
            //Végleges számla kiszámolása:
            brutto = double.Parse(tbOsszesen.Text);
            kedvezmeny = double.Parse(tbKedv.Text);
            kedvMennyiseg = brutto * kedvezmeny / 100;
            afaMennyiseg = brutto * afaSzazalek;
            szamlaOsszesen = (brutto - kedvMennyiseg) + afaMennyiseg;
            //Végösszeg mutatása egy felugró üzenetben:
            MessageBox.Show("Fizess ennyit: " + szamlaOsszesen + " Ft. Köszönjük a vásárlást!");
            //Szövegdobozok kiürítése a következõ vásárlás elõtt:
            tbRizs.Text = "";
            tbHal.Text = "";
            tbHus.Text = "";
            tbKedv.Text = "";
            tbOsszesen.Text = "";
            keretOsszeg += szamlaOsszesen;
            if (keretOsszeg > 3000) //Ha túllépnénk a 3000-res keretet:
            {
                MessageBox.Show("Túllépted a 3000 forintos keretet!");
            } 
            else
            {
                pbKeret.Value += Convert.ToInt32(szamlaOsszesen);
                lKeret.Text = Convert.ToString(szamlaOsszesen) + "/3000";
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        { //Kilépés gomb
            Application.Exit();
        }

        private void cbKeretMutat_CheckedChanged(object sender, EventArgs e)
        { //Keret mutatása pipa
            //Ha a büdzsé dolgai nem láthatók, akkor jelenjenek meg:
            if (pbKeret.Visible == false)
            {
                pbKeret.Visible = true;
                btnNullazas.Visible = true;
                lKeret.Visible = true;
            }
            else //Másik esetben pomt hogy el kell rejteni õket:
            {
                pbKeret.Visible = false;
                btnNullazas.Visible = false;
                lKeret.Visible = false;
            }
        }

        private void btnLearaz_Click(object sender, EventArgs e)
        { //Leárazás gomb
          //Egyszeri 10%-os leárazást végez az egységárakban, utána passziválódik
          //Egységárak mögöttes csökkentése:
            rizsAr = rizsAr * 0.9;
            halAr = halAr * 0.9;
            husAr = husAr * 0.9;
            //A cimkékben feltüntetett ár is változzon meg:
            lRizs.Text = "Rizs (360 Ft):";
            lHal.Text = "Hal (720 Ft):";
            lHus.Text = "Hús (900 Ft):";
            //Leárazás gomb kikapcsolása:
            btnLearaz.Enabled = false;
            //Üzenet:
            MessageBox.Show("Kaptál 10% kedvezményt!");
        }

        private void btnKedv_Click(object sender, EventArgs e)
        { //Adókedvezmény gomb
          //Ez az áfát 27%-ról 20%-ra csökkenti
            btnKedv.Enabled = false; //Kedvezmény gomb passziválása
            lAfa.Text = "Áfa: 20%"; //Cimke átírása
            afaSzazalek = 0.2; //Mögöttes áfaérték átírása
            MessageBox.Show("Az új áfa 20% lett.");
        }

        private void btnNullazas_Click(object sender, EventArgs e)
        { //Lenulláz gomb
            pbKeret.Value = 0; //ProgressBar nullázása
            lKeret.Text = "0/3000"; //Cimke alapra állítása
        }

        private void btnReset_Click(object sender, EventArgs e)
        { //Teljes visszaállítás gomb
          //Ez az egész programot reseteli az alaphelyzetbe
            cbKeretMutat.Checked = false; 
            pbKeret.Visible = false;
            lKeret.Visible = false;
            btnNullazas.Visible = false;
            tbRizs.Text = "";
            tbHal.Text = "";
            tbHus.Text = "";
            tbOsszesen.Text = "";
            tbKedv.Text = "0";
            btnLearaz.Enabled = true;
            btnKedv.Enabled = true;
            afaSzazalek = 0.27;
            lAfa.Text = "Áfa: 27%";
            pbKeret.Value = 0;
            lKeret.Text = "0/3000";
            lRizs.Text = "Rizs (400 Ft):";
            lHal.Text = "Hal (800 Ft):";
            lHus.Text = "Hús (1000 Ft):";
        }
    }
}
