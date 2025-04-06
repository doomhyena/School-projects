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
    public partial class Hossz : Form
    {
        public Hossz()
        {
            InitializeComponent();
        }

        private void nudBevisz_ValueChanged(object sender, EventArgs e)
        { //Ha megváltozik a számdoboz értéke, akkor megjelennek a gombok
            btnCmKm.Visible = true;
            btnKmCm.Visible = true;
            btnMCm.Visible = true;
            btnCmM.Visible = true;
            btnKmM.Visible = true;
            btnMKm.Visible = true;
        }

        private void btnCmM_Click(object sender, EventArgs e)
        { //Cm-ről Méterre való átváltás gombja:
            //Beolvassuk törtszámként a bevitt értéket és át is váltjuk:
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 0.01;
            //Eredmény bevitele az eredménydobozba:
            tbErdmeny.Text = megoldas.ToString(); //textBox-ba string való
            //Láthatóvá tesszük az eredmény elemeket:
            lEredmeny.Visible = true;
            tbErdmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "m.";
        }

        private void btnMCm_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 100;
            tbErdmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbErdmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "cm.";
        }

        private void btnMKm_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) / 1000;
            tbErdmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbErdmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "km.";
        }

        private void btnKmM_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 1000;
            tbErdmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbErdmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "m.";
        }

        private void btnCmKm_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 0.00001;
            tbErdmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbErdmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "km.";
        }

        private void btnKmCm_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 100000;
            tbErdmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbErdmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "cm.";
        }

        private void btnVissza_Click(object sender, EventArgs e)
        { //Visszalépés a főablakra gomb
            Close();
        }
    }
}
