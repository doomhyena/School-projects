namespace Projekt8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FejreszMegjelenites()
        { //A nagy szövegdoboz tetejére automatikusan beírodnak az alábbiak:
            rtbMezo.AppendText("Csónakbérlõ vállalat" + "\n");
            rtbMezo.AppendText("Ügyfél számla \n" + "\n");
            rtbMezo.AppendText("Elem".PadRight(15) + "Nap".PadRight(10) + "Ár".PadRight(5) + "              Mennyiség".PadRight(1));
            //padRight() --> Jobbra igazítás
        }
        private void Form1_Load(object sender, EventArgs e)
        { //A form megnyitásakor ezek történnek:
            FejreszMegjelenites();
            DateTime jelenDatum = DateTime.Now;
            lDatum.Text = jelenDatum.ToShortDateString();
        }

        private void kilépToolStripMenuItem_Click(object sender, EventArgs e)
        { //Kilépés elem
            this.Close();
        }

        private void Kiszamol()
        { //Összesített árak kiszámolása (amit minden változtatáskor meghívunk majd)
            //Alapváltozók:
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
            //Napok száma:
            int napok = Convert.ToInt32(nudNap.Value);
            //Minden újraszámolásnál kitöröljük a teljes elõzõ tartalmat és újraírjuk:
            rtbMezo.Clear();
            FejreszMegjelenites();

            if (rbKenu.Checked)
            {
                osszesitett = napok * kenuAlap;
                rtbMezo.AppendText("\nKenu".PadRight(18) + napok.ToString("f0").PadRight(8) + kenuAlap.ToString("c") + "  " + osszesitett.ToString("c").PadLeft(15));
                //"f0" --> Lebegõpontos érték legyen, 0 tizedessel
                //"c" --> Pnzérték (currency)
            }
            else if (rbEvezos.Checked)
            {
                osszesitett = napok * evezosAlap;
                rtbMezo.AppendText("\nEvezõs".PadRight(18) + napok.ToString("f0").PadRight(8) + evezosAlap.ToString("c") + "  " + osszesitett.ToString("c").PadLeft(10));
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
            //A pipáknál mind a 4 elem külön if-et kap:
            if (cbHorgaszbot.Checked)
            {
                horgaszbotAr = horgaszbotAlap * napok;
                osszesitett = osszesitett + horgaszbotAr;
                rtbMezo.AppendText("\nHorgászbot".PadRight(18) + napok.ToString("f0").PadRight(8) + horgaszbotAlap.ToString("c") + "  " + horgaszbotAr.ToString("c").PadLeft(10));
            }
            if (cbMelleny.Checked)
            {
                mellenyAr = mellenyAlap * napok;
                osszesitett = osszesitett + mellenyAr;
                rtbMezo.AppendText("\nMellény".PadRight(18) + napok.ToString("f0").PadRight(8) + mellenyAlap.ToString("c") + "  " + mellenyAr.ToString("c").PadLeft(10));
            }
            if (cbSzonar.Checked)
            {
                szonarAr = szonarAlap * napok;
                osszesitett = osszesitett + szonarAr;
                rtbMezo.AppendText("\nSzonár".PadRight(18) + napok.ToString("f0").PadRight(8) + szonarAlap.ToString("c") + "  " + szonarAr.ToString("c").PadLeft(10));
            }
            if (cbHalo.Checked)
            {
                haloAr = haloAlap * napok;
                osszesitett = osszesitett + haloAr;
                rtbMezo.AppendText("\nHáló".PadRight(18) + napok.ToString("f0").PadRight(8) + haloAlap.ToString("c") + "  " + haloAr.ToString("c").PadLeft(10));
            }
            //Árak összesítése:
            decimal veglegesAdo = osszesitett * ado;
            egyenleg = osszesitett + veglegesAdo;
            //Kiírás a dobozba:
            rtbMezo.AppendText("\nRész " + osszesitett.ToString("c").PadLeft(32));
            rtbMezo.AppendText("\nAdó " + ado.ToString("p2") + veglegesAdo.ToString("c").PadLeft(25));
            rtbMezo.AppendText("\nÖsszeg" + egyenleg.ToString("c").PadLeft(34));
        }

        private void kiürítToolStripMenuItem_Click(object sender, EventArgs e)
        { //Kiürítés opció, ami mindent visszaállít alaphelyzetbe
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

        //Minden egyes változásnál újraszámoljuk az eredményszámlát:
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
