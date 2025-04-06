namespace Projekt5
{
    partial class Felszin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lEredmeny = new Label();
            btnInchCm = new Button();
            btnCmInch = new Button();
            btnMYard = new Button();
            btnYardM = new Button();
            btnKmMf = new Button();
            btnMfKm = new Button();
            btnVissza = new Button();
            tbEredmeny = new TextBox();
            nudBevisz = new NumericUpDown();
            lMertekegyseg = new Label();
            ((System.ComponentModel.ISupportInitialize)nudBevisz).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 22);
            label1.TabIndex = 0;
            label1.Text = "Felszín";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 48);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 1;
            label2.Text = "Adj meg egy értéket:";
            // 
            // lEredmeny
            // 
            lEredmeny.AutoSize = true;
            lEredmeny.Location = new Point(46, 189);
            lEredmeny.Name = "lEredmeny";
            lEredmeny.Size = new Size(63, 15);
            lEredmeny.TabIndex = 2;
            lEredmeny.Text = "Eredmény:";
            lEredmeny.Visible = false;
            // 
            // btnInchCm
            // 
            btnInchCm.Location = new Point(11, 87);
            btnInchCm.Name = "btnInchCm";
            btnInchCm.Size = new Size(125, 23);
            btnInchCm.TabIndex = 3;
            btnInchCm.Text = "Inch^2 --> Cm^2";
            btnInchCm.UseVisualStyleBackColor = true;
            btnInchCm.Visible = false;
            btnInchCm.Click += btnInchCm_Click;
            // 
            // btnCmInch
            // 
            btnCmInch.Location = new Point(142, 87);
            btnCmInch.Name = "btnCmInch";
            btnCmInch.Size = new Size(125, 23);
            btnCmInch.TabIndex = 4;
            btnCmInch.Text = "Cm^2 --> Inch^2";
            btnCmInch.UseVisualStyleBackColor = true;
            btnCmInch.Visible = false;
            btnCmInch.Click += btnCmInch_Click;
            // 
            // btnMYard
            // 
            btnMYard.Location = new Point(142, 116);
            btnMYard.Name = "btnMYard";
            btnMYard.Size = new Size(125, 23);
            btnMYard.TabIndex = 6;
            btnMYard.Text = "M^2 --> Yard^2";
            btnMYard.UseVisualStyleBackColor = true;
            btnMYard.Visible = false;
            btnMYard.Click += btnMYard_Click;
            // 
            // btnYardM
            // 
            btnYardM.Location = new Point(11, 116);
            btnYardM.Name = "btnYardM";
            btnYardM.Size = new Size(125, 23);
            btnYardM.TabIndex = 5;
            btnYardM.Text = "Yard^2 --> M^2";
            btnYardM.UseVisualStyleBackColor = true;
            btnYardM.Visible = false;
            btnYardM.Click += btnYardM_Click;
            // 
            // btnKmMf
            // 
            btnKmMf.Location = new Point(142, 145);
            btnKmMf.Name = "btnKmMf";
            btnKmMf.Size = new Size(125, 23);
            btnKmMf.TabIndex = 8;
            btnKmMf.Text = "Km^2 --> Mf^2";
            btnKmMf.UseVisualStyleBackColor = true;
            btnKmMf.Visible = false;
            btnKmMf.Click += btnKmMf_Click;
            // 
            // btnMfKm
            // 
            btnMfKm.Location = new Point(11, 145);
            btnMfKm.Name = "btnMfKm";
            btnMfKm.Size = new Size(125, 23);
            btnMfKm.TabIndex = 7;
            btnMfKm.Text = "Mf^2 --> Km^2";
            btnMfKm.UseVisualStyleBackColor = true;
            btnMfKm.Visible = false;
            btnMfKm.Click += btnMfKm_Click;
            // 
            // btnVissza
            // 
            btnVissza.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 238);
            btnVissza.Location = new Point(12, 232);
            btnVissza.Name = "btnVissza";
            btnVissza.Size = new Size(80, 23);
            btnVissza.TabIndex = 9;
            btnVissza.Text = "Vissza";
            btnVissza.UseVisualStyleBackColor = true;
            btnVissza.Click += btnVissza_Click;
            // 
            // tbEredmeny
            // 
            tbEredmeny.Enabled = false;
            tbEredmeny.Location = new Point(115, 186);
            tbEredmeny.Name = "tbEredmeny";
            tbEredmeny.Size = new Size(100, 23);
            tbEredmeny.TabIndex = 10;
            tbEredmeny.Visible = false;
            // 
            // nudBevisz
            // 
            nudBevisz.Location = new Point(147, 46);
            nudBevisz.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudBevisz.Name = "nudBevisz";
            nudBevisz.Size = new Size(120, 23);
            nudBevisz.TabIndex = 11;
            nudBevisz.ValueChanged += nudBevisz_ValueChanged;
            // 
            // lMertekegyseg
            // 
            lMertekegyseg.AutoSize = true;
            lMertekegyseg.Location = new Point(221, 189);
            lMertekegyseg.Name = "lMertekegyseg";
            lMertekegyseg.Size = new Size(16, 15);
            lMertekegyseg.TabIndex = 12;
            lMertekegyseg.Text = "...";
            lMertekegyseg.Visible = false;
            // 
            // Felszin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 267);
            Controls.Add(lMertekegyseg);
            Controls.Add(nudBevisz);
            Controls.Add(tbEredmeny);
            Controls.Add(btnVissza);
            Controls.Add(btnKmMf);
            Controls.Add(btnMfKm);
            Controls.Add(btnMYard);
            Controls.Add(btnYardM);
            Controls.Add(btnCmInch);
            Controls.Add(btnInchCm);
            Controls.Add(lEredmeny);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Felszin";
            Text = "Felszin";
            ((System.ComponentModel.ISupportInitialize)nudBevisz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lEredmeny;
        private Button btnInchCm;
        private Button btnCmInch;
        private Button btnMYard;
        private Button btnYardM;
        private Button btnKmMf;
        private Button btnMfKm;
        private Button btnVissza;
        private TextBox tbEredmeny;
        private NumericUpDown nudBevisz;
        private Label lMertekegyseg;
    }
}