namespace Projekt6
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
            label1 = new Label();
            btnNullaz = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbNev = new TextBox();
            tbId = new TextBox();
            cbBeosztas = new ComboBox();
            lOraSugo = new Label();
            lPercSugo = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbHO = new TextBox();
            tbHP = new TextBox();
            tbKP = new TextBox();
            tbKO = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tbSzP = new TextBox();
            tbSzO = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            tbCsP = new TextBox();
            tbCsO = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            tbPP = new TextBox();
            tbPO = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            btnFizetesSzamol = new Button();
            tbBrutto = new TextBox();
            tbNetto = new TextBox();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            btnBezar = new Button();
            lNettoSugo = new Label();
            lBeosztasSeged = new Label();
            cbAdoKedv = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(20, 11);
            label1.Name = "label1";
            label1.Size = new Size(338, 25);
            label1.TabIndex = 0;
            label1.Text = "Heti fizetés számolása órabér alapján";
            // 
            // btnNullaz
            // 
            btnNullaz.Location = new Point(21, 41);
            btnNullaz.Name = "btnNullaz";
            btnNullaz.Size = new Size(75, 23);
            btnNullaz.TabIndex = 1;
            btnNullaz.Text = "Nullázás";
            btnNullaz.UseVisualStyleBackColor = true;
            btnNullaz.Click += btnNullaz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 72);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 2;
            label2.Text = "Alkalmazott neve:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 98);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 3;
            label3.Text = "Alkalmazott azonosítója:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 127);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 4;
            label4.Text = "Alkalmazott beosztása:";
            // 
            // tbNev
            // 
            tbNev.Location = new Point(174, 69);
            tbNev.Name = "tbNev";
            tbNev.Size = new Size(121, 23);
            tbNev.TabIndex = 5;
            // 
            // tbId
            // 
            tbId.Location = new Point(174, 95);
            tbId.Name = "tbId";
            tbId.Size = new Size(121, 23);
            tbId.TabIndex = 6;
            // 
            // cbBeosztas
            // 
            cbBeosztas.FormattingEnabled = true;
            cbBeosztas.Items.AddRange(new object[] { "Főnök", "Titkár", "Admin" });
            cbBeosztas.Location = new Point(174, 124);
            cbBeosztas.Name = "cbBeosztas";
            cbBeosztas.Size = new Size(121, 23);
            cbBeosztas.TabIndex = 7;
            // 
            // lOraSugo
            // 
            lOraSugo.AutoSize = true;
            lOraSugo.Location = new Point(161, 157);
            lOraSugo.Name = "lOraSugo";
            lOraSugo.Size = new Size(12, 15);
            lOraSugo.TabIndex = 8;
            lOraSugo.Text = "?";
            lOraSugo.Click += lOraSugo_Click;
            // 
            // lPercSugo
            // 
            lPercSugo.AutoSize = true;
            lPercSugo.Location = new Point(279, 157);
            lPercSugo.Name = "lPercSugo";
            lPercSugo.Size = new Size(12, 15);
            lPercSugo.TabIndex = 9;
            lPercSugo.Text = "?";
            lPercSugo.Click += lPercSugo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(28, 190);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 10;
            label7.Text = "Hétfő:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(104, 190);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 11;
            label8.Text = "Órák:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(211, 190);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 12;
            label9.Text = "Percek:";
            // 
            // tbHO
            // 
            tbHO.Location = new Point(145, 187);
            tbHO.Name = "tbHO";
            tbHO.Size = new Size(46, 23);
            tbHO.TabIndex = 13;
            tbHO.Text = "0";
            tbHO.TextChanged += tbHO_TextChanged;
            // 
            // tbHP
            // 
            tbHP.Location = new Point(262, 187);
            tbHP.Name = "tbHP";
            tbHP.Size = new Size(46, 23);
            tbHP.TabIndex = 14;
            tbHP.Text = "0";
            tbHP.TextChanged += tbHP_TextChanged;
            // 
            // tbKP
            // 
            tbKP.Location = new Point(262, 230);
            tbKP.Name = "tbKP";
            tbKP.Size = new Size(46, 23);
            tbKP.TabIndex = 19;
            tbKP.Text = "0";
            tbKP.TextChanged += tbKP_TextChanged;
            // 
            // tbKO
            // 
            tbKO.Location = new Point(145, 230);
            tbKO.Name = "tbKO";
            tbKO.Size = new Size(46, 23);
            tbKO.TabIndex = 18;
            tbKO.Text = "0";
            tbKO.TextChanged += tbKO_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(211, 233);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 17;
            label10.Text = "Percek:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(104, 233);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 16;
            label11.Text = "Órák:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label12.Location = new Point(28, 233);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 15;
            label12.Text = "Kedd:";
            // 
            // tbSzP
            // 
            tbSzP.Location = new Point(262, 274);
            tbSzP.Name = "tbSzP";
            tbSzP.Size = new Size(46, 23);
            tbSzP.TabIndex = 24;
            tbSzP.Text = "0";
            tbSzP.TextChanged += tbSzP_TextChanged;
            // 
            // tbSzO
            // 
            tbSzO.Location = new Point(145, 274);
            tbSzO.Name = "tbSzO";
            tbSzO.Size = new Size(46, 23);
            tbSzO.TabIndex = 23;
            tbSzO.Text = "0";
            tbSzO.TextChanged += tbSzO_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(211, 277);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 22;
            label13.Text = "Percek:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(104, 277);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 21;
            label14.Text = "Órák:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label15.Location = new Point(23, 277);
            label15.Name = "label15";
            label15.Size = new Size(48, 15);
            label15.TabIndex = 20;
            label15.Text = "Szerda:";
            // 
            // tbCsP
            // 
            tbCsP.Location = new Point(262, 316);
            tbCsP.Name = "tbCsP";
            tbCsP.Size = new Size(46, 23);
            tbCsP.TabIndex = 29;
            tbCsP.Text = "0";
            tbCsP.TextChanged += tbCsP_TextChanged;
            // 
            // tbCsO
            // 
            tbCsO.Location = new Point(145, 316);
            tbCsO.Name = "tbCsO";
            tbCsO.Size = new Size(46, 23);
            tbCsO.TabIndex = 28;
            tbCsO.Text = "0";
            tbCsO.TextChanged += tbCsO_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(211, 319);
            label16.Name = "label16";
            label16.Size = new Size(45, 15);
            label16.TabIndex = 27;
            label16.Text = "Percek:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(104, 319);
            label17.Name = "label17";
            label17.Size = new Size(35, 15);
            label17.TabIndex = 26;
            label17.Text = "Órák:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label18.Location = new Point(6, 319);
            label18.Name = "label18";
            label18.Size = new Size(65, 15);
            label18.TabIndex = 25;
            label18.Text = "Csütörtök:";
            // 
            // tbPP
            // 
            tbPP.Location = new Point(262, 359);
            tbPP.Name = "tbPP";
            tbPP.Size = new Size(46, 23);
            tbPP.TabIndex = 34;
            tbPP.Text = "0";
            tbPP.TextChanged += tbPP_TextChanged;
            // 
            // tbPO
            // 
            tbPO.Location = new Point(145, 359);
            tbPO.Name = "tbPO";
            tbPO.Size = new Size(46, 23);
            tbPO.TabIndex = 33;
            tbPO.Text = "0";
            tbPO.TextChanged += tbPO_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(211, 362);
            label19.Name = "label19";
            label19.Size = new Size(45, 15);
            label19.TabIndex = 32;
            label19.Text = "Percek:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(104, 362);
            label20.Name = "label20";
            label20.Size = new Size(35, 15);
            label20.TabIndex = 31;
            label20.Text = "Órák:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label21.Location = new Point(21, 362);
            label21.Name = "label21";
            label21.Size = new Size(50, 15);
            label21.TabIndex = 30;
            label21.Text = "Péntek:";
            // 
            // btnFizetesSzamol
            // 
            btnFizetesSzamol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnFizetesSzamol.Location = new Point(45, 407);
            btnFizetesSzamol.Name = "btnFizetesSzamol";
            btnFizetesSzamol.Size = new Size(263, 23);
            btnFizetesSzamol.TabIndex = 35;
            btnFizetesSzamol.Text = "Fizetés számolása";
            btnFizetesSzamol.UseVisualStyleBackColor = true;
            btnFizetesSzamol.Click += btnFizetesSzamol_Click;
            // 
            // tbBrutto
            // 
            tbBrutto.Enabled = false;
            tbBrutto.Location = new Point(145, 469);
            tbBrutto.Name = "tbBrutto";
            tbBrutto.Size = new Size(92, 23);
            tbBrutto.TabIndex = 36;
            // 
            // tbNetto
            // 
            tbNetto.Enabled = false;
            tbNetto.Location = new Point(145, 498);
            tbNetto.Name = "tbNetto";
            tbNetto.Size = new Size(92, 23);
            tbNetto.TabIndex = 37;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(239, 472);
            label22.Name = "label22";
            label22.Size = new Size(17, 15);
            label22.TabIndex = 38;
            label22.Text = "Ft";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(239, 501);
            label23.Name = "label23";
            label23.Size = new Size(17, 15);
            label23.TabIndex = 39;
            label23.Text = "Ft";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(58, 472);
            label24.Name = "label24";
            label24.Size = new Size(81, 15);
            label24.TabIndex = 40;
            label24.Text = "Bruttó összeg:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(61, 501);
            label25.Name = "label25";
            label25.Size = new Size(78, 15);
            label25.TabIndex = 41;
            label25.Text = "Nettó összeg:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(145, 442);
            label26.Name = "label26";
            label26.Size = new Size(77, 15);
            label26.TabIndex = 42;
            label26.Text = "A heti fizetés:";
            // 
            // btnBezar
            // 
            btnBezar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnBezar.Location = new Point(301, 501);
            btnBezar.Name = "btnBezar";
            btnBezar.Size = new Size(37, 23);
            btnBezar.TabIndex = 43;
            btnBezar.Text = "X";
            btnBezar.UseVisualStyleBackColor = true;
            btnBezar.Click += btnBezar_Click;
            // 
            // lNettoSugo
            // 
            lNettoSugo.AutoSize = true;
            lNettoSugo.Location = new Point(40, 501);
            lNettoSugo.Name = "lNettoSugo";
            lNettoSugo.Size = new Size(12, 15);
            lNettoSugo.TabIndex = 44;
            lNettoSugo.Text = "?";
            lNettoSugo.Click += lNettoSugo_Click;
            // 
            // lBeosztasSeged
            // 
            lBeosztasSeged.AutoSize = true;
            lBeosztasSeged.Location = new Point(301, 127);
            lBeosztasSeged.Name = "lBeosztasSeged";
            lBeosztasSeged.Size = new Size(12, 15);
            lBeosztasSeged.TabIndex = 45;
            lBeosztasSeged.Text = "?";
            lBeosztasSeged.Click += lBeosztasSeged_Click;
            // 
            // cbAdoKedv
            // 
            cbAdoKedv.AutoSize = true;
            cbAdoKedv.Location = new Point(174, 44);
            cbAdoKedv.Name = "cbAdoKedv";
            cbAdoKedv.Size = new Size(114, 19);
            cbAdoKedv.TabIndex = 46;
            cbAdoKedv.Text = "Adókedvezmény";
            cbAdoKedv.UseVisualStyleBackColor = true;
            cbAdoKedv.CheckedChanged += cbAdoKedv_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 539);
            Controls.Add(cbAdoKedv);
            Controls.Add(lBeosztasSeged);
            Controls.Add(lNettoSugo);
            Controls.Add(btnBezar);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(tbNetto);
            Controls.Add(tbBrutto);
            Controls.Add(btnFizetesSzamol);
            Controls.Add(tbPP);
            Controls.Add(tbPO);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(tbCsP);
            Controls.Add(tbCsO);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(tbSzP);
            Controls.Add(tbSzO);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(tbKP);
            Controls.Add(tbKO);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(tbHP);
            Controls.Add(tbHO);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lPercSugo);
            Controls.Add(lOraSugo);
            Controls.Add(cbBeosztas);
            Controls.Add(tbId);
            Controls.Add(tbNev);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNullaz);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Fizetés számláló";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNullaz;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbNev;
        private TextBox tbId;
        private ComboBox cbBeosztas;
        private Label lOraSugo;
        private Label lPercSugo;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbHO;
        private TextBox tbHP;
        private TextBox tbKP;
        private TextBox tbKO;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tbSzP;
        private TextBox tbSzO;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox tbCsP;
        private TextBox tbCsO;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox tbPP;
        private TextBox tbPO;
        private Label label19;
        private Label label20;
        private Label label21;
        private Button btnFizetesSzamol;
        private TextBox tbBrutto;
        private TextBox tbNetto;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Button btnBezar;
        private Label lNettoSugo;
        private Label lBeosztasSeged;
        private CheckBox cbAdoKedv;
    }
}
