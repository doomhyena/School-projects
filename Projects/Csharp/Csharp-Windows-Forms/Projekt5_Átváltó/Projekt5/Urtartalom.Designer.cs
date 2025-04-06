namespace Projekt5
{
    partial class Urtartalom
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
            btnCmM = new Button();
            btnMCm = new Button();
            btnMKm = new Button();
            btnKmM = new Button();
            btnCmDm = new Button();
            btnDmCm = new Button();
            btnVissza = new Button();
            nudBevisz = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            lEredmeny = new Label();
            tbEredmeny = new TextBox();
            lMertekegyseg = new Label();
            ((System.ComponentModel.ISupportInitialize)nudBevisz).BeginInit();
            SuspendLayout();
            // 
            // btnCmM
            // 
            btnCmM.Location = new Point(4, 69);
            btnCmM.Name = "btnCmM";
            btnCmM.Size = new Size(138, 23);
            btnCmM.TabIndex = 0;
            btnCmM.Text = "Cm^3 --> M^3";
            btnCmM.UseVisualStyleBackColor = true;
            btnCmM.Visible = false;
            btnCmM.Click += btnCmM_Click;
            // 
            // btnMCm
            // 
            btnMCm.Location = new Point(148, 69);
            btnMCm.Name = "btnMCm";
            btnMCm.Size = new Size(138, 23);
            btnMCm.TabIndex = 1;
            btnMCm.Text = "M^3 --> Cm^3";
            btnMCm.UseVisualStyleBackColor = true;
            btnMCm.Visible = false;
            btnMCm.Click += btnMCm_Click;
            // 
            // btnMKm
            // 
            btnMKm.Location = new Point(4, 98);
            btnMKm.Name = "btnMKm";
            btnMKm.Size = new Size(138, 23);
            btnMKm.TabIndex = 2;
            btnMKm.Text = "M^3 --> Km^3";
            btnMKm.UseVisualStyleBackColor = true;
            btnMKm.Visible = false;
            btnMKm.Click += btnMKm_Click;
            // 
            // btnKmM
            // 
            btnKmM.Location = new Point(148, 98);
            btnKmM.Name = "btnKmM";
            btnKmM.Size = new Size(138, 23);
            btnKmM.TabIndex = 3;
            btnKmM.Text = "Km^3 --> M^3";
            btnKmM.UseVisualStyleBackColor = true;
            btnKmM.Visible = false;
            btnKmM.Click += btnKmM_Click;
            // 
            // btnCmDm
            // 
            btnCmDm.Location = new Point(4, 127);
            btnCmDm.Name = "btnCmDm";
            btnCmDm.Size = new Size(138, 23);
            btnCmDm.TabIndex = 4;
            btnCmDm.Text = "Cm^3 --> Dm^3";
            btnCmDm.UseVisualStyleBackColor = true;
            btnCmDm.Visible = false;
            btnCmDm.Click += btnCmDm_Click;
            // 
            // btnDmCm
            // 
            btnDmCm.Location = new Point(148, 127);
            btnDmCm.Name = "btnDmCm";
            btnDmCm.Size = new Size(138, 23);
            btnDmCm.TabIndex = 5;
            btnDmCm.Text = "Dm^3 --> Cm^3";
            btnDmCm.UseVisualStyleBackColor = true;
            btnDmCm.Visible = false;
            btnDmCm.Click += btnDmCm_Click;
            // 
            // btnVissza
            // 
            btnVissza.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 238);
            btnVissza.Location = new Point(12, 221);
            btnVissza.Name = "btnVissza";
            btnVissza.Size = new Size(71, 23);
            btnVissza.TabIndex = 6;
            btnVissza.Text = "Vissza";
            btnVissza.UseVisualStyleBackColor = true;
            btnVissza.Click += btnVissza_Click;
            // 
            // nudBevisz
            // 
            nudBevisz.Location = new Point(148, 40);
            nudBevisz.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudBevisz.Name = "nudBevisz";
            nudBevisz.Size = new Size(104, 23);
            nudBevisz.TabIndex = 7;
            nudBevisz.ValueChanged += nudBevisz_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 5);
            label1.Name = "label1";
            label1.Size = new Size(100, 22);
            label1.TabIndex = 8;
            label1.Text = "Térfogat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 42);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 9;
            label2.Text = "Adj meg egy értéket:";
            // 
            // lEredmeny
            // 
            lEredmeny.AutoSize = true;
            lEredmeny.Location = new Point(42, 170);
            lEredmeny.Name = "lEredmeny";
            lEredmeny.Size = new Size(63, 15);
            lEredmeny.TabIndex = 10;
            lEredmeny.Text = "Eredmény:";
            lEredmeny.Visible = false;
            // 
            // tbEredmeny
            // 
            tbEredmeny.Enabled = false;
            tbEredmeny.Location = new Point(111, 167);
            tbEredmeny.Name = "tbEredmeny";
            tbEredmeny.Size = new Size(100, 23);
            tbEredmeny.TabIndex = 11;
            tbEredmeny.Visible = false;
            // 
            // lMertekegyseg
            // 
            lMertekegyseg.AutoSize = true;
            lMertekegyseg.Location = new Point(217, 170);
            lMertekegyseg.Name = "lMertekegyseg";
            lMertekegyseg.Size = new Size(16, 15);
            lMertekegyseg.TabIndex = 12;
            lMertekegyseg.Text = "...";
            lMertekegyseg.Visible = false;
            // 
            // Urtartalom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 256);
            Controls.Add(lMertekegyseg);
            Controls.Add(tbEredmeny);
            Controls.Add(lEredmeny);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudBevisz);
            Controls.Add(btnVissza);
            Controls.Add(btnDmCm);
            Controls.Add(btnCmDm);
            Controls.Add(btnKmM);
            Controls.Add(btnMKm);
            Controls.Add(btnMCm);
            Controls.Add(btnCmM);
            Name = "Urtartalom";
            Text = "Térfogat";
            ((System.ComponentModel.ISupportInitialize)nudBevisz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCmM;
        private Button btnMCm;
        private Button btnMKm;
        private Button btnKmM;
        private Button btnCmDm;
        private Button btnDmCm;
        private Button btnVissza;
        private NumericUpDown nudBevisz;
        private Label label1;
        private Label label2;
        private Label lEredmeny;
        private TextBox tbEredmeny;
        private Label lMertekegyseg;
    }
}