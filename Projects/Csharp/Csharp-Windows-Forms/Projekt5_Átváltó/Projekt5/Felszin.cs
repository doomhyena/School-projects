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
    public partial class Felszin : Form
    {
        public Felszin()
        {
            InitializeComponent();
        }

        private void nudBevisz_ValueChanged(object sender, EventArgs e)
        { //Bevitt érték változásakor megjelennek a gombok:
            btnCmInch.Visible = true;
            btnInchCm.Visible = true;
            btnYardM.Visible = true;
            btnMYard.Visible = true;
            btnMfKm.Visible = true;
            btnKmMf.Visible = true;
        }

        private void btnVissza_Click(object sender, EventArgs e)
        { //Vissza gomb:
            Close();
            //Nem Application.Close(), mert nem az egész programot akarjuk bezárni
        }

        private void btnInchCm_Click(object sender, EventArgs e)
        { //Inch^2 --> Cm^2 gomb:
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 0.45;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "cm2";
        }

        private void btnCmInch_Click(object sender, EventArgs e)
        { //Cm^2 --> Inch^2 gomb:
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 0.155;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "inch2";
        }

        private void btnYardM_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 0.84;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "m2";
        }

        private void btnMYard_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 1.19;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "yard2";
        }

        private void btnMfKm_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 2.19;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "km2";
        }

        private void btnKmMf_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 0.38;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "mf2";
        }
    }
}
