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
    public partial class Suly : Form
    {
        public Suly()
        {
            InitializeComponent();
        }

        private void nudBevisz_ValueChanged(object sender, EventArgs e)
        { //Értékmegadáskor legyenek láthatóak a gombok:
            btnKgM.Visible = true;
            btnMKg.Visible = true;
            btnTKg.Visible = true;
            btnKgT.Visible = true;
            btnMT.Visible = true;
            btnTM.Visible = true;
        }

        private void btnVissza_Click(object sender, EventArgs e)
        { //Visszatérés a főablakra gomb:
            Close();
        }

        private void btnKgM_Click(object sender, EventArgs e)
        { //Kg-ból mázsába váltás gomb:
            double megoldas = Convert.ToDouble(nudBevisz.Value) / 100;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "mázsa";
        }

        private void btnMKg_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 100;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "kg.";
        }

        private void btnMT_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) / 10;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "tonna";
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 10;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "mázsa";
        }

        private void btnKgT_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) / 1000;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "tonna";
        }

        private void btnTKg_Click(object sender, EventArgs e)
        {
            double megoldas = Convert.ToDouble(nudBevisz.Value) * 1000;
            tbEredmeny.Text = megoldas.ToString();
            lEredmeny.Visible = true;
            tbEredmeny.Visible = true;
            lMertekegyseg.Visible = true;
            lMertekegyseg.Text = "kg.";
        }
    }
}
