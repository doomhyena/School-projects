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
    public partial class Urtartalom : Form
    {
        public Urtartalom()
        {
            InitializeComponent();
        }

        private void btnCmM_Click(object sender, EventArgs e)
        { //Köbcentiből köbméterbe gomb:
            double megoldas = Convert.ToDouble(nudBevisz.Value) / 1000000;
            tbEredmeny.Text = megoldas.ToString();
            tbEredmeny.Visible = true;
            lEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "m3";
        }

        private void nudBevisz_ValueChanged(object sender, EventArgs e)
        { //Értékváltozásnál láthatóvá válnak a gombok:
            btnCmDm.Visible = true;
            btnDmCm.Visible = true;
            btnMCm.Visible = true;
            btnCmM.Visible = true;
            btnMKm.Visible = true;
            btnKmM.Visible = true;
        }

        private void btnVissza_Click(object sender, EventArgs e)
        { //Visszalépés a főoldalra gomb:
            Close();
        }

        private void btnMCm_Click(object sender, EventArgs e)
        { //Köbméterből köbcentibe gomb:
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 1000000;
            tbEredmeny.Text = megoldas.ToString();
            tbEredmeny.Visible = true;
            lEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "cm3";
        }

        private void btnMKm_Click(object sender, EventArgs e)
        { //Köbméterből köbkilométerbe gomb:
            double megoldas = Convert.ToDouble(nudBevisz.Value) / 1000000000;
            tbEredmeny.Text = megoldas.ToString();
            tbEredmeny.Visible = true;
            lEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "km3";
        }

        private void btnKmM_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 1000000000;
            tbEredmeny.Text = megoldas.ToString();
            tbEredmeny.Visible = true;
            lEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "m3";
        }

        private void btnCmDm_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) / 1000;
            tbEredmeny.Text = megoldas.ToString();
            tbEredmeny.Visible = true;
            lEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "dm3";
        }

        private void btnDmCm_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 1000;
            tbEredmeny.Text = megoldas.ToString();
            tbEredmeny.Visible = true;
            lEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "cm3";
        }
    }
}
