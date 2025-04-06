namespace Futáskövető
{
    public partial class Form1 : Form
    {
        int napokSzama = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            //Nullázó gomb láthatóvá tétele:
            btnNullaz.Visible = true;
            //Ha nincs kitöltve a mező:
            if (tbMai.Text == "")
            {
                MessageBox.Show("Írj be egy számot.");
            }

            napokSzama += 1;

            if (napokSzama == 1)
            {
                tbH.Text = tbMai.Text;
            }
            else if (napokSzama == 2)
            {
                tbK.Text = tbMai.Text;
            }
            else if (napokSzama == 3)
            {
                tbSze.Text = tbMai.Text;
            }
            else if (napokSzama == 4)
            {
                tbCs.Text = tbMai.Text;
            }
            else if (napokSzama == 5)
            {
                tbP.Text = tbMai.Text;
            }
            else if (napokSzama == 6)
            {
                tbSzo.Text = tbMai.Text;
            }
            else if (napokSzama == 7)
            {
                tbV.Text = tbMai.Text;
            }
            else
            {
                tbMai.Enabled = false;
                MessageBox.Show("Mind a hét nap betelt!");
            }
            //Összesen eddig lefutott km-ek száma:
            int osszesen = Convert.ToInt32(tbH.Text) + Convert.ToInt32(tbK.Text) + Convert.ToInt32(tbSze.Text) + Convert.ToInt32(tbCs.Text) + Convert.ToInt32(tbP.Text) + Convert.ToInt32(tbSzo.Text) + Convert.ToInt32(tbV.Text);
            tbOsszesen.Text = Convert.ToString(osszesen);
            //Összesen eddig lefutott km-ek átlaga:
            double atlag = osszesen / napokSzama;
            tbAtlag.Text = Convert.ToString(atlag);
            //Beviteli szövegdoboz nullázása az új értékeknek:
            tbMai.Text = "";
        }

        private void btnNullaz_Click(object sender, EventArgs e)
        { //A nullázás mindent alaphelyzetbe állít:
            tbH.Text = "0";
            tbK.Text = "0";
            tbSze.Text = "0";
            tbCs.Text = "0";
            tbP.Text = "0";
            tbSzo.Text = "0";
            tbV.Text = "0";
            btnNullaz.Visible = false;
            tbMai.Text = "";
            tbAtlag.Text = "";
            tbOsszesen.Text = "";
            tbMai.Enabled = true;
            napokSzama = 0;
        }
    }
}
