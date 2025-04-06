namespace Projekt1
{
    public partial class Form1 : Form
    {
        //A public FormNeve() f�ggv�ny automatikusan van l�trehozva, nem kell hozz�ny�lni:
        public Form1()
        {
            InitializeComponent();
        }

        /*A gombra t�rt�n� dupla kattint�ssal automatikusan l�trej�n ez az esem�nyfigyel�, 
         * a sablon esem�nyparam�terekkel: */
        private void btnAtir_Click(object sender, EventArgs e)
        {
            //A gombnyom�s hat�s�ra a mellette l�v� cimke sz�vege v�ltozzon meg:
            lAtirando.Text = "�j sz�veg";
            //A gombokn�l a kattint�s az alapram�retezett esem�ny.
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            //A doboz melletti cimke �l�ben k�veti a tartalomv�ltoz�st:
            lSzovegdobozKoveto.Text = tb1.Text;
            //A sz�vegdobozokn�l a sz�vegv�ltoz�s az alapram�retezett esem�ny.
        }

        private void cbBekapcsolo_CheckedChanged(object sender, EventArgs e)
        {
            //A checkBox melletti sz�veg v�ltozzon meg:
            lPipa.Text = "Bepip�lva!";
            //A pipa be- vagy kikapcsol�sa jelent egy esem�nyt a checkBox-n�l.
        }

        private void cbMegjelenit_CheckedChanged(object sender, EventArgs e)
        {
            //Ha bepip�ljuk, akkor jelenjen meg a mellette l�v� cimke:
            if (lPipa2.Visible == false)
            {
                lPipa2.Visible = true; //Visible tulajdons�g: l�that�-e az elem?
                cbMegjelenit.Text = "Elrejt";
            }
            else
            {
                lPipa2.Visible = false;
                cbMegjelenit.Text = "Megjelen�t";
            }
        }

        private void btnPipaMegj_Click(object sender, EventArgs e)
        {
            //Jelen�tse meg a mellette l�v� pip�sdobozt:
            cbGomb2Megj.Visible = true;
        }

        private void cbGomb2Megj_CheckedChanged(object sender, EventArgs e)
        {
            //Jelen�tse meg a mellette l�v� "Visszacsin�l" gombot:
            btnVisszacsinal.Visible = true;
        }

        private void btnVisszacsinal_Click(object sender, EventArgs e)
        {
            //Az el�z� 2 elemet �ll�tsa vissza az eredeti �llapotba:
            cbGomb2Megj.Visible = false;
            btnVisszacsinal.Visible = false;
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Ez a parancs bez�rja ezt a programot.
        }

        private void rbMegjelenit_CheckedChanged(object sender, EventArgs e)
        {
            //Jelenjen meg alatta a sz�m�ll�t� �s a t�lt�s cs�k:
            nudToltes.Visible = true;
            pbCsik.Visible = true;
            //A r�di�gomb felirata pedig t�nj�n el:
            rbMegjelenit.Text = "";
        }

        private void nudToltes_ValueChanged(object sender, EventArgs e)
        {
            //Ha 1-el n� a sz�ml�l� �rt�ke, akkor az alatta l�v� t�lt�cs�k 10-el n�j�n:
            if (pbCsik.Value < 100) //de csak akkor, ha m�g nincs kimaxolva
            {
                pbCsik.Value += 10; //Value tulajdons�g: tartalmazott �rt�k
            }
            else
            {
                /*Ha a cs�k el�rte a 100-as �rt�ket, akkor az is meg a sz�ml�l� is 
                 * �lljon vissza 0-ra: */
                pbCsik.Value = 0;
                nudToltes.Value = 0;
            }
        }

        private void kil�p�sToolStripMenuItem_Click(object sender, EventArgs e)
        {//A fenti men�sorban is van egy kil�p�s opci�:
            Application.Exit();
        }
    }
    /*
     * Praktik�k:
     *      - A v�ltoz�k elnevez�se: elemt�pus r�vid�t�se + funkci� (pl. btnKilep).
     *      - Minden elemnek van egy saj�tos esem�nye, amit kezel (pl. pipa ke/kiv�tele).
     *      - Az esem�nyfigyel� az elemre t�rt�n� dupla kattint�ssal j�n l�tre automatikusan.
    */
}
