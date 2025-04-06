namespace Projekt12_NépességStat
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
            msMenu = new MenuStrip();
            fájlToolStripMenuItem = new ToolStripMenuItem();
            miBetolt = new ToolStripMenuItem();
            miKilep = new ToolStripMenuItem();
            reportolásToolStripMenuItem = new ToolStripMenuItem();
            miNepsuruseg = new ToolStripMenuItem();
            miGyerekek = new ToolStripMenuItem();
            rtbMezo = new RichTextBox();
            msMenu.SuspendLayout();
            SuspendLayout();
            // 
            // msMenu
            // 
            msMenu.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem, reportolásToolStripMenuItem });
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.Size = new Size(434, 24);
            msMenu.TabIndex = 0;
            msMenu.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miBetolt, miKilep });
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(37, 20);
            fájlToolStripMenuItem.Text = "Fájl";
            // 
            // miBetolt
            // 
            miBetolt.Name = "miBetolt";
            miBetolt.Size = new Size(163, 22);
            miBetolt.Text = "Adatok betöltése";
            miBetolt.Click += miBetolt_Click;
            // 
            // miKilep
            // 
            miKilep.Name = "miKilep";
            miKilep.Size = new Size(163, 22);
            miKilep.Text = "Kilépés";
            miKilep.Click += miKilep_Click;
            // 
            // reportolásToolStripMenuItem
            // 
            reportolásToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miNepsuruseg, miGyerekek });
            reportolásToolStripMenuItem.Name = "reportolásToolStripMenuItem";
            reportolásToolStripMenuItem.Size = new Size(75, 20);
            reportolásToolStripMenuItem.Text = "Reportolás";
            // 
            // miNepsuruseg
            // 
            miNepsuruseg.Name = "miNepsuruseg";
            miNepsuruseg.Size = new Size(180, 22);
            miNepsuruseg.Text = "Népsűrűség";
            miNepsuruseg.Click += miNepsuruseg_Click;
            // 
            // miGyerekek
            // 
            miGyerekek.Name = "miGyerekek";
            miGyerekek.Size = new Size(180, 22);
            miGyerekek.Text = "Gyerekek";
            miGyerekek.Click += miGyerekek_Click;
            // 
            // rtbMezo
            // 
            rtbMezo.Location = new Point(12, 44);
            rtbMezo.Name = "rtbMezo";
            rtbMezo.Size = new Size(409, 454);
            rtbMezo.TabIndex = 1;
            rtbMezo.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 510);
            Controls.Add(rtbMezo);
            Controls.Add(msMenu);
            MainMenuStrip = msMenu;
            Name = "Form1";
            Text = "Népességi statisztika";
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMenu;
        private RichTextBox rtbMezo;
        private ToolStripMenuItem fájlToolStripMenuItem;
        private ToolStripMenuItem miBetolt;
        private ToolStripMenuItem miKilep;
        private ToolStripMenuItem reportolásToolStripMenuItem;
        private ToolStripMenuItem miNepsuruseg;
        private ToolStripMenuItem miGyerekek;
    }
}
