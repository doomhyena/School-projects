namespace Projekt6
{
    public partial class Form1 : Form
    {
        //Óra és perc értékek segédváltozói:
        int perc1 = 0, perc2 = 0, perc3 = 0, perc4 = 0, perc5 = 0;
        int ora1 = 0, ora2 = 0, ora3 = 0, ora4 = 0, ora5 = 0;
        double ado = 0.65;
        //Ez a 11 változó bárhonnan elérhetó a programon belül
        public Form1()
        {
            InitializeComponent();
        }

        //A szövegdobozok alapraméretezett eseménye a szöveg változása:
        private void tbHP_TextChanged(object sender, EventArgs e)
        { //Hétfõi perc doboz kezelése:
            perc1 = int.Parse(tbHP.Text); //A beírt értéket eltárolja a perc1-ben
            if (perc1 >= 60) //60 perc felett már az óra érték növekedjen
            {
                //Ebben az esetben kiírunk egy figyelmeztetést:
                MessageBox.Show("60-nál kisebb értéked adj meg!");
            }
        }

        private void tbKP_TextChanged(object sender, EventArgs e)
        { //Keddi perc doboz kezelése:
            perc2 = int.Parse(tbKP.Text);
            if (perc2 >= 60)
            {
                MessageBox.Show("60-nál kisebb értéked adj meg!");
            }
        }

        private void tbSzP_TextChanged(object sender, EventArgs e)
        {
            perc3 = int.Parse(tbSzP.Text);
            if (perc3 >= 60)
            {
                MessageBox.Show("60-nál kisebb értéked adj meg!");
            }
        }

        private void tbCsP_TextChanged(object sender, EventArgs e)
        {
            perc4 = int.Parse(tbCsP.Text);
            if (perc4 >= 60)
            {
                MessageBox.Show("60-nál kisebb értéked adj meg!");
            }
        }

        private void tbPP_TextChanged(object sender, EventArgs e)
        {
            perc5 = int.Parse(tbPP.Text);
            if (perc5 >= 60)
            {
                MessageBox.Show("60-nál kisebb értéked adj meg!");
            }
        }

        private void tbHO_TextChanged(object sender, EventArgs e)
        { //Hétfõi óra doboz kezelése:
            ora1 = int.Parse(tbHO.Text); //Eltároljuk ora1-ben a hétfõi óraszámot
            //Naponta legfeljebb 10 órát kéne dolgozni:
            if (ora1 > 10)
            {
                MessageBox.Show("Max napi 10 órát dolgozhatsz");
            }
        }

        private void tbKO_TextChanged(object sender, EventArgs e)
        { //Keddi óra doboz kezelése:
            ora2 = int.Parse(tbKO.Text);
            if (ora2 > 10)
            {
                MessageBox.Show("Max napi 10 órát dolgozhatsz");
            }
        }

        private void tbSzO_TextChanged(object sender, EventArgs e)
        {
            ora3 = int.Parse(tbSzO.Text);
            if (ora3 > 10)
            {
                MessageBox.Show("Max napi 10 órát dolgozhatsz");
            }
        }

        private void tbCsO_TextChanged(object sender, EventArgs e)
        {
            ora4 = int.Parse(tbCsO.Text);
            if (ora4 > 10)
            {
                MessageBox.Show("Max napi 10 órát dolgozhatsz");
            }
        }

        private void tbPO_TextChanged(object sender, EventArgs e)
        {
            ora5 = int.Parse(tbPO.Text);
            if (ora5 > 10)
            {
                MessageBox.Show("Max napi 10 órát dolgozhatsz");
            }
        }

        private void btnFizetesSzamol_Click(object sender, EventArgs e)
        { //Fizetés számolása gomb
            //Percek és órák összegzése külön:
            int osszesPerc = perc1 + perc2 + perc3 + perc4 + perc5;
            int osszesOra = ora1 + ora2 + ora3 + ora4 + ora5;
            //Változó az alapórák és a percekbõl összetevõdõ órák összegzésére:
            int oraSeged = osszesOra + (osszesPerc / 60);
            //Ezután az 1 egész órát ki nem tevõ megmardt perceket számoljuk ki:
            int percSeged = (osszesPerc % 60); // A % osztás csak a maradékot adja vissza
            //Összesen hány perc lesz mindez:
            int seged = (osszesOra * 60) + osszesPerc;
            int oraber = 0;
            //Az órabér a beosztástól függ, ami a legördülõ listánál lett kiválasztva:
            if (cbBeosztas.Text == "Fõnök")
            {
                oraber = 5000;
            }
            else if (cbBeosztas.Text == "Titkár")
            {
                oraber = 4500;
            }
            else if (cbBeosztas.Text == "Admin")
            {
                oraber = 4000;
            }

            //Dolgozzuk fel az adatokat és számoljuk ki a fizetést:
            if (cbBeosztas.Text == "")
            {
                MessageBox.Show("Válassz ki egy beosztást!");
            }
            else
            {
                //Bruttó fizetés kiszámolása:
                double brutto1 = oraSeged * oraber;
                double brutto2 = percSeged * oraber;
                double brutto3 = brutto1 + brutto2;
                double hetiBrutto = Math.Round(brutto3, 2); //Kerekítés 2 tizedesre
                tbBrutto.Text = hetiBrutto.ToString(); //Eredmény kiírása a bruttó dobozba
                //Nettó fizetés kiszámolása:
                double nettoSeged = hetiBrutto * ado;
                double hetiNetto = Math.Round(nettoSeged, 2);
                tbNetto.Text = hetiNetto.ToString();
                //Egy felugró üzenettel mondatban is megfogalmazzuk az eredményt:
                MessageBox.Show(tbNev.Text + " (" + tbId.Text + " ID-jû) alkalmazott nettó fizetése: " + hetiNetto + " Ft.");
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        { //Kilépés gomb
            Close();
        }

        private void lOraSugo_Click(object sender, EventArgs e)
        { //Ha a "?" cimkére kattintunk az óráknál, akkor kiír egy üzenetet:
            MessageBox.Show("Egy napra legfeljebb 10 órát írj be.");
        }

        private void lPercSugo_Click(object sender, EventArgs e)
        { //Perc mezõk feletti "?" cimke
            MessageBox.Show("A perc mezõkbe 60-nál kisebb értéket adj meg.");
        }

        private void lNettoSugo_Click(object sender, EventArgs e)
        { //"?" cimke a nettó fizetésnél
            MessageBox.Show("A nettó az a bruttó 65%-a.");
        }

        private void btnNullaz_Click(object sender, EventArgs e)
        { //A Nullázás gomb kiüríti az alkalmazotti adatokat és vosszaállítja az alapadót:
            tbNev.Text = "";
            tbId.Text = "";
            cbBeosztas.Text = "";
            cbAdoKedv.Enabled = true;
            cbAdoKedv.Checked = false;
            ado = 0.65;
        }

        private void lBeosztasSeged_Click(object sender, EventArgs e)
        { //Súgó a beosztás választásához:
            MessageBox.Show("Csak az itt felsoroltak közül lehet pozíciót megadni.");
        }

        private void cbAdoKedv_CheckedChanged(object sender, EventArgs e)
        { //Adókedvezmény bejelölésekor:
            if (cbAdoKedv.Checked)
            {
                ado = 0.8;
                cbAdoKedv.Enabled = false;
                MessageBox.Show("Az adó 35 %-ról 20 %-ra csökkent.");
            }  
        }
    }
}
