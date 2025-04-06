using System.Reflection.Metadata;

namespace Projekt4
{
    public partial class Form1 : Form
    {
        private int keret = 5; //alapból 5 elem lehet, de ez változtatható
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        { //Ez a gomb hozzáad egy "aaa" szövegû elemet a listadobozhoz
            lbListadoboz.Items.Add("aaa"); //Items = Elemek, Add = Hozzáad
            lElemszam.Text = Convert.ToString(lbListadoboz.Items.Count); //Count = Megszámol
            //Ne lehessen 5-nél több elem a listadobozban:
            if (lbListadoboz.Items.Count == keret)
            {
                btnHozzaad.Enabled = false;
                btnSzoveg.Enabled = false;
                MessageBox.Show("Limit elérve!");
            }
            btnLevesz.Enabled = true;
            btnKiurit.Enabled = true;
        }

        private void btnLevesz_Click(object sender, EventArgs e)
        { //Kijelölt elem levétele gomb
            lbListadoboz.Items.Remove(lbListadoboz.SelectedItem); //Remove = Eltávolít, SelectedItem = Kiválasztott elem
            lElemszam.Text = Convert.ToString(lbListadoboz.Items.Count);
            if (lbListadoboz.Items.Count == 0)
            {
                btnLevesz.Enabled = false;
                btnKiurit.Enabled = false;
            }
            //Ha eddig el volt érve a limit, akkor legyen újra szerkeszthetõ a lista:
            if (btnHozzaad.Enabled == false)
            {
                btnHozzaad.Enabled = true;
                btnSzoveg.Enabled = true;
            }
        }

        private void btnKiurit_Click(object sender, EventArgs e)
        { //Ez a gomb kiüríti a teljes listadobozt
            btnLevesz.Enabled = false;
            btnKiurit.Enabled = false;
            lbListadoboz.Items.Clear(); //Clear() = Kiürít
            lElemszam.Text = Convert.ToString(lbListadoboz.Items.Count);
            if (btnHozzaad.Enabled == false)
            {
                btnHozzaad.Enabled = true;
                btnSzoveg.Enabled = true;
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        { //Bezárás gomb
            Application.Exit();
        }

        private void btnSzoveg_Click(object sender, EventArgs e)
        { //Tetszõleges szöveg bevitele gomb
            btnLevesz.Enabled = true;
            btnKiurit.Enabled = true;
            lbListadoboz.Items.Add(tbSzoveg.Text);
            lElemszam.Text = Convert.ToString(lbListadoboz.Items.Count);
            if (lbListadoboz.Items.Count == keret)
            {
                btnHozzaad.Enabled = false;
                btnSzoveg.Enabled = false;
                MessageBox.Show("Limit elérve!");
            }
        }

        private void rbEnged_CheckedChanged(object sender, EventArgs e)
        { //Bekapcsoló rádiógomb
            lbListadoboz.Visible = true;
            btnBezar.Enabled = true;
            btnHozzaad.Enabled = true;
            btnSzoveg.Enabled = true;
            tbSzoveg.Enabled = true;
            btnBovit.Enabled = true;
            lSzerkAllapot.Text = "Szerkeszthetõ";
        }

        private void btnBovit_Click(object sender, EventArgs e)
        { //Keret növelése gomb (5-rõl 10-re)
            keret = 10;
            //Ha esetleg korábban elértük az 5-ös keretet:
            if (btnHozzaad.Enabled == false)
            {
                btnHozzaad.Enabled = true;
                btnSzoveg.Enabled = true;
            }
            btnBovit.Enabled = false;
            btnVisszavesz.Enabled = true;
        }

        private void btnVisszavesz_Click(object sender, EventArgs e)
        { //Limit visszaállítása 5-re gomb
            keret = 5;
            btnVisszavesz.Enabled = false;
            btnBovit.Enabled = true;
            //Ha 5-nél több elemmel állítjuk vissza a limitet, akkor ürüljön ki a lista:
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
//listadobozNeve.Items.Add(újElem) --> Új elem felvitele a listadobozva
//listadobozNeve.Items.Count --> Listaelemek megszámlálása
//listadobozNeve.Items.Clear() --> Teljes doboz kiürítése
//listadobozNeve.Items.Remove(elem) --> adott elem törlése a listadobozból