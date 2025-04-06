namespace Projekt3
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
            cbKeretMutat = new CheckBox();
            pbKeret = new ProgressBar();
            btnNullazas = new Button();
            lKeret = new Label();
            lRizs = new Label();
            label3 = new Label();
            label4 = new Label();
            lHal = new Label();
            label6 = new Label();
            lHus = new Label();
            btnBrutto = new Button();
            btnNetto = new Button();
            btnLearaz = new Button();
            btnKedv = new Button();
            btnKilep = new Button();
            label8 = new Label();
            lKedv = new Label();
            label10 = new Label();
            label11 = new Label();
            lAfa = new Label();
            tbRizs = new TextBox();
            tbHal = new TextBox();
            tbHus = new TextBox();
            tbOsszesen = new TextBox();
            tbKedv = new TextBox();
            btnReset = new Button();
            SuspendLayout();
            // 
            // cbKeretMutat
            // 
            cbKeretMutat.AutoSize = true;
            cbKeretMutat.Location = new Point(9, 16);
            cbKeretMutat.Name = "cbKeretMutat";
            cbKeretMutat.Size = new Size(118, 19);
            cbKeretMutat.TabIndex = 0;
            cbKeretMutat.Text = "Büdzsé mutatása:";
            cbKeretMutat.UseVisualStyleBackColor = true;
            cbKeretMutat.CheckedChanged += cbKeretMutat_CheckedChanged;
            // 
            // pbKeret
            // 
            pbKeret.Location = new Point(133, 12);
            pbKeret.Maximum = 3000;
            pbKeret.Name = "pbKeret";
            pbKeret.Size = new Size(248, 23);
            pbKeret.TabIndex = 1;
            pbKeret.Visible = false;
            // 
            // btnNullazas
            // 
            btnNullazas.Location = new Point(133, 41);
            btnNullazas.Name = "btnNullazas";
            btnNullazas.Size = new Size(105, 23);
            btnNullazas.TabIndex = 2;
            btnNullazas.Text = "Keret nullázása";
            btnNullazas.UseVisualStyleBackColor = true;
            btnNullazas.Visible = false;
            btnNullazas.Click += btnNullazas_Click;
            // 
            // lKeret
            // 
            lKeret.AutoSize = true;
            lKeret.Location = new Point(339, 45);
            lKeret.Name = "lKeret";
            lKeret.Size = new Size(42, 15);
            lKeret.TabIndex = 3;
            lKeret.Text = "0/3000";
            lKeret.Visible = false;
            // 
            // lRizs
            // 
            lRizs.AutoSize = true;
            lRizs.Location = new Point(15, 88);
            lRizs.Name = "lRizs";
            lRizs.Size = new Size(72, 15);
            lRizs.TabIndex = 4;
            lRizs.Text = "Rizs (400 Ft):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 88);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 5;
            label3.Text = "Db.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 129);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 8;
            label4.Text = "Db.";
            // 
            // lHal
            // 
            lHal.AutoSize = true;
            lHal.Location = new Point(17, 129);
            lHal.Name = "lHal";
            lHal.Size = new Size(70, 15);
            lHal.TabIndex = 7;
            lHal.Text = "Hal (800 Ft):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 174);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 11;
            label6.Text = "Db.";
            // 
            // lHus
            // 
            lHus.AutoSize = true;
            lHus.Location = new Point(8, 174);
            lHus.Name = "lHus";
            lHus.Size = new Size(79, 15);
            lHus.TabIndex = 10;
            lHus.Text = "Hús (1000 Ft):";
            // 
            // btnBrutto
            // 
            btnBrutto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnBrutto.Location = new Point(19, 221);
            btnBrutto.Name = "btnBrutto";
            btnBrutto.Size = new Size(142, 23);
            btnBrutto.TabIndex = 13;
            btnBrutto.Text = "Bruttó összesen";
            btnBrutto.UseVisualStyleBackColor = true;
            btnBrutto.Click += btnBrutto_Click;
            // 
            // btnNetto
            // 
            btnNetto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnNetto.Location = new Point(213, 221);
            btnNetto.Name = "btnNetto";
            btnNetto.Size = new Size(142, 23);
            btnNetto.TabIndex = 14;
            btnNetto.Text = "Nettó fizetendő";
            btnNetto.UseVisualStyleBackColor = true;
            btnNetto.Click += btnNetto_Click;
            // 
            // btnLearaz
            // 
            btnLearaz.Location = new Point(19, 278);
            btnLearaz.Name = "btnLearaz";
            btnLearaz.Size = new Size(142, 23);
            btnLearaz.TabIndex = 15;
            btnLearaz.Text = "Leárazás (10%)";
            btnLearaz.UseVisualStyleBackColor = true;
            btnLearaz.Click += btnLearaz_Click;
            // 
            // btnKedv
            // 
            btnKedv.Location = new Point(213, 278);
            btnKedv.Name = "btnKedv";
            btnKedv.Size = new Size(142, 23);
            btnKedv.TabIndex = 16;
            btnKedv.Text = "Adókedvezmény";
            btnKedv.UseVisualStyleBackColor = true;
            btnKedv.Click += btnKedv_Click;
            // 
            // btnKilep
            // 
            btnKilep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnKilep.ForeColor = Color.IndianRed;
            btnKilep.Location = new Point(114, 328);
            btnKilep.Name = "btnKilep";
            btnKilep.Size = new Size(142, 23);
            btnKilep.TabIndex = 17;
            btnKilep.Text = "Kilépés";
            btnKilep.UseVisualStyleBackColor = true;
            btnKilep.Click += btnKilep_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(361, 132);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 22;
            label8.Text = "%";
            // 
            // lKedv
            // 
            lKedv.AutoSize = true;
            lKedv.Location = new Point(208, 132);
            lKedv.Name = "lKedv";
            lKedv.Size = new Size(77, 15);
            lKedv.TabIndex = 21;
            lKedv.Text = "Kedvezmény:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(361, 91);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 19;
            label10.Text = "Ft.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(227, 91);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 18;
            label11.Text = "Összesen:";
            // 
            // lAfa
            // 
            lAfa.AutoSize = true;
            lAfa.Location = new Point(317, 173);
            lAfa.Name = "lAfa";
            lAfa.Size = new Size(53, 15);
            lAfa.TabIndex = 24;
            lAfa.Text = "Áfa: 27%";
            // 
            // tbRizs
            // 
            tbRizs.Location = new Point(91, 85);
            tbRizs.Name = "tbRizs";
            tbRizs.Size = new Size(64, 23);
            tbRizs.TabIndex = 25;
            // 
            // tbHal
            // 
            tbHal.Location = new Point(91, 126);
            tbHal.Name = "tbHal";
            tbHal.Size = new Size(64, 23);
            tbHal.TabIndex = 26;
            // 
            // tbHus
            // 
            tbHus.Location = new Point(91, 170);
            tbHus.Name = "tbHus";
            tbHus.Size = new Size(64, 23);
            tbHus.TabIndex = 27;
            // 
            // tbOsszesen
            // 
            tbOsszesen.Enabled = false;
            tbOsszesen.Location = new Point(291, 88);
            tbOsszesen.Name = "tbOsszesen";
            tbOsszesen.Size = new Size(64, 23);
            tbOsszesen.TabIndex = 28;
            // 
            // tbKedv
            // 
            tbKedv.Location = new Point(291, 129);
            tbKedv.Name = "tbKedv";
            tbKedv.Size = new Size(64, 23);
            tbKedv.TabIndex = 29;
            tbKedv.Text = "0";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnReset.Location = new Point(9, 41);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(97, 23);
            btnReset.TabIndex = 30;
            btnReset.Text = "Visszaállítás";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 368);
            Controls.Add(btnReset);
            Controls.Add(tbKedv);
            Controls.Add(tbOsszesen);
            Controls.Add(tbHus);
            Controls.Add(tbHal);
            Controls.Add(tbRizs);
            Controls.Add(lAfa);
            Controls.Add(label8);
            Controls.Add(lKedv);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(btnKilep);
            Controls.Add(btnKedv);
            Controls.Add(btnLearaz);
            Controls.Add(btnNetto);
            Controls.Add(btnBrutto);
            Controls.Add(label6);
            Controls.Add(lHus);
            Controls.Add(label4);
            Controls.Add(lHal);
            Controls.Add(label3);
            Controls.Add(lRizs);
            Controls.Add(lKeret);
            Controls.Add(btnNullazas);
            Controls.Add(pbKeret);
            Controls.Add(cbKeretMutat);
            Name = "Form1";
            Text = "Ebéd költség számláló";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbKeretMutat;
        private ProgressBar pbKeret;
        private Button btnNullazas;
        private Label lKeret;
        private Label lRizs;
        private Label label3;
        private Label label4;
        private Label lHal;
        private Label label6;
        private Label lHus;
        private Button btnBrutto;
        private Button btnNetto;
        private Button btnLearaz;
        private Button btnKedv;
        private Button btnKilep;
        private Label label8;
        private Label lKedv;
        private Label label10;
        private Label label11;
        private Label lAfa;
        private TextBox tbRizs;
        private TextBox tbHal;
        private TextBox tbHus;
        private TextBox tbOsszesen;
        private TextBox tbKedv;
        private Button btnReset;
    }
}
