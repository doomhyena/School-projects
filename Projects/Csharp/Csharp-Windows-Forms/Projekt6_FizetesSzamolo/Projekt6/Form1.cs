namespace Projekt6
{
    public partial class Form1 : Form
    {
        //�ra �s perc �rt�kek seg�dv�ltoz�i:
        int perc1 = 0, perc2 = 0, perc3 = 0, perc4 = 0, perc5 = 0;
        int ora1 = 0, ora2 = 0, ora3 = 0, ora4 = 0, ora5 = 0;
        double ado = 0.65;
        //Ez a 11 v�ltoz� b�rhonnan el�rhet� a programon bel�l
        public Form1()
        {
            InitializeComponent();
        }

        //A sz�vegdobozok alapram�retezett esem�nye a sz�veg v�ltoz�sa:
        private void tbHP_TextChanged(object sender, EventArgs e)
        { //H�tf�i perc doboz kezel�se:
            perc1 = int.Parse(tbHP.Text); //A be�rt �rt�ket elt�rolja a perc1-ben
            if (perc1 >= 60) //60 perc felett m�r az �ra �rt�k n�vekedjen
            {
                //Ebben az esetben ki�runk egy figyelmeztet�st:
                MessageBox.Show("60-n�l kisebb �rt�ked adj meg!");
            }
        }

        private void tbKP_TextChanged(object sender, EventArgs e)
        { //Keddi perc doboz kezel�se:
            perc2 = int.Parse(tbKP.Text);
            if (perc2 >= 60)
            {
                MessageBox.Show("60-n�l kisebb �rt�ked adj meg!");
            }
        }

        private void tbSzP_TextChanged(object sender, EventArgs e)
        {
            perc3 = int.Parse(tbSzP.Text);
            if (perc3 >= 60)
            {
                MessageBox.Show("60-n�l kisebb �rt�ked adj meg!");
            }
        }

        private void tbCsP_TextChanged(object sender, EventArgs e)
        {
            perc4 = int.Parse(tbCsP.Text);
            if (perc4 >= 60)
            {
                MessageBox.Show("60-n�l kisebb �rt�ked adj meg!");
            }
        }

        private void tbPP_TextChanged(object sender, EventArgs e)
        {
            perc5 = int.Parse(tbPP.Text);
            if (perc5 >= 60)
            {
                MessageBox.Show("60-n�l kisebb �rt�ked adj meg!");
            }
        }

        private void tbHO_TextChanged(object sender, EventArgs e)
        { //H�tf�i �ra doboz kezel�se:
            ora1 = int.Parse(tbHO.Text); //Elt�roljuk ora1-ben a h�tf�i �rasz�mot
            //Naponta legfeljebb 10 �r�t k�ne dolgozni:
            if (ora1 > 10)
            {
                MessageBox.Show("Max napi 10 �r�t dolgozhatsz");
            }
        }

        private void tbKO_TextChanged(object sender, EventArgs e)
        { //Keddi �ra doboz kezel�se:
            ora2 = int.Parse(tbKO.Text);
            if (ora2 > 10)
            {
                MessageBox.Show("Max napi 10 �r�t dolgozhatsz");
            }
        }

        private void tbSzO_TextChanged(object sender, EventArgs e)
        {
            ora3 = int.Parse(tbSzO.Text);
            if (ora3 > 10)
            {
                MessageBox.Show("Max napi 10 �r�t dolgozhatsz");
            }
        }

        private void tbCsO_TextChanged(object sender, EventArgs e)
        {
            ora4 = int.Parse(tbCsO.Text);
            if (ora4 > 10)
            {
                MessageBox.Show("Max napi 10 �r�t dolgozhatsz");
            }
        }

        private void tbPO_TextChanged(object sender, EventArgs e)
        {
            ora5 = int.Parse(tbPO.Text);
            if (ora5 > 10)
            {
                MessageBox.Show("Max napi 10 �r�t dolgozhatsz");
            }
        }

        private void btnFizetesSzamol_Click(object sender, EventArgs e)
        { //Fizet�s sz�mol�sa gomb
            //Percek �s �r�k �sszegz�se k�l�n:
            int osszesPerc = perc1 + perc2 + perc3 + perc4 + perc5;
            int osszesOra = ora1 + ora2 + ora3 + ora4 + ora5;
            //V�ltoz� az alap�r�k �s a percekb�l �sszetev�d� �r�k �sszegz�s�re:
            int oraSeged = osszesOra + (osszesPerc / 60);
            //Ezut�n az 1 eg�sz �r�t ki nem tev� megmardt perceket sz�moljuk ki:
            int percSeged = (osszesPerc % 60); // A % oszt�s csak a marad�kot adja vissza
            //�sszesen h�ny perc lesz mindez:
            int seged = (osszesOra * 60) + osszesPerc;
            int oraber = 0;
            //Az �rab�r a beoszt�st�l f�gg, ami a leg�rd�l� list�n�l lett kiv�lasztva:
            if (cbBeosztas.Text == "F�n�k")
            {
                oraber = 5000;
            }
            else if (cbBeosztas.Text == "Titk�r")
            {
                oraber = 4500;
            }
            else if (cbBeosztas.Text == "Admin")
            {
                oraber = 4000;
            }

            //Dolgozzuk fel az adatokat �s sz�moljuk ki a fizet�st:
            if (cbBeosztas.Text == "")
            {
                MessageBox.Show("V�lassz ki egy beoszt�st!");
            }
            else
            {
                //Brutt� fizet�s kisz�mol�sa:
                double brutto1 = oraSeged * oraber;
                double brutto2 = percSeged * oraber;
                double brutto3 = brutto1 + brutto2;
                double hetiBrutto = Math.Round(brutto3, 2); //Kerek�t�s 2 tizedesre
                tbBrutto.Text = hetiBrutto.ToString(); //Eredm�ny ki�r�sa a brutt� dobozba
                //Nett� fizet�s kisz�mol�sa:
                double nettoSeged = hetiBrutto * ado;
                double hetiNetto = Math.Round(nettoSeged, 2);
                tbNetto.Text = hetiNetto.ToString();
                //Egy felugr� �zenettel mondatban is megfogalmazzuk az eredm�nyt:
                MessageBox.Show(tbNev.Text + " (" + tbId.Text + " ID-j�) alkalmazott nett� fizet�se: " + hetiNetto + " Ft.");
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        { //Kil�p�s gomb
            Close();
        }

        private void lOraSugo_Click(object sender, EventArgs e)
        { //Ha a "?" cimk�re kattintunk az �r�kn�l, akkor ki�r egy �zenetet:
            MessageBox.Show("Egy napra legfeljebb 10 �r�t �rj be.");
        }

        private void lPercSugo_Click(object sender, EventArgs e)
        { //Perc mez�k feletti "?" cimke
            MessageBox.Show("A perc mez�kbe 60-n�l kisebb �rt�ket adj meg.");
        }

        private void lNettoSugo_Click(object sender, EventArgs e)
        { //"?" cimke a nett� fizet�sn�l
            MessageBox.Show("A nett� az a brutt� 65%-a.");
        }

        private void btnNullaz_Click(object sender, EventArgs e)
        { //A Null�z�s gomb ki�r�ti az alkalmazotti adatokat �s vossza�ll�tja az alapad�t:
            tbNev.Text = "";
            tbId.Text = "";
            cbBeosztas.Text = "";
            cbAdoKedv.Enabled = true;
            cbAdoKedv.Checked = false;
            ado = 0.65;
        }

        private void lBeosztasSeged_Click(object sender, EventArgs e)
        { //S�g� a beoszt�s v�laszt�s�hoz:
            MessageBox.Show("Csak az itt felsoroltak k�z�l lehet poz�ci�t megadni.");
        }

        private void cbAdoKedv_CheckedChanged(object sender, EventArgs e)
        { //Ad�kedvezm�ny bejel�l�sekor:
            if (cbAdoKedv.Checked)
            {
                ado = 0.8;
                cbAdoKedv.Enabled = false;
                MessageBox.Show("Az ad� 35 %-r�l 20 %-ra cs�kkent.");
            }  
        }
    }
}
