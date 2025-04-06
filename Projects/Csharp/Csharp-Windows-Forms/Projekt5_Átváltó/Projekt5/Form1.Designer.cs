namespace Projekt5
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
            label2 = new Label();
            lIdo = new Label();
            btnHosszusag = new Button();
            btnFelszin = new Button();
            btnUrtartalom = new Button();
            btnSuly = new Button();
            btnSegitseg = new Button();
            btnBezar = new Button();
            cbIdo = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(234, 22);
            label1.TabIndex = 0;
            label1.Text = "Konvertáló alkalmazás";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 45);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 1;
            label2.Text = "Válassz egy egységtípust:";
            // 
            // lIdo
            // 
            lIdo.AutoSize = true;
            lIdo.Location = new Point(6, 268);
            lIdo.Name = "lIdo";
            lIdo.Size = new Size(16, 15);
            lIdo.TabIndex = 2;
            lIdo.Text = "...";
            lIdo.Visible = false;
            // 
            // btnHosszusag
            // 
            btnHosszusag.Location = new Point(60, 79);
            btnHosszusag.Name = "btnHosszusag";
            btnHosszusag.Size = new Size(113, 23);
            btnHosszusag.TabIndex = 3;
            btnHosszusag.Text = "Hosszúság";
            btnHosszusag.UseVisualStyleBackColor = true;
            btnHosszusag.Click += btnHosszusag_Click;
            // 
            // btnFelszin
            // 
            btnFelszin.Location = new Point(60, 108);
            btnFelszin.Name = "btnFelszin";
            btnFelszin.Size = new Size(113, 23);
            btnFelszin.TabIndex = 4;
            btnFelszin.Text = "Felszín";
            btnFelszin.UseVisualStyleBackColor = true;
            btnFelszin.Click += btnFelszin_Click;
            // 
            // btnUrtartalom
            // 
            btnUrtartalom.Location = new Point(60, 137);
            btnUrtartalom.Name = "btnUrtartalom";
            btnUrtartalom.Size = new Size(113, 23);
            btnUrtartalom.TabIndex = 5;
            btnUrtartalom.Text = "Űrtartalom";
            btnUrtartalom.UseVisualStyleBackColor = true;
            btnUrtartalom.Click += btnUrtartalom_Click;
            // 
            // btnSuly
            // 
            btnSuly.Location = new Point(60, 166);
            btnSuly.Name = "btnSuly";
            btnSuly.Size = new Size(113, 23);
            btnSuly.TabIndex = 6;
            btnSuly.Text = "Súly";
            btnSuly.UseVisualStyleBackColor = true;
            btnSuly.Click += btnSuly_Click;
            // 
            // btnSegitseg
            // 
            btnSegitseg.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 238);
            btnSegitseg.Location = new Point(60, 195);
            btnSegitseg.Name = "btnSegitseg";
            btnSegitseg.Size = new Size(113, 23);
            btnSegitseg.TabIndex = 7;
            btnSegitseg.Text = "Segítség";
            btnSegitseg.UseVisualStyleBackColor = true;
            btnSegitseg.Click += btnSegitseg_Click;
            // 
            // btnBezar
            // 
            btnBezar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnBezar.Location = new Point(199, 257);
            btnBezar.Name = "btnBezar";
            btnBezar.Size = new Size(34, 23);
            btnBezar.TabIndex = 8;
            btnBezar.Text = "X";
            btnBezar.UseVisualStyleBackColor = true;
            btnBezar.Click += btnBezar_Click;
            // 
            // cbIdo
            // 
            cbIdo.AutoSize = true;
            cbIdo.Location = new Point(6, 246);
            cbIdo.Name = "cbIdo";
            cbIdo.Size = new Size(117, 19);
            cbIdo.TabIndex = 9;
            cbIdo.Text = "Dátum mutatása:";
            cbIdo.UseVisualStyleBackColor = true;
            cbIdo.CheckedChanged += cbIdo_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 292);
            Controls.Add(cbIdo);
            Controls.Add(btnBezar);
            Controls.Add(btnSegitseg);
            Controls.Add(btnSuly);
            Controls.Add(btnUrtartalom);
            Controls.Add(btnFelszin);
            Controls.Add(btnHosszusag);
            Controls.Add(lIdo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mértékegység átváltó";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lIdo;
        private Button btnHosszusag;
        private Button btnFelszin;
        private Button btnUrtartalom;
        private Button btnSuly;
        private Button btnSegitseg;
        private Button btnBezar;
        private CheckBox cbIdo;
    }
}
