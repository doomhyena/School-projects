namespace Projekt10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msCsik = new MenuStrip();
            fájlToolStripMenuItem = new ToolStripMenuItem();
            tiBetolt = new ToolStripMenuItem();
            tiKilep = new ToolStripMenuItem();
            rendezésToolStripMenuItem = new ToolStripMenuItem();
            tiNev = new ToolStripMenuItem();
            tiPont = new ToolStripMenuItem();
            rtbMezo = new RichTextBox();
            msCsik.SuspendLayout();
            SuspendLayout();
            // 
            // msCsik
            // 
            msCsik.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem, rendezésToolStripMenuItem });
            msCsik.Location = new Point(0, 0);
            msCsik.Name = "msCsik";
            msCsik.Size = new Size(336, 24);
            msCsik.TabIndex = 0;
            msCsik.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tiBetolt, tiKilep });
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(37, 20);
            fájlToolStripMenuItem.Text = "Fájl";
            // 
            // tiBetolt
            // 
            tiBetolt.Name = "tiBetolt";
            tiBetolt.Size = new Size(105, 22);
            tiBetolt.Text = "Betölt";
            tiBetolt.Click += tiBetolt_Click;
            // 
            // tiKilep
            // 
            tiKilep.Name = "tiKilep";
            tiKilep.Size = new Size(105, 22);
            tiKilep.Text = "Kilép";
            tiKilep.Click += tiKilep_Click;
            // 
            // rendezésToolStripMenuItem
            // 
            rendezésToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tiNev, tiPont });
            rendezésToolStripMenuItem.Name = "rendezésToolStripMenuItem";
            rendezésToolStripMenuItem.Size = new Size(68, 20);
            rendezésToolStripMenuItem.Text = "Rendezés";
            // 
            // tiNev
            // 
            tiNev.Name = "tiNev";
            tiNev.Size = new Size(180, 22);
            tiNev.Text = "Név alapján";
            tiNev.Click += tiNev_Click;
            // 
            // tiPont
            // 
            tiPont.Name = "tiPont";
            tiPont.Size = new Size(180, 22);
            tiPont.Text = "Pontszám alapján";
            tiPont.Click += tiPont_Click;
            // 
            // rtbMezo
            // 
            rtbMezo.Location = new Point(10, 42);
            rtbMezo.Name = "rtbMezo";
            rtbMezo.Size = new Size(312, 249);
            rtbMezo.TabIndex = 1;
            rtbMezo.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 305);
            Controls.Add(rtbMezo);
            Controls.Add(msCsik);
            MainMenuStrip = msCsik;
            Name = "Form1";
            Text = "Magaspontszám";
            Load += Form1_Load;
            msCsik.ResumeLayout(false);
            msCsik.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msCsik;
        private RichTextBox rtbMezo;
        private ToolStripMenuItem fájlToolStripMenuItem;
        private ToolStripMenuItem tiBetolt;
        private ToolStripMenuItem tiKilep;
        private ToolStripMenuItem rendezésToolStripMenuItem;
        private ToolStripMenuItem tiNev;
        private ToolStripMenuItem tiPont;
    }
}
