using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt5
{
    public partial class Segitseg : Form
    {
        public Segitseg()
        {
            InitializeComponent();
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        { //Első pipa esetén:
            //Második sor láthatóvá tétele:
            l2.Visible = true;
            cb2.Visible = true;
            //Első pipa kikapcsolása:
            cb1.Enabled = false;
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        { //Második pipa esetén:
            l3.Visible = true;
            cb3.Visible = true;
            cb2.Enabled = false;
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        { //Harmadik pipa esetén megjelenik minden más:
            btnFooldalra.Visible = true;
            l4.Visible = true;
            btnFelszin.Visible = true;
            btnUrmertek.Visible = true;
            btnHossz.Visible = true;
            btnSuly.Visible = true;
            cb3.Enabled = false;
        }

        private void btnFooldalra_Click(object sender, EventArgs e)
        { //Vissza a főoldalra gomb: bezárja ezt az ablakot:
            Close();
        }

        /*Az alsó 4 gomb nem csak bezárja ezt az ablakot, 
         * hanem megnyitja az adott váltási opciót is. */
        private void btnHossz_Click(object sender, EventArgs e)
        {
            Hossz h = new Hossz();
            h.ShowDialog();
            Close();
        }

        private void btnFelszin_Click(object sender, EventArgs e)
        {
            Felszin f = new Felszin();
            f.ShowDialog();
            Close();
        }

        private void btnUrmertek_Click(object sender, EventArgs e)
        {
            Urtartalom u = new Urtartalom();
            u.ShowDialog();
            Close();
        }

        private void btnSuly_Click(object sender, EventArgs e)
        {
            Suly s = new Suly();
            s.ShowDialog();
            Close();
        }
    }
}
