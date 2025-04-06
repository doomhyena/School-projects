namespace Projekt8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FejreszMegjelenites()
        { //A nagy sz�vegdoboz tetej�re automatikusan be�rodnak az al�bbiak:
            rtbMezo.AppendText("Cs�nakb�rl� v�llalat" + "\n");
            rtbMezo.AppendText("�gyf�l sz�mla \n" + "\n");
            rtbMezo.AppendText("Elem".PadRight(15) + "Nap".PadRight(10) + "�r".PadRight(5) + "              Mennyis�g".PadRight(1));
            //padRight() --> Jobbra igaz�t�s
        }
        private void Form1_Load(object sender, EventArgs e)
        { //A form megnyit�sakor ezek t�rt�nnek:
            FejreszMegjelenites();
            DateTime jelenDatum = DateTime.Now;
            lDatum.Text = jelenDatum.ToShortDateString();
        }

        private void kil�pToolStripMenuItem_Click(object sender, EventArgs e)
        { //Kil�p�s elem
            this.Close();
        }

        private void Kiszamol()
        { //�sszes�tett �rak kisz�mol�sa (amit minden v�ltoztat�skor megh�vunk majd)
            //Alapv�ltoz�k:
            const decimal ado = .05m;
            decimal osszesitett = 0;
            decimal egyenleg = 0;
            decimal horgaszbotAr = 0;
            decimal mellenyAr = 0;
            decimal szonarAr = 0;
            decimal haloAr = 0;
            decimal kenuAlap = 29000;
            decimal evezosAlap = 24000;
            decimal motorosAlap = 45000;
            decimal miniyachtAlap = 85000;
            decimal horgaszbotAlap = 15000;
            decimal mellenyAlap = 2000;
            decimal szonarAlap = 12000;
            decimal haloAlap = 5000;
            //Napok sz�ma:
            int napok = Convert.ToInt32(nudNap.Value);
            //Minden �jrasz�mol�sn�l kit�r�lj�k a teljes el�z� tartalmat �s �jra�rjuk:
            rtbMezo.Clear();
            FejreszMegjelenites();

            if (rbKenu.Checked)
            {
                osszesitett = napok * kenuAlap;
                rtbMezo.AppendText("\nKenu".PadRight(18) + napok.ToString("f0").PadRight(8) + kenuAlap.ToString("c") + "  " + osszesitett.ToString("c").PadLeft(15));
                //"f0" --> Lebeg�pontos �rt�k legyen, 0 tizedessel
                //"c" --> Pnz�rt�k (currency)
            }
            else if (rbEvezos.Checked)
            {
                osszesitett = napok * evezosAlap;
                rtbMezo.AppendText("\nEvez�s".PadRight(18) + napok.ToString("f0").PadRight(8) + evezosAlap.ToString("c") + "  " + osszesitett.ToString("c").PadLeft(10));
            }
            else if (rbMotoros.Checked)
            {
                osszesitett = napok * motorosAlap;
                rtbMezo.AppendText("\nMotoros".PadRight(18) + napok.ToString("f0").PadRight(8) + motorosAlap.ToString("c") + "  " + osszesitett.ToString("c").PadLeft(10));
            }
            else
            {
                osszesitett = napok * miniyachtAlap;
                rtbMezo.AppendText("\nMiniyacht".PadRight(18) + napok.ToString("f0").PadRight(8) + miniyachtAlap.ToString("c") + "  " + osszesitett.ToString("c").PadLeft(10));
            }
            //A pip�kn�l mind a 4 elem k�l�n if-et kap:
            if (cbHorgaszbot.Checked)
            {
                horgaszbotAr = horgaszbotAlap * napok;
                osszesitett = osszesitett + horgaszbotAr;
                rtbMezo.AppendText("\nHorg�szbot".PadRight(18) + napok.ToString("f0").PadRight(8) + horgaszbotAlap.ToString("c") + "  " + horgaszbotAr.ToString("c").PadLeft(10));
            }
            if (cbMelleny.Checked)
            {
                mellenyAr = mellenyAlap * napok;
                osszesitett = osszesitett + mellenyAr;
                rtbMezo.AppendText("\nMell�ny".PadRight(18) + napok.ToString("f0").PadRight(8) + mellenyAlap.ToString("c") + "  " + mellenyAr.ToString("c").PadLeft(10));
            }
            if (cbSzonar.Checked)
            {
                szonarAr = szonarAlap * napok;
                osszesitett = osszesitett + szonarAr;
                rtbMezo.AppendText("\nSzon�r".PadRight(18) + napok.ToString("f0").PadRight(8) + szonarAlap.ToString("c") + "  " + szonarAr.ToString("c").PadLeft(10));
            }
            if (cbHalo.Checked)
            {
                haloAr = haloAlap * napok;
                osszesitett = osszesitett + haloAr;
                rtbMezo.AppendText("\nH�l�".PadRight(18) + napok.ToString("f0").PadRight(8) + haloAlap.ToString("c") + "  " + haloAr.ToString("c").PadLeft(10));
            }
            //�rak �sszes�t�se:
            decimal veglegesAdo = osszesitett * ado;
            egyenleg = osszesitett + veglegesAdo;
            //Ki�r�s a dobozba:
            rtbMezo.AppendText("\nR�sz " + osszesitett.ToString("c").PadLeft(32));
            rtbMezo.AppendText("\nAd� " + ado.ToString("p2") + veglegesAdo.ToString("c").PadLeft(25));
            rtbMezo.AppendText("\n�sszeg" + egyenleg.ToString("c").PadLeft(34));
        }

        private void ki�r�tToolStripMenuItem_Click(object sender, EventArgs e)
        { //Ki�r�t�s opci�, ami mindent vissza�ll�t alaphelyzetbe
            rtbMezo.Clear();
            rbKenu.Checked = true;
            rbEvezos.Checked = false;
            rbMiniyacht.Checked = false;
            rbMotoros.Checked = false;
            cbHalo.Checked = false;
            cbHorgaszbot.Checked = false;
            cbSzonar.Checked = false;
            cbMelleny.Checked = false;
            nudNap.Value = 1;
            FejreszMegjelenites();
        }

        //Minden egyes v�ltoz�sn�l �jrasz�moljuk az eredm�nysz�ml�t:
        private void nudNap_ValueChanged(object sender, EventArgs e)
        {
            Kiszamol();
        }

        private void rbKenu_CheckedChanged(object sender, EventArgs e)
        {
            Kiszamol();
        }

        private void rbEvezos_CheckedChanged(object sender, EventArgs e)
        {
            Kiszamol();
        }

        private void rbMotoros_CheckedChanged(object sender, EventArgs e)
        {
            Kiszamol();
        }

        private void rbMiniyacht_CheckedChanged(object sender, EventArgs e)
        {
            Kiszamol();
        }

        private void cbHorgaszbot_CheckedChanged(object sender, EventArgs e)
        {
            Kiszamol();
        }

        private void cbMelleny_CheckedChanged(object sender, EventArgs e)
        {
            Kiszamol();
        }

        private void cbSzonar_CheckedChanged(object sender, EventArgs e)
        {
            Kiszamol();
        }

        private void cbHalo_CheckedChanged(object sender, EventArgs e)
        {
            Kiszamol();
        }
    }
}
