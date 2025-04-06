namespace Projekt8
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
            menuStrip1 = new MenuStrip();
            műveletekToolStripMenuItem = new ToolStripMenuItem();
            kiürítToolStripMenuItem = new ToolStripMenuItem();
            kilépToolStripMenuItem = new ToolStripMenuItem();
            rbKenu = new RadioButton();
            rbEvezos = new RadioButton();
            rbMotoros = new RadioButton();
            rbMiniyacht = new RadioButton();
            cbHorgaszbot = new CheckBox();
            cbMelleny = new CheckBox();
            cbSzonar = new CheckBox();
            cbHalo = new CheckBox();
            nudNap = new NumericUpDown();
            label1 = new Label();
            rtbMezo = new RichTextBox();
            gbCsonakok = new GroupBox();
            gbFelszereles = new GroupBox();
            lDatum = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNap).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { műveletekToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(481, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // műveletekToolStripMenuItem
            // 
            műveletekToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kiürítToolStripMenuItem, kilépToolStripMenuItem });
            műveletekToolStripMenuItem.Name = "műveletekToolStripMenuItem";
            műveletekToolStripMenuItem.Size = new Size(74, 20);
            műveletekToolStripMenuItem.Text = "Műveletek";
            // 
            // kiürítToolStripMenuItem
            // 
            kiürítToolStripMenuItem.Name = "kiürítToolStripMenuItem";
            kiürítToolStripMenuItem.Size = new Size(102, 22);
            kiürítToolStripMenuItem.Text = "Kiürít";
            kiürítToolStripMenuItem.Click += kiürítToolStripMenuItem_Click;
            // 
            // kilépToolStripMenuItem
            // 
            kilépToolStripMenuItem.Name = "kilépToolStripMenuItem";
            kilépToolStripMenuItem.Size = new Size(102, 22);
            kilépToolStripMenuItem.Text = "Kilép";
            kilépToolStripMenuItem.Click += kilépToolStripMenuItem_Click;
            // 
            // rbKenu
            // 
            rbKenu.AutoSize = true;
            rbKenu.Checked = true;
            rbKenu.Font = new Font("Segoe UI", 12F);
            rbKenu.Location = new Point(29, 45);
            rbKenu.Name = "rbKenu";
            rbKenu.Size = new Size(122, 25);
            rbKenu.TabIndex = 1;
            rbKenu.TabStop = true;
            rbKenu.Text = "Kenu - 29000";
            rbKenu.UseVisualStyleBackColor = true;
            rbKenu.CheckedChanged += rbKenu_CheckedChanged;
            // 
            // rbEvezos
            // 
            rbEvezos.AutoSize = true;
            rbEvezos.Font = new Font("Segoe UI", 12F);
            rbEvezos.Location = new Point(29, 70);
            rbEvezos.Name = "rbEvezos";
            rbEvezos.Size = new Size(134, 25);
            rbEvezos.TabIndex = 2;
            rbEvezos.Text = "Evezős - 24000";
            rbEvezos.UseVisualStyleBackColor = true;
            rbEvezos.CheckedChanged += rbEvezos_CheckedChanged;
            // 
            // rbMotoros
            // 
            rbMotoros.AutoSize = true;
            rbMotoros.Font = new Font("Segoe UI", 12F);
            rbMotoros.Location = new Point(29, 95);
            rbMotoros.Name = "rbMotoros";
            rbMotoros.Size = new Size(146, 25);
            rbMotoros.TabIndex = 3;
            rbMotoros.Text = "Motoros - 45000";
            rbMotoros.UseVisualStyleBackColor = true;
            rbMotoros.CheckedChanged += rbMotoros_CheckedChanged;
            // 
            // rbMiniyacht
            // 
            rbMiniyacht.AutoSize = true;
            rbMiniyacht.Font = new Font("Segoe UI", 12F);
            rbMiniyacht.Location = new Point(29, 120);
            rbMiniyacht.Name = "rbMiniyacht";
            rbMiniyacht.Size = new Size(155, 25);
            rbMiniyacht.TabIndex = 4;
            rbMiniyacht.Text = "Miniyacht - 85000";
            rbMiniyacht.UseVisualStyleBackColor = true;
            rbMiniyacht.CheckedChanged += rbMiniyacht_CheckedChanged;
            // 
            // cbHorgaszbot
            // 
            cbHorgaszbot.AutoSize = true;
            cbHorgaszbot.Font = new Font("Segoe UI", 12F);
            cbHorgaszbot.Location = new Point(210, 46);
            cbHorgaszbot.Name = "cbHorgaszbot";
            cbHorgaszbot.Size = new Size(158, 25);
            cbHorgaszbot.TabIndex = 5;
            cbHorgaszbot.Text = "Horgászbot 15000";
            cbHorgaszbot.UseVisualStyleBackColor = true;
            cbHorgaszbot.CheckedChanged += cbHorgaszbot_CheckedChanged;
            // 
            // cbMelleny
            // 
            cbMelleny.AutoSize = true;
            cbMelleny.Font = new Font("Segoe UI", 12F);
            cbMelleny.Location = new Point(210, 71);
            cbMelleny.Name = "cbMelleny";
            cbMelleny.Size = new Size(134, 25);
            cbMelleny.TabIndex = 6;
            cbMelleny.Text = "Mellény - 2000";
            cbMelleny.UseVisualStyleBackColor = true;
            cbMelleny.CheckedChanged += cbMelleny_CheckedChanged;
            // 
            // cbSzonar
            // 
            cbSzonar.AutoSize = true;
            cbSzonar.Font = new Font("Segoe UI", 12F);
            cbSzonar.Location = new Point(210, 96);
            cbSzonar.Name = "cbSzonar";
            cbSzonar.Size = new Size(136, 25);
            cbSzonar.TabIndex = 7;
            cbSzonar.Text = "Szonár - 12000";
            cbSzonar.UseVisualStyleBackColor = true;
            cbSzonar.CheckedChanged += cbSzonar_CheckedChanged;
            // 
            // cbHalo
            // 
            cbHalo.AutoSize = true;
            cbHalo.Font = new Font("Segoe UI", 12F);
            cbHalo.Location = new Point(210, 120);
            cbHalo.Name = "cbHalo";
            cbHalo.Size = new Size(111, 25);
            cbHalo.TabIndex = 8;
            cbHalo.Text = "Háló - 5000";
            cbHalo.UseVisualStyleBackColor = true;
            cbHalo.CheckedChanged += cbHalo_CheckedChanged;
            // 
            // nudNap
            // 
            nudNap.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            nudNap.Location = new Point(388, 120);
            nudNap.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNap.Name = "nudNap";
            nudNap.Size = new Size(69, 23);
            nudNap.TabIndex = 9;
            nudNap.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudNap.ValueChanged += nudNap_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(388, 95);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 10;
            label1.Text = "Napok:";
            // 
            // rtbMezo
            // 
            rtbMezo.Location = new Point(29, 162);
            rtbMezo.Name = "rtbMezo";
            rtbMezo.Size = new Size(428, 186);
            rtbMezo.TabIndex = 11;
            rtbMezo.Text = "";
            // 
            // gbCsonakok
            // 
            gbCsonakok.Location = new Point(20, 33);
            gbCsonakok.Name = "gbCsonakok";
            gbCsonakok.Size = new Size(173, 123);
            gbCsonakok.TabIndex = 12;
            gbCsonakok.TabStop = false;
            gbCsonakok.Text = "Csónakok";
            // 
            // gbFelszereles
            // 
            gbFelszereles.Location = new Point(199, 33);
            gbFelszereles.Name = "gbFelszereles";
            gbFelszereles.Size = new Size(183, 123);
            gbFelszereles.TabIndex = 13;
            gbFelszereles.TabStop = false;
            gbFelszereles.Text = "Felszerelés";
            // 
            // lDatum
            // 
            lDatum.AutoSize = true;
            lDatum.Location = new Point(388, 45);
            lDatum.Name = "lDatum";
            lDatum.Size = new Size(12, 15);
            lDatum.TabIndex = 14;
            lDatum.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 368);
            Controls.Add(lDatum);
            Controls.Add(rtbMezo);
            Controls.Add(label1);
            Controls.Add(nudNap);
            Controls.Add(cbHalo);
            Controls.Add(cbSzonar);
            Controls.Add(cbMelleny);
            Controls.Add(cbHorgaszbot);
            Controls.Add(rbMiniyacht);
            Controls.Add(rbMotoros);
            Controls.Add(rbEvezos);
            Controls.Add(rbKenu);
            Controls.Add(menuStrip1);
            Controls.Add(gbCsonakok);
            Controls.Add(gbFelszereles);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem műveletekToolStripMenuItem;
        private ToolStripMenuItem kiürítToolStripMenuItem;
        private ToolStripMenuItem kilépToolStripMenuItem;
        private RadioButton rbKenu;
        private RadioButton rbEvezos;
        private RadioButton rbMotoros;
        private RadioButton rbMiniyacht;
        private CheckBox cbHorgaszbot;
        private CheckBox cbMelleny;
        private CheckBox cbSzonar;
        private CheckBox cbHalo;
        private NumericUpDown nudNap;
        private Label label1;
        private RichTextBox rtbMezo;
        private GroupBox gbCsonakok;
        private GroupBox gbFelszereles;
        private Label lDatum;
    }
}
