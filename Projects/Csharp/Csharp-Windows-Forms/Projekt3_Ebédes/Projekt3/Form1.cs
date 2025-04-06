using System.Security.AccessControl;

namespace Projekt3
{
    public partial class Form1 : Form
    {
        //A m�g�ttes sz�mol�sokhoz sz�ks�ges seg�dv�ltoz�k:
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
        { //Brutt� �r sz�m�t�sa gomb
            //Mindh�rom term�k �ssz�r�nak kisz�m�t�sa:
            rizsEgyseg = double.Parse(tbRizs.Text); //Sz�vegdobozban stringk�nt t�rolja, �gy �t kellett alak�tani
            rizsOsszesen = rizsEgyseg * rizsAr;

            halEgyseg = double.Parse(tbHal.Text);
            halOsszesen = halEgyseg * halAr;

            husEgyseg = double.Parse(tbHus.Text);
            husOsszesen = husEgyseg * husAr;

            brutto = rizsOsszesen + halOsszesen + husOsszesen; //Brutt� v�g�sszeg
            //Ez az �sszeg ker�lj�n be az �sszesen dobozba:
            tbOsszesen.Text = brutto.ToString(); //Stringk�nt lehet csak bevinni a dobozba
        }

        private void btnNetto_Click(object sender, EventArgs e)
        { //Nett� fizetend� gomb
            //V�gleges sz�mla kisz�mol�sa:
            brutto = double.Parse(tbOsszesen.Text);
            kedvezmeny = double.Parse(tbKedv.Text);
            kedvMennyiseg = brutto * kedvezmeny / 100;
            afaMennyiseg = brutto * afaSzazalek;
            szamlaOsszesen = (brutto - kedvMennyiseg) + afaMennyiseg;
            //V�g�sszeg mutat�sa egy felugr� �zenetben:
            MessageBox.Show("Fizess ennyit: " + szamlaOsszesen + " Ft. K�sz�nj�k a v�s�rl�st!");
            //Sz�vegdobozok ki�r�t�se a k�vetkez� v�s�rl�s el�tt:
            tbRizs.Text = "";
            tbHal.Text = "";
            tbHus.Text = "";
            tbKedv.Text = "";
            tbOsszesen.Text = "";
            keretOsszeg += szamlaOsszesen;
            if (keretOsszeg > 3000) //Ha t�ll�pn�nk a 3000-res keretet:
            {
                MessageBox.Show("T�ll�pted a 3000 forintos keretet!");
            } 
            else
            {
                pbKeret.Value += Convert.ToInt32(szamlaOsszesen);
                lKeret.Text = Convert.ToString(szamlaOsszesen) + "/3000";
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        { //Kil�p�s gomb
            Application.Exit();
        }

        private void cbKeretMutat_CheckedChanged(object sender, EventArgs e)
        { //Keret mutat�sa pipa
            //Ha a b�dzs� dolgai nem l�that�k, akkor jelenjenek meg:
            if (pbKeret.Visible == false)
            {
                pbKeret.Visible = true;
                btnNullazas.Visible = true;
                lKeret.Visible = true;
            }
            else //M�sik esetben pomt hogy el kell rejteni �ket:
            {
                pbKeret.Visible = false;
                btnNullazas.Visible = false;
                lKeret.Visible = false;
            }
        }

        private void btnLearaz_Click(object sender, EventArgs e)
        { //Le�raz�s gomb
          //Egyszeri 10%-os le�raz�st v�gez az egys�g�rakban, ut�na passziv�l�dik
          //Egys�g�rak m�g�ttes cs�kkent�se:
            rizsAr = rizsAr * 0.9;
            halAr = halAr * 0.9;
            husAr = husAr * 0.9;
            //A cimk�kben felt�ntetett �r is v�ltozzon meg:
            lRizs.Text = "Rizs (360 Ft):";
            lHal.Text = "Hal (720 Ft):";
            lHus.Text = "H�s (900 Ft):";
            //Le�raz�s gomb kikapcsol�sa:
            btnLearaz.Enabled = false;
            //�zenet:
            MessageBox.Show("Kapt�l 10% kedvezm�nyt!");
        }

        private void btnKedv_Click(object sender, EventArgs e)
        { //Ad�kedvezm�ny gomb
          //Ez az �f�t 27%-r�l 20%-ra cs�kkenti
            btnKedv.Enabled = false; //Kedvezm�ny gomb passziv�l�sa
            lAfa.Text = "�fa: 20%"; //Cimke �t�r�sa
            afaSzazalek = 0.2; //M�g�ttes �fa�rt�k �t�r�sa
            MessageBox.Show("Az �j �fa 20% lett.");
        }

        private void btnNullazas_Click(object sender, EventArgs e)
        { //Lenull�z gomb
            pbKeret.Value = 0; //ProgressBar null�z�sa
            lKeret.Text = "0/3000"; //Cimke alapra �ll�t�sa
        }

        private void btnReset_Click(object sender, EventArgs e)
        { //Teljes vissza�ll�t�s gomb
          //Ez az eg�sz programot reseteli az alaphelyzetbe
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
            lAfa.Text = "�fa: 27%";
            pbKeret.Value = 0;
            lKeret.Text = "0/3000";
            lRizs.Text = "Rizs (400 Ft):";
            lHal.Text = "Hal (800 Ft):";
            lHus.Text = "H�s (1000 Ft):";
        }
    }
}
