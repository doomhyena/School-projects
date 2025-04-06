namespace Projekt5
{
    partial class Hossz
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
            btnCmM = new Button();
            btnMKm = new Button();
            btnCmKm = new Button();
            btnVissza = new Button();
            tbErdmeny = new TextBox();
            nudBevisz = new NumericUpDown();
            btnKmCm = new Button();
            btnKmM = new Button();
            btnMCm = new Button();
            lMertekegyseg = new Label();
            ((System.ComponentModel.ISupportInitialize)nudBevisz).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 22);
            label1.TabIndex = 0;
            label1.Text = "Hosszúság";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 45);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 1;
            label2.Text = "Adj meg egy hosszúságot:";
            // 
            // lEredmeny
            // 
            lEredmeny.AutoSize = true;
            lEredmeny.Location = new Point(44, 215);
            lEredmeny.Name = "lEredmeny";
            lEredmeny.Size = new Size(63, 15);
            lEredmeny.TabIndex = 2;
            lEredmeny.Text = "Eredmény:";
            lEredmeny.Visible = false;
            // 
            // btnCmM
            // 
            btnCmM.Location = new Point(11, 84);
            btnCmM.Name = "btnCmM";
            btnCmM.Size = new Size(105, 23);
            btnCmM.TabIndex = 3;
            btnCmM.Text = "Cm --> M";
            btnCmM.UseVisualStyleBackColor = true;
            btnCmM.Visible = false;
            btnCmM.Click += btnCmM_Click;
            // 
            // btnMKm
            // 
            btnMKm.Location = new Point(11, 123);
            btnMKm.Name = "btnMKm";
            btnMKm.Size = new Size(105, 23);
            btnMKm.TabIndex = 5;
            btnMKm.Text = "M --> Km";
            btnMKm.UseVisualStyleBackColor = true;
            btnMKm.Visible = false;
            btnMKm.Click += btnMKm_Click;
            // 
            // btnCmKm
            // 
            btnCmKm.Location = new Point(11, 168);
            btnCmKm.Name = "btnCmKm";
            btnCmKm.Size = new Size(105, 23);
            btnCmKm.TabIndex = 7;
            btnCmKm.Text = "Cm --> Km";
            btnCmKm.UseVisualStyleBackColor = true;
            btnCmKm.Visible = false;
            btnCmKm.Click += btnCmKm_Click;
            // 
            // btnVissza
            // 
            btnVissza.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 238);
            btnVissza.Location = new Point(11, 254);
            btnVissza.Name = "btnVissza";
            btnVissza.Size = new Size(75, 23);
            btnVissza.TabIndex = 9;
            btnVissza.Text = "Vissza";
            btnVissza.UseVisualStyleBackColor = true;
            btnVissza.Click += btnVissza_Click;
            // 
            // tbErdmeny
            // 
            tbErdmeny.Enabled = false;
            tbErdmeny.Location = new Point(113, 212);
            tbErdmeny.Name = "tbErdmeny";
            tbErdmeny.Size = new Size(80, 23);
            tbErdmeny.TabIndex = 10;
            tbErdmeny.Visible = false;
            // 
            // nudBevisz
            // 
            nudBevisz.Location = new Point(162, 43);
            nudBevisz.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudBevisz.Name = "nudBevisz";
            nudBevisz.Size = new Size(76, 23);
            nudBevisz.TabIndex = 11;
            nudBevisz.ValueChanged += nudBevisz_ValueChanged;
            // 
            // btnKmCm
            // 
            btnKmCm.Location = new Point(133, 168);
            btnKmCm.Name = "btnKmCm";
            btnKmCm.Size = new Size(105, 23);
            btnKmCm.TabIndex = 14;
            btnKmCm.Text = "Km --> Cm";
            btnKmCm.UseVisualStyleBackColor = true;
            btnKmCm.Visible = false;
            btnKmCm.Click += btnKmCm_Click;
            // 
            // btnKmM
            // 
            btnKmM.Location = new Point(133, 123);
            btnKmM.Name = "btnKmM";
            btnKmM.Size = new Size(105, 23);
            btnKmM.TabIndex = 13;
            btnKmM.Text = "Km --> M";
            btnKmM.UseVisualStyleBackColor = true;
            btnKmM.Visible = false;
            btnKmM.Click += btnKmM_Click;
            // 
            // btnMCm
            // 
            btnMCm.Location = new Point(133, 84);
            btnMCm.Name = "btnMCm";
            btnMCm.Size = new Size(105, 23);
            btnMCm.TabIndex = 12;
            btnMCm.Text = "M --> Cm";
            btnMCm.UseVisualStyleBackColor = true;
            btnMCm.Visible = false;
            btnMCm.Click += btnMCm_Click;
            // 
            // lMertekegyseg
            // 
            lMertekegyseg.AutoSize = true;
            lMertekegyseg.Location = new Point(199, 215);
            lMertekegyseg.Name = "lMertekegyseg";
            lMertekegyseg.Size = new Size(16, 15);
            lMertekegyseg.TabIndex = 15;
            lMertekegyseg.Text = "...";
            lMertekegyseg.Visible = false;
            // 
            // Hossz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 289);
            Controls.Add(lMertekegyseg);
            Controls.Add(btnKmCm);
            Controls.Add(btnKmM);
            Controls.Add(btnMCm);
            Controls.Add(nudBevisz);
            Controls.Add(tbErdmeny);
            Controls.Add(btnVissza);
            Controls.Add(btnCmKm);
            Controls.Add(btnMKm);
            Controls.Add(btnCmM);
            Controls.Add(lEredmeny);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Hossz";
            Text = "Hosszúság";
            ((System.ComponentModel.ISupportInitialize)nudBevisz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lEredmeny;
        private Button btnCmM;
        private Button btnMKm;
        private Button btnCmKm;
        private Button btnVissza;
        private TextBox tbErdmeny;
        private NumericUpDown nudBevisz;
        private Button btnKmCm;
        private Button btnKmM;
        private Button btnMCm;
        private Label lMertekegyseg;
    }
}