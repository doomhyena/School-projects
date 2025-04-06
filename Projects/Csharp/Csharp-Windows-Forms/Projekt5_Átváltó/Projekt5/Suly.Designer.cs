namespace Projekt5
{
    partial class Suly
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
            btnKgM = new Button();
            btnVissza = new Button();
            btnMKg = new Button();
            btnMT = new Button();
            btnTM = new Button();
            btnKgT = new Button();
            btnTKg = new Button();
            label1 = new Label();
            label2 = new Label();
            lEredmeny = new Label();
            tbEredmeny = new TextBox();
            nudBevisz = new NumericUpDown();
            lMertekegyseg = new Label();
            ((System.ComponentModel.ISupportInitialize)nudBevisz).BeginInit();
            SuspendLayout();
            // 
            // btnKgM
            // 
            btnKgM.Location = new Point(15, 73);
            btnKgM.Name = "btnKgM";
            btnKgM.Size = new Size(124, 23);
            btnKgM.TabIndex = 0;
            btnKgM.Text = "Kg --> Mázsa";
            btnKgM.UseVisualStyleBackColor = true;
            btnKgM.Visible = false;
            btnKgM.Click += btnKgM_Click;
            // 
            // btnVissza
            // 
            btnVissza.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 238);
            btnVissza.Location = new Point(12, 228);
            btnVissza.Name = "btnVissza";
            btnVissza.Size = new Size(75, 23);
            btnVissza.TabIndex = 1;
            btnVissza.Text = "Vissza";
            btnVissza.UseVisualStyleBackColor = true;
            btnVissza.Click += btnVissza_Click;
            // 
            // btnMKg
            // 
            btnMKg.Location = new Point(145, 73);
            btnMKg.Name = "btnMKg";
            btnMKg.Size = new Size(124, 23);
            btnMKg.TabIndex = 2;
            btnMKg.Text = "Mázsa --> Kg";
            btnMKg.UseVisualStyleBackColor = true;
            btnMKg.Visible = false;
            btnMKg.Click += btnMKg_Click;
            // 
            // btnMT
            // 
            btnMT.Location = new Point(15, 102);
            btnMT.Name = "btnMT";
            btnMT.Size = new Size(124, 23);
            btnMT.TabIndex = 3;
            btnMT.Text = "Mázsa --> Tonna";
            btnMT.UseVisualStyleBackColor = true;
            btnMT.Visible = false;
            btnMT.Click += btnMT_Click;
            // 
            // btnTM
            // 
            btnTM.Location = new Point(145, 102);
            btnTM.Name = "btnTM";
            btnTM.Size = new Size(124, 23);
            btnTM.TabIndex = 4;
            btnTM.Text = "Tonna --> Mázsa";
            btnTM.UseVisualStyleBackColor = true;
            btnTM.Visible = false;
            btnTM.Click += btnTM_Click;
            // 
            // btnKgT
            // 
            btnKgT.Location = new Point(15, 131);
            btnKgT.Name = "btnKgT";
            btnKgT.Size = new Size(124, 23);
            btnKgT.TabIndex = 5;
            btnKgT.Text = "Kg --> Tonna";
            btnKgT.UseVisualStyleBackColor = true;
            btnKgT.Visible = false;
            btnKgT.Click += btnKgT_Click;
            // 
            // btnTKg
            // 
            btnTKg.Location = new Point(145, 131);
            btnTKg.Name = "btnTKg";
            btnTKg.Size = new Size(124, 23);
            btnTKg.TabIndex = 6;
            btnTKg.Text = "Tonna --> Kg";
            btnTKg.UseVisualStyleBackColor = true;
            btnTKg.Visible = false;
            btnTKg.Click += btnTKg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 7;
            label1.Text = "Súly";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 46);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 8;
            label2.Text = "Adj meg egy értéket:";
            // 
            // lEredmeny
            // 
            lEredmeny.AutoSize = true;
            lEredmeny.Location = new Point(37, 173);
            lEredmeny.Name = "lEredmeny";
            lEredmeny.Size = new Size(63, 15);
            lEredmeny.TabIndex = 9;
            lEredmeny.Text = "Eredmény:";
            lEredmeny.Visible = false;
            // 
            // tbEredmeny
            // 
            tbEredmeny.Enabled = false;
            tbEredmeny.Location = new Point(106, 170);
            tbEredmeny.Name = "tbEredmeny";
            tbEredmeny.Size = new Size(100, 23);
            tbEredmeny.TabIndex = 10;
            tbEredmeny.Visible = false;
            // 
            // nudBevisz
            // 
            nudBevisz.Location = new Point(160, 44);
            nudBevisz.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudBevisz.Name = "nudBevisz";
            nudBevisz.Size = new Size(92, 23);
            nudBevisz.TabIndex = 11;
            nudBevisz.ValueChanged += nudBevisz_ValueChanged;
            // 
            // lMertekegyseg
            // 
            lMertekegyseg.AutoSize = true;
            lMertekegyseg.Location = new Point(214, 173);
            lMertekegyseg.Name = "lMertekegyseg";
            lMertekegyseg.Size = new Size(16, 15);
            lMertekegyseg.TabIndex = 12;
            lMertekegyseg.Text = "...";
            lMertekegyseg.Visible = false;
            // 
            // Suly
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 269);
            Controls.Add(lMertekegyseg);
            Controls.Add(nudBevisz);
            Controls.Add(tbEredmeny);
            Controls.Add(lEredmeny);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTKg);
            Controls.Add(btnKgT);
            Controls.Add(btnTM);
            Controls.Add(btnMT);
            Controls.Add(btnMKg);
            Controls.Add(btnVissza);
            Controls.Add(btnKgM);
            Name = "Suly";
            Text = "Suly";
            ((System.ComponentModel.ISupportInitialize)nudBevisz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKgM;
        private Button btnVissza;
        private Button btnMKg;
        private Button btnMT;
        private Button btnTM;
        private Button btnKgT;
        private Button btnTKg;
        private Label label1;
        private Label label2;
        private Label lEredmeny;
        private TextBox tbEredmeny;
        private NumericUpDown nudBevisz;
        private Label lMertekegyseg;
    }
}