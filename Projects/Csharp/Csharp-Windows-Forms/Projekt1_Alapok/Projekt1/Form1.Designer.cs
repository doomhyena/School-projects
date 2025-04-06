namespace Projekt1
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
            btnAtir = new Button();
            lAtirando = new Label();
            lSzovegdobozKoveto = new Label();
            tb1 = new TextBox();
            cbBekapcsolo = new CheckBox();
            lPipa = new Label();
            cbMegjelenit = new CheckBox();
            lPipa2 = new Label();
            btnPipaMegj = new Button();
            btnVisszacsinal = new Button();
            cbGomb2Megj = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fájlToolStripMenuItem = new ToolStripMenuItem();
            újToolStripMenuItem = new ToolStripMenuItem();
            mentésToolStripMenuItem = new ToolStripMenuItem();
            simaMentésToolStripMenuItem = new ToolStripMenuItem();
            mentésMáskéntToolStripMenuItem = new ToolStripMenuItem();
            megnyitToolStripMenuItem = new ToolStripMenuItem();
            szerkesztésToolStripMenuItem = new ToolStripMenuItem();
            visszavonToolStripMenuItem = new ToolStripMenuItem();
            újraToolStripMenuItem = new ToolStripMenuItem();
            stbToolStripMenuItem = new ToolStripMenuItem();
            btnKilep = new Button();
            rbMegjelenit = new RadioButton();
            nudToltes = new NumericUpDown();
            pbCsik = new ProgressBar();
            kilépésToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudToltes).BeginInit();
            SuspendLayout();
            // 
            // btnAtir
            // 
            btnAtir.Location = new Point(24, 70);
            btnAtir.Name = "btnAtir";
            btnAtir.Size = new Size(113, 45);
            btnAtir.TabIndex = 0;
            btnAtir.Text = "Átír";
            btnAtir.UseVisualStyleBackColor = true;
            btnAtir.Click += btnAtir_Click;
            // 
            // lAtirando
            // 
            lAtirando.AutoSize = true;
            lAtirando.Location = new Point(159, 85);
            lAtirando.Name = "lAtirando";
            lAtirando.Size = new Size(82, 15);
            lAtirando.TabIndex = 1;
            lAtirando.Text = "Eredeti szöveg";
            // 
            // lSzovegdobozKoveto
            // 
            lSzovegdobozKoveto.AutoSize = true;
            lSzovegdobozKoveto.Location = new Point(159, 167);
            lSzovegdobozKoveto.Name = "lSzovegdobozKoveto";
            lSzovegdobozKoveto.Size = new Size(16, 15);
            lSzovegdobozKoveto.TabIndex = 2;
            lSzovegdobozKoveto.Text = "...";
            // 
            // tb1
            // 
            tb1.Location = new Point(24, 164);
            tb1.Name = "tb1";
            tb1.Size = new Size(113, 23);
            tb1.TabIndex = 3;
            tb1.TextChanged += tb1_TextChanged;
            // 
            // cbBekapcsolo
            // 
            cbBekapcsolo.AutoSize = true;
            cbBekapcsolo.Location = new Point(24, 241);
            cbBekapcsolo.Name = "cbBekapcsolo";
            cbBekapcsolo.Size = new Size(74, 19);
            cbBekapcsolo.TabIndex = 4;
            cbBekapcsolo.Text = "Pipálj be!";
            cbBekapcsolo.UseVisualStyleBackColor = true;
            cbBekapcsolo.CheckedChanged += cbBekapcsolo_CheckedChanged;
            // 
            // lPipa
            // 
            lPipa.AutoSize = true;
            lPipa.Location = new Point(159, 242);
            lPipa.Name = "lPipa";
            lPipa.Size = new Size(69, 15);
            lPipa.TabIndex = 5;
            lPipa.Text = "Kikapcsolva";
            // 
            // cbMegjelenit
            // 
            cbMegjelenit.AutoSize = true;
            cbMegjelenit.Location = new Point(24, 308);
            cbMegjelenit.Name = "cbMegjelenit";
            cbMegjelenit.Size = new Size(82, 19);
            cbMegjelenit.TabIndex = 6;
            cbMegjelenit.Text = "Megjelenít";
            cbMegjelenit.UseVisualStyleBackColor = true;
            cbMegjelenit.CheckedChanged += cbMegjelenit_CheckedChanged;
            // 
            // lPipa2
            // 
            lPipa2.AutoSize = true;
            lPipa2.Location = new Point(159, 312);
            lPipa2.Name = "lPipa2";
            lPipa2.Size = new Size(44, 15);
            lPipa2.TabIndex = 7;
            lPipa2.Text = "Szöveg";
            lPipa2.Visible = false;
            // 
            // btnPipaMegj
            // 
            btnPipaMegj.Location = new Point(23, 379);
            btnPipaMegj.Name = "btnPipaMegj";
            btnPipaMegj.Size = new Size(128, 23);
            btnPipaMegj.TabIndex = 8;
            btnPipaMegj.Text = "Pipa megjelenítése";
            btnPipaMegj.UseVisualStyleBackColor = true;
            btnPipaMegj.Click += btnPipaMegj_Click;
            // 
            // btnVisszacsinal
            // 
            btnVisszacsinal.Location = new Point(373, 379);
            btnVisszacsinal.Name = "btnVisszacsinal";
            btnVisszacsinal.Size = new Size(90, 23);
            btnVisszacsinal.TabIndex = 9;
            btnVisszacsinal.Text = "Visszacsinál";
            btnVisszacsinal.UseVisualStyleBackColor = true;
            btnVisszacsinal.Visible = false;
            btnVisszacsinal.Click += btnVisszacsinal_Click;
            // 
            // cbGomb2Megj
            // 
            cbGomb2Megj.AutoSize = true;
            cbGomb2Megj.Location = new Point(180, 381);
            cbGomb2Megj.Name = "cbGomb2Megj";
            cbGomb2Megj.Size = new Size(168, 19);
            cbGomb2Megj.TabIndex = 10;
            cbGomb2Megj.Text = "Másik gomb megjelenítése";
            cbGomb2Megj.UseVisualStyleBackColor = true;
            cbGomb2Megj.Visible = false;
            cbGomb2Megj.CheckedChanged += cbGomb2Megj_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(543, 376);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(543, 349);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 12;
            label1.Text = "Dátumválasztó elem:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fájlToolStripMenuItem, szerkesztésToolStripMenuItem, stbToolStripMenuItem, kilépésToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(770, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            fájlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { újToolStripMenuItem, mentésToolStripMenuItem, megnyitToolStripMenuItem });
            fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            fájlToolStripMenuItem.Size = new Size(37, 20);
            fájlToolStripMenuItem.Text = "Fájl";
            // 
            // újToolStripMenuItem
            // 
            újToolStripMenuItem.Name = "újToolStripMenuItem";
            újToolStripMenuItem.Size = new Size(118, 22);
            újToolStripMenuItem.Text = "Új";
            // 
            // mentésToolStripMenuItem
            // 
            mentésToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { simaMentésToolStripMenuItem, mentésMáskéntToolStripMenuItem });
            mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            mentésToolStripMenuItem.Size = new Size(118, 22);
            mentésToolStripMenuItem.Text = "Mentés";
            // 
            // simaMentésToolStripMenuItem
            // 
            simaMentésToolStripMenuItem.Name = "simaMentésToolStripMenuItem";
            simaMentésToolStripMenuItem.Size = new Size(161, 22);
            simaMentésToolStripMenuItem.Text = "Sima mentés";
            // 
            // mentésMáskéntToolStripMenuItem
            // 
            mentésMáskéntToolStripMenuItem.Name = "mentésMáskéntToolStripMenuItem";
            mentésMáskéntToolStripMenuItem.Size = new Size(161, 22);
            mentésMáskéntToolStripMenuItem.Text = "Mentés másként";
            // 
            // megnyitToolStripMenuItem
            // 
            megnyitToolStripMenuItem.Name = "megnyitToolStripMenuItem";
            megnyitToolStripMenuItem.Size = new Size(118, 22);
            megnyitToolStripMenuItem.Text = "Megnyit";
            // 
            // szerkesztésToolStripMenuItem
            // 
            szerkesztésToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visszavonToolStripMenuItem, újraToolStripMenuItem });
            szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            szerkesztésToolStripMenuItem.Size = new Size(77, 20);
            szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            // 
            // visszavonToolStripMenuItem
            // 
            visszavonToolStripMenuItem.Name = "visszavonToolStripMenuItem";
            visszavonToolStripMenuItem.Size = new Size(125, 22);
            visszavonToolStripMenuItem.Text = "Visszavon";
            // 
            // újraToolStripMenuItem
            // 
            újraToolStripMenuItem.Name = "újraToolStripMenuItem";
            újraToolStripMenuItem.Size = new Size(125, 22);
            újraToolStripMenuItem.Text = "Újra";
            // 
            // stbToolStripMenuItem
            // 
            stbToolStripMenuItem.Name = "stbToolStripMenuItem";
            stbToolStripMenuItem.Size = new Size(45, 20);
            stbToolStripMenuItem.Text = "Stb...";
            // 
            // btnKilep
            // 
            btnKilep.Location = new Point(655, 438);
            btnKilep.Name = "btnKilep";
            btnKilep.Size = new Size(75, 23);
            btnKilep.TabIndex = 14;
            btnKilep.Text = "Kilépés";
            btnKilep.UseVisualStyleBackColor = true;
            btnKilep.Click += btnKilep_Click;
            // 
            // rbMegjelenit
            // 
            rbMegjelenit.AutoSize = true;
            rbMegjelenit.Location = new Point(432, 70);
            rbMegjelenit.Name = "rbMegjelenit";
            rbMegjelenit.Size = new Size(91, 19);
            rbMegjelenit.TabIndex = 15;
            rbMegjelenit.TabStop = true;
            rbMegjelenit.Text = "Számláló be:";
            rbMegjelenit.UseVisualStyleBackColor = true;
            rbMegjelenit.CheckedChanged += rbMegjelenit_CheckedChanged;
            // 
            // nudToltes
            // 
            nudToltes.Location = new Point(432, 106);
            nudToltes.Name = "nudToltes";
            nudToltes.Size = new Size(120, 23);
            nudToltes.TabIndex = 16;
            nudToltes.Visible = false;
            nudToltes.ValueChanged += nudToltes_ValueChanged;
            // 
            // pbCsik
            // 
            pbCsik.Location = new Point(432, 159);
            pbCsik.Name = "pbCsik";
            pbCsik.Size = new Size(282, 23);
            pbCsik.TabIndex = 17;
            pbCsik.Visible = false;
            // 
            // kilépésToolStripMenuItem
            // 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            kilépésToolStripMenuItem.Size = new Size(56, 20);
            kilépésToolStripMenuItem.Text = "Kilépés";
            kilépésToolStripMenuItem.Click += kilépésToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(770, 473);
            Controls.Add(pbCsik);
            Controls.Add(nudToltes);
            Controls.Add(rbMegjelenit);
            Controls.Add(btnKilep);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(cbGomb2Megj);
            Controls.Add(btnVisszacsinal);
            Controls.Add(btnPipaMegj);
            Controls.Add(lPipa2);
            Controls.Add(cbMegjelenit);
            Controls.Add(lPipa);
            Controls.Add(cbBekapcsolo);
            Controls.Add(tb1);
            Controls.Add(lSzovegdobozKoveto);
            Controls.Add(lAtirando);
            Controls.Add(btnAtir);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Alapok";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudToltes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtir;
        private Label lAtirando;
        private Label lSzovegdobozKoveto;
        private TextBox tb1;
        private CheckBox cbBekapcsolo;
        private Label lPipa;
        private CheckBox cbMegjelenit;
        private Label lPipa2;
        private Button btnPipaMegj;
        private Button btnVisszacsinal;
        private CheckBox cbGomb2Megj;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fájlToolStripMenuItem;
        private ToolStripMenuItem újToolStripMenuItem;
        private ToolStripMenuItem mentésToolStripMenuItem;
        private ToolStripMenuItem simaMentésToolStripMenuItem;
        private ToolStripMenuItem mentésMáskéntToolStripMenuItem;
        private ToolStripMenuItem megnyitToolStripMenuItem;
        private ToolStripMenuItem szerkesztésToolStripMenuItem;
        private ToolStripMenuItem visszavonToolStripMenuItem;
        private ToolStripMenuItem újraToolStripMenuItem;
        private ToolStripMenuItem stbToolStripMenuItem;
        private Button btnKilep;
        private RadioButton rbMegjelenit;
        private NumericUpDown nudToltes;
        private ProgressBar pbCsik;
        private ToolStripMenuItem kilépésToolStripMenuItem;
    }
}
