namespace Projekt5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        { //Bez�r�s gomb
            Close();
        }

        private void btnHosszusag_Click(object sender, EventArgs e)
        { //Ez a gomb nyitja meg a Hossz ablakot
            //Lesz egy "Hossz ablak t�pus�" h1 objektum. Tartalma egy �j Hossz ablak
            Hossz h1 = new Hossz();
            //Meg is kell mutatni ezt az �j ablak p�ld�nyt:
            h1.ShowDialog();
        }

        private void btnFelszin_Click(object sender, EventArgs e)
        {
            Felszin f1 = new Felszin();
            f1.ShowDialog();
        }

        private void btnUrtartalom_Click(object sender, EventArgs e)
        {
            Urtartalom u1 = new Urtartalom();
            u1.ShowDialog();
        }

        private void btnSuly_Click(object sender, EventArgs e)
        {
            Suly s1 = new Suly();
            s1.ShowDialog();
        }

        private void btnSegitseg_Click(object sender, EventArgs e)
        {
            Segitseg seg1 = new Segitseg();
            seg1.ShowDialog();
        }

        private void cbIdo_CheckedChanged(object sender, EventArgs e)
        { //Id� mutat� pip�sdoboz m�k�d�se:
            lIdo.Text = DateTime.Now.ToString();
            //(ToString kellett, hogy megjelenjen feliratk�nt)
            lIdo.Visible = true;
            cbIdo.Enabled = false;
        }
    }
}
