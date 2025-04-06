using System.Reflection.Metadata;

namespace Projekt4
{
    public partial class Form1 : Form
    {
        private int keret = 5; //alapb�l 5 elem lehet, de ez v�ltoztathat�
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        { //Ez a gomb hozz�ad egy "aaa" sz�veg� elemet a listadobozhoz
            lbListadoboz.Items.Add("aaa"); //Items = Elemek, Add = Hozz�ad
            lElemszam.Text = Convert.ToString(lbListadoboz.Items.Count); //Count = Megsz�mol
            //Ne lehessen 5-n�l t�bb elem a listadobozban:
            if (lbListadoboz.Items.Count == keret)
            {
                btnHozzaad.Enabled = false;
                btnSzoveg.Enabled = false;
                MessageBox.Show("Limit el�rve!");
            }
            btnLevesz.Enabled = true;
            btnKiurit.Enabled = true;
        }

        private void btnLevesz_Click(object sender, EventArgs e)
        { //Kijel�lt elem lev�tele gomb
            lbListadoboz.Items.Remove(lbListadoboz.SelectedItem); //Remove = Elt�vol�t, SelectedItem = Kiv�lasztott elem
            lElemszam.Text = Convert.ToString(lbListadoboz.Items.Count);
            if (lbListadoboz.Items.Count == 0)
            {
                btnLevesz.Enabled = false;
                btnKiurit.Enabled = false;
            }
            //Ha eddig el volt �rve a limit, akkor legyen �jra szerkeszthet� a lista:
            if (btnHozzaad.Enabled == false)
            {
                btnHozzaad.Enabled = true;
                btnSzoveg.Enabled = true;
            }
        }

        private void btnKiurit_Click(object sender, EventArgs e)
        { //Ez a gomb ki�r�ti a teljes listadobozt
            btnLevesz.Enabled = false;
            btnKiurit.Enabled = false;
            lbListadoboz.Items.Clear(); //Clear() = Ki�r�t
            lElemszam.Text = Convert.ToString(lbListadoboz.Items.Count);
            if (btnHozzaad.Enabled == false)
            {
                btnHozzaad.Enabled = true;
                btnSzoveg.Enabled = true;
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        { //Bez�r�s gomb
            Application.Exit();
        }

        private void btnSzoveg_Click(object sender, EventArgs e)
        { //Tetsz�leges sz�veg bevitele gomb
            btnLevesz.Enabled = true;
            btnKiurit.Enabled = true;
            lbListadoboz.Items.Add(tbSzoveg.Text);
            lElemszam.Text = Convert.ToString(lbListadoboz.Items.Count);
            if (lbListadoboz.Items.Count == keret)
            {
                btnHozzaad.Enabled = false;
                btnSzoveg.Enabled = false;
                MessageBox.Show("Limit el�rve!");
            }
        }

        private void rbEnged_CheckedChanged(object sender, EventArgs e)
        { //Bekapcsol� r�di�gomb
            lbListadoboz.Visible = true;
            btnBezar.Enabled = true;
            btnHozzaad.Enabled = true;
            btnSzoveg.Enabled = true;
            tbSzoveg.Enabled = true;
            btnBovit.Enabled = true;
            lSzerkAllapot.Text = "Szerkeszthet�";
        }

        private void btnBovit_Click(object sender, EventArgs e)
        { //Keret n�vel�se gomb (5-r�l 10-re)
            keret = 10;
            //Ha esetleg kor�bban el�rt�k az 5-�s keretet:
            if (btnHozzaad.Enabled == false)
            {
                btnHozzaad.Enabled = true;
                btnSzoveg.Enabled = true;
            }
            btnBovit.Enabled = false;
            btnVisszavesz.Enabled = true;
        }

        private void btnVisszavesz_Click(object sender, EventArgs e)
        { //Limit vissza�ll�t�sa 5-re gomb
            keret = 5;
            btnVisszavesz.Enabled = false;
            btnBovit.Enabled = true;
            //Ha 5-n�l t�bb elemmel �ll�tjuk vissza a limitet, akkor �r�lj�n ki a lista:
            if (lbListadoboz.Items.Count > 5)
            {
                lbListadoboz.Items.Clear();
                lElemszam.Text = Convert.ToString(lbListadoboz.Items.Count);
                btnHozzaad.Enabled = true;
                btnSzoveg.Enabled = true;
            }
        }
    }
}
//listadobozNeve.Items.Add(�jElem) --> �j elem felvitele a listadobozva
//listadobozNeve.Items.Count --> Listaelemek megsz�ml�l�sa
//listadobozNeve.Items.Clear() --> Teljes doboz ki�r�t�se
//listadobozNeve.Items.Remove(elem) --> adott elem t�rl�se a listadobozb�l