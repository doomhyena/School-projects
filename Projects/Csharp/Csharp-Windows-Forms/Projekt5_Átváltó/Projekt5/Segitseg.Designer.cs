namespace Projekt5
{
    partial class Segitseg
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
            l1 = new Label();
            l2 = new Label();
            l3 = new Label();
            l4 = new Label();
            cb1 = new CheckBox();
            cb2 = new CheckBox();
            cb3 = new CheckBox();
            btnFooldalra = new Button();
            btnHossz = new Button();
            btnFelszin = new Button();
            btnUrmertek = new Button();
            btnSuly = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(211, 22);
            label1.TabIndex = 0;
            label1.Text = "Használati utasítás";
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(48, 48);
            l1.Name = "l1";
            l1.Size = new Size(168, 15);
            l1.TabIndex = 1;
            l1.Text = "1. Válassz mértékegység típust.";
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.Location = new Point(50, 82);
            l2.Name = "l2";
            l2.Size = new Size(128, 15);
            l2.TabIndex = 2;
            l2.Text = "2. Adj meg egy értéket.";
            l2.Visible = false;
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Location = new Point(50, 116);
            l3.Name = "l3";
            l3.Size = new Size(179, 15);
            l3.TabIndex = 3;
            l3.Text = "3. Válassz ki egy pontos átváltást.";
            l3.Visible = false;
            // 
            // l4
            // 
            l4.AutoSize = true;
            l4.Location = new Point(65, 185);
            l4.Name = "l4";
            l4.Size = new Size(212, 15);
            l4.TabIndex = 4;
            l4.Text = "Vagy innen válassz egy átváltási opciót:";
            l4.Visible = false;
            // 
            // cb1
            // 
            cb1.AutoSize = true;
            cb1.Location = new Point(238, 47);
            cb1.Name = "cb1";
            cb1.Size = new Size(60, 19);
            cb1.TabIndex = 5;
            cb1.Text = "Értem.";
            cb1.UseVisualStyleBackColor = true;
            cb1.CheckedChanged += cb1_CheckedChanged;
            // 
            // cb2
            // 
            cb2.AutoSize = true;
            cb2.Location = new Point(238, 78);
            cb2.Name = "cb2";
            cb2.Size = new Size(60, 19);
            cb2.TabIndex = 6;
            cb2.Text = "Értem.";
            cb2.UseVisualStyleBackColor = true;
            cb2.Visible = false;
            cb2.CheckedChanged += cb2_CheckedChanged;
            // 
            // cb3
            // 
            cb3.AutoSize = true;
            cb3.Location = new Point(238, 112);
            cb3.Name = "cb3";
            cb3.Size = new Size(60, 19);
            cb3.TabIndex = 7;
            cb3.Text = "Értem.";
            cb3.UseVisualStyleBackColor = true;
            cb3.Visible = false;
            cb3.CheckedChanged += cb3_CheckedChanged;
            // 
            // btnFooldalra
            // 
            btnFooldalra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnFooldalra.Location = new Point(50, 148);
            btnFooldalra.Name = "btnFooldalra";
            btnFooldalra.Size = new Size(248, 23);
            btnFooldalra.TabIndex = 8;
            btnFooldalra.Text = "Vissza a főoldalra";
            btnFooldalra.UseVisualStyleBackColor = true;
            btnFooldalra.Visible = false;
            btnFooldalra.Click += btnFooldalra_Click;
            // 
            // btnHossz
            // 
            btnHossz.Location = new Point(11, 213);
            btnHossz.Name = "btnHossz";
            btnHossz.Size = new Size(75, 23);
            btnHossz.TabIndex = 9;
            btnHossz.Text = "H.";
            btnHossz.UseVisualStyleBackColor = true;
            btnHossz.Visible = false;
            btnHossz.Click += btnHossz_Click;
            // 
            // btnFelszin
            // 
            btnFelszin.Location = new Point(92, 213);
            btnFelszin.Name = "btnFelszin";
            btnFelszin.Size = new Size(75, 23);
            btnFelszin.TabIndex = 10;
            btnFelszin.Text = "F.";
            btnFelszin.UseVisualStyleBackColor = true;
            btnFelszin.Visible = false;
            btnFelszin.Click += btnFelszin_Click;
            // 
            // btnUrmertek
            // 
            btnUrmertek.Location = new Point(173, 213);
            btnUrmertek.Name = "btnUrmertek";
            btnUrmertek.Size = new Size(75, 23);
            btnUrmertek.TabIndex = 11;
            btnUrmertek.Text = "Ű.";
            btnUrmertek.UseVisualStyleBackColor = true;
            btnUrmertek.Visible = false;
            btnUrmertek.Click += btnUrmertek_Click;
            // 
            // btnSuly
            // 
            btnSuly.Location = new Point(254, 213);
            btnSuly.Name = "btnSuly";
            btnSuly.Size = new Size(75, 23);
            btnSuly.TabIndex = 12;
            btnSuly.Text = "S.";
            btnSuly.UseVisualStyleBackColor = true;
            btnSuly.Visible = false;
            btnSuly.Click += btnSuly_Click;
            // 
            // Segitseg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 262);
            Controls.Add(btnSuly);
            Controls.Add(btnUrmertek);
            Controls.Add(btnFelszin);
            Controls.Add(btnHossz);
            Controls.Add(btnFooldalra);
            Controls.Add(cb3);
            Controls.Add(cb2);
            Controls.Add(cb1);
            Controls.Add(l4);
            Controls.Add(l3);
            Controls.Add(l2);
            Controls.Add(l1);
            Controls.Add(label1);
            Name = "Segitseg";
            Text = "Segitseg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label l1;
        private Label l2;
        private Label l3;
        private Label l4;
        private CheckBox cb1;
        private CheckBox cb2;
        private CheckBox cb3;
        private Button btnFooldalra;
        private Button btnHossz;
        private Button btnFelszin;
        private Button btnUrmertek;
        private Button btnSuly;
    }
}