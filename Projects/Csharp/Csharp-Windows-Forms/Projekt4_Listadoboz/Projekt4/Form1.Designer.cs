namespace Projekt4
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
            lbListadoboz = new ListBox();
            btnBezar = new Button();
            label1 = new Label();
            rbEnged = new RadioButton();
            tbSzoveg = new TextBox();
            btnHozzaad = new Button();
            btnLevesz = new Button();
            btnKiurit = new Button();
            btnSzoveg = new Button();
            label2 = new Label();
            lSzerkAllapot = new Label();
            label4 = new Label();
            lElemszam = new Label();
            btnBovit = new Button();
            btnVisszavesz = new Button();
            SuspendLayout();
            // 
            // lbListadoboz
            // 
            lbListadoboz.FormattingEnabled = true;
            lbListadoboz.ItemHeight = 15;
            lbListadoboz.Location = new Point(21, 62);
            lbListadoboz.Name = "lbListadoboz";
            lbListadoboz.Size = new Size(120, 184);
            lbListadoboz.TabIndex = 0;
            lbListadoboz.Visible = false;
           
            // btnBezar
            // 
            btnBezar.Enabled = false;
            btnBezar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnBezar.Location = new Point(243, 19);
            btnBezar.Name = "btnBezar";
            btnBezar.Size = new Size(31, 23);
            btnBezar.TabIndex = 1;
            btnBezar.Text = "X";
            btnBezar.UseVisualStyleBackColor = true;
            btnBezar.Click += btnBezar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 238);
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 2;
            label1.Text = "Listadobozok kezelése";
            // 
            // rbEnged
            // 
            rbEnged.AutoSize = true;
            rbEnged.Location = new Point(21, 37);
            rbEnged.Name = "rbEnged";
            rbEnged.Size = new Size(162, 19);
            rbEnged.TabIndex = 3;
            rbEnged.Text = "Szerkesztés engedélyezése";
            rbEnged.UseVisualStyleBackColor = true;
            rbEnged.CheckedChanged += rbEnged_CheckedChanged;
            // 
            // tbSzoveg
            // 
            tbSzoveg.Enabled = false;
            tbSzoveg.Location = new Point(155, 149);
            tbSzoveg.Name = "tbSzoveg";
            tbSzoveg.Size = new Size(119, 23);
            tbSzoveg.TabIndex = 4;
            // 
            // btnHozzaad
            // 
            btnHozzaad.Enabled = false;
            btnHozzaad.Location = new Point(155, 62);
            btnHozzaad.Name = "btnHozzaad";
            btnHozzaad.Size = new Size(119, 23);
            btnHozzaad.TabIndex = 5;
            btnHozzaad.Text = "Hozzáad: \"aaa\"";
            btnHozzaad.UseVisualStyleBackColor = true;
            btnHozzaad.Click += btnHozzaad_Click;
            // 
            // btnLevesz
            // 
            btnLevesz.Enabled = false;
            btnLevesz.Location = new Point(155, 91);
            btnLevesz.Name = "btnLevesz";
            btnLevesz.Size = new Size(119, 23);
            btnLevesz.TabIndex = 6;
            btnLevesz.Text = "Levesz";
            btnLevesz.UseVisualStyleBackColor = true;
            btnLevesz.Click += btnLevesz_Click;
            // 
            // btnKiurit
            // 
            btnKiurit.Enabled = false;
            btnKiurit.Location = new Point(155, 120);
            btnKiurit.Name = "btnKiurit";
            btnKiurit.Size = new Size(119, 23);
            btnKiurit.TabIndex = 7;
            btnKiurit.Text = "Kiürít";
            btnKiurit.UseVisualStyleBackColor = true;
            btnKiurit.Click += btnKiurit_Click;
            // 
            // btnSzoveg
            // 
            btnSzoveg.Enabled = false;
            btnSzoveg.Location = new Point(155, 178);
            btnSzoveg.Name = "btnSzoveg";
            btnSzoveg.Size = new Size(119, 23);
            btnSzoveg.TabIndex = 8;
            btnSzoveg.Text = "Bevisz";
            btnSzoveg.UseVisualStyleBackColor = true;
            btnSzoveg.Click += btnSzoveg_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 204);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 9;
            label2.Text = "Állapot:";
            // 
            // lSzerkAllapot
            // 
            lSzerkAllapot.AutoSize = true;
            lSzerkAllapot.Location = new Point(209, 204);
            lSzerkAllapot.Name = "lSzerkAllapot";
            lSzerkAllapot.Size = new Size(65, 15);
            lSzerkAllapot.TabIndex = 10;
            lSzerkAllapot.Text = "Nem szerk.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 234);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 11;
            label4.Text = "Elemek száma:";
            // 
            // lElemszam
            // 
            lElemszam.AutoSize = true;
            lElemszam.Location = new Point(245, 234);
            lElemszam.Name = "lElemszam";
            lElemszam.Size = new Size(13, 15);
            lElemszam.TabIndex = 12;
            lElemszam.Text = "0";
            // 
            // btnBovit
            // 
            btnBovit.Enabled = false;
            btnBovit.Location = new Point(21, 257);
            btnBovit.Name = "btnBovit";
            btnBovit.Size = new Size(120, 23);
            btnBovit.TabIndex = 13;
            btnBovit.Text = "Bővítés 10-re";
            btnBovit.UseVisualStyleBackColor = true;
            btnBovit.Click += btnBovit_Click;
            // 
            // btnVisszavesz
            // 
            btnVisszavesz.Enabled = false;
            btnVisszavesz.Location = new Point(154, 257);
            btnVisszavesz.Name = "btnVisszavesz";
            btnVisszavesz.Size = new Size(120, 23);
            btnVisszavesz.TabIndex = 14;
            btnVisszavesz.Text = "Visszavesz 5-re";
            btnVisszavesz.UseVisualStyleBackColor = true;
            btnVisszavesz.Click += btnVisszavesz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 292);
            Controls.Add(btnVisszavesz);
            Controls.Add(btnBovit);
            Controls.Add(lElemszam);
            Controls.Add(label4);
            Controls.Add(lSzerkAllapot);
            Controls.Add(label2);
            Controls.Add(btnSzoveg);
            Controls.Add(btnKiurit);
            Controls.Add(btnLevesz);
            Controls.Add(btnHozzaad);
            Controls.Add(tbSzoveg);
            Controls.Add(rbEnged);
            Controls.Add(label1);
            Controls.Add(btnBezar);
            Controls.Add(lbListadoboz);
            Name = "Form1";
            Text = "Listadoboz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbListadoboz;
        private Button btnBezar;
        private Label label1;
        private RadioButton rbEnged;
        private TextBox tbSzoveg;
        private Button btnHozzaad;
        private Button btnLevesz;
        private Button btnKiurit;
        private Button btnSzoveg;
        private Label label2;
        private Label lSzerkAllapot;
        private Label label4;
        private Label lElemszam;
        private Button btnBovit;
        private Button btnVisszavesz;
    }
}
