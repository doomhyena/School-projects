namespace Projekt11
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
            lbTipus = new ListBox();
            tbKeres = new TextBox();
            rtbMezo = new RichTextBox();
            btnKeres = new Button();
            btnKilep = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lRekordszam = new Label();
            nudErt = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudErt).BeginInit();
            SuspendLayout();
            // 
            // lbTipus
            // 
            lbTipus.FormattingEnabled = true;
            lbTipus.ItemHeight = 15;
            lbTipus.Location = new Point(12, 30);
            lbTipus.Name = "lbTipus";
            lbTipus.Size = new Size(120, 109);
            lbTipus.TabIndex = 0;
            lbTipus.SelectedIndexChanged += lbTipus_SelectedIndexChanged;
            // 
            // tbKeres
            // 
            tbKeres.Location = new Point(199, 125);
            tbKeres.Name = "tbKeres";
            tbKeres.Size = new Size(174, 23);
            tbKeres.TabIndex = 1;
            // 
            // rtbMezo
            // 
            rtbMezo.Location = new Point(12, 153);
            rtbMezo.Name = "rtbMezo";
            rtbMezo.Size = new Size(528, 431);
            rtbMezo.TabIndex = 2;
            rtbMezo.Text = "";
            // 
            // btnKeres
            // 
            btnKeres.Location = new Point(400, 95);
            btnKeres.Name = "btnKeres";
            btnKeres.Size = new Size(140, 23);
            btnKeres.TabIndex = 3;
            btnKeres.Text = "Keresés";
            btnKeres.UseVisualStyleBackColor = true;
            btnKeres.Click += btnKeres_Click;
            // 
            // btnKilep
            // 
            btnKilep.Location = new Point(400, 124);
            btnKilep.Name = "btnKilep";
            btnKilep.Size = new Size(140, 23);
            btnKilep.TabIndex = 4;
            btnKilep.Text = "Kilépés";
            btnKilep.UseVisualStyleBackColor = true;
            btnKilep.Click += btnKilep_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "Típus:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 19);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Rekordok:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 128);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 7;
            label3.Text = "Név:";
            // 
            // lRekordszam
            // 
            lRekordszam.AutoSize = true;
            lRekordszam.BorderStyle = BorderStyle.FixedSingle;
            lRekordszam.Location = new Point(280, 19);
            lRekordszam.Name = "lRekordszam";
            lRekordszam.Size = new Size(18, 17);
            lRekordszam.TabIndex = 8;
            lRekordszam.Text = "...";
            // 
            // nudErt
            // 
            nudErt.Location = new Point(280, 70);
            nudErt.Name = "nudErt";
            nudErt.Size = new Size(93, 23);
            nudErt.TabIndex = 9;
            nudErt.ValueChanged += nudErt_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 72);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 10;
            label5.Text = "Minimum értékelés:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 596);
            Controls.Add(label5);
            Controls.Add(nudErt);
            Controls.Add(lRekordszam);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKilep);
            Controls.Add(btnKeres);
            Controls.Add(rtbMezo);
            Controls.Add(tbKeres);
            Controls.Add(lbTipus);
            Name = "Form1";
            Text = "Étterem kereső";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudErt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbTipus;
        private TextBox tbKeres;
        private RichTextBox rtbMezo;
        private Button btnKeres;
        private Button btnKilep;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lRekordszam;
        private NumericUpDown nudErt;
        private Label label5;
    }
}
