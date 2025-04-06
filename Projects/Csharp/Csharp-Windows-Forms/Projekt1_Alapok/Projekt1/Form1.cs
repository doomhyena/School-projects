namespace Projekt1
{
    public partial class Form1 : Form
    {
        //A public FormNeve() függvény automatikusan van létrehozva, nem kell hozzányúlni:
        public Form1()
        {
            InitializeComponent();
        }

        /*A gombra történõ dupla kattintással automatikusan létrejön ez az eseményfigyelõ, 
         * a sablon eseményparaméterekkel: */
        private void btnAtir_Click(object sender, EventArgs e)
        {
            //A gombnyomás hatására a mellette lévõ cimke szövege változzon meg:
            lAtirando.Text = "Új szöveg";
            //A gomboknál a kattintás az alapraméretezett esemény.
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            //A doboz melletti cimke élõben követi a tartalomváltozást:
            lSzovegdobozKoveto.Text = tb1.Text;
            //A szövegdobozoknál a szövegváltozás az alapraméretezett esemény.
        }

        private void cbBekapcsolo_CheckedChanged(object sender, EventArgs e)
        {
            //A checkBox melletti szöveg változzon meg:
            lPipa.Text = "Bepipálva!";
            //A pipa be- vagy kikapcsolása jelent egy eseményt a checkBox-nál.
        }

        private void cbMegjelenit_CheckedChanged(object sender, EventArgs e)
        {
            //Ha bepipáljuk, akkor jelenjen meg a mellette lévõ cimke:
            if (lPipa2.Visible == false)
            {
                lPipa2.Visible = true; //Visible tulajdonság: látható-e az elem?
                cbMegjelenit.Text = "Elrejt";
            }
            else
            {
                lPipa2.Visible = false;
                cbMegjelenit.Text = "Megjelenít";
            }
        }

        private void btnPipaMegj_Click(object sender, EventArgs e)
        {
            //Jelenítse meg a mellette lévõ pipásdobozt:
            cbGomb2Megj.Visible = true;
        }

        private void cbGomb2Megj_CheckedChanged(object sender, EventArgs e)
        {
            //Jelenítse meg a mellette lévõ "Visszacsinál" gombot:
            btnVisszacsinal.Visible = true;
        }

        private void btnVisszacsinal_Click(object sender, EventArgs e)
        {
            //Az elõzõ 2 elemet állítsa vissza az eredeti állapotba:
            cbGomb2Megj.Visible = false;
            btnVisszacsinal.Visible = false;
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Ez a parancs bezárja ezt a programot.
        }

        private void rbMegjelenit_CheckedChanged(object sender, EventArgs e)
        {
            //Jelenjen meg alatta a számállító és a töltés csík:
            nudToltes.Visible = true;
            pbCsik.Visible = true;
            //A rádiógomb felirata pedig tûnjön el:
            rbMegjelenit.Text = "";
        }

        private void nudToltes_ValueChanged(object sender, EventArgs e)
        {
            //Ha 1-el nõ a számláló értéke, akkor az alatta lévõ töltõcsík 10-el nõjön:
            if (pbCsik.Value < 100) //de csak akkor, ha még nincs kimaxolva
            {
                pbCsik.Value += 10; //Value tulajdonság: tartalmazott érték
            }
            else
            {
                /*Ha a csík elérte a 100-as értéket, akkor az is meg a számláló is 
                 * álljon vissza 0-ra: */
                pbCsik.Value = 0;
                nudToltes.Value = 0;
            }
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {//A fenti menüsorban is van egy kilépés opció:
            Application.Exit();
        }
    }
    /*
     * Praktikák:
     *      - A változók elnevezése: elemtípus rövidítése + funkció (pl. btnKilep).
     *      - Minden elemnek van egy sajátos eseménye, amit kezel (pl. pipa ke/kivétele).
     *      - Az eseményfigyelõ az elemre történõ dupla kattintással jön létre automatikusan.
    */
}
