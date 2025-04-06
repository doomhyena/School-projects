namespace Projekt7
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
            btnKezd = new Button();
            btnKesz = new Button();
            lProbaFelirat = new Label();
            lProbakSzama = new Label();
            nudPluszMO = new NumericUpDown();
            nudMinuszMO = new NumericUpDown();
            nudSzorozMO = new NumericUpDown();
            nudOsztMO = new NumericUpDown();
            lPluszA = new Label();
            label4 = new Label();
            lPluszB = new Label();
            label6 = new Label();
            label7 = new Label();
            lMinuszB = new Label();
            label9 = new Label();
            lMinuszA = new Label();
            label11 = new Label();
            lSzorozB = new Label();
            label13 = new Label();
            lSzorozA = new Label();
            label15 = new Label();
            lOsztB = new Label();
            label17 = new Label();
            lOsztA = new Label();
            btnSugo = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPluszMO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuszMO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSzorozMO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOsztMO).BeginInit();
            SuspendLayout();
            // 
            // btnKezd
            // 
            btnKezd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnKezd.Location = new Point(12, 26);
            btnKezd.Name = "btnKezd";
            btnKezd.Size = new Size(222, 23);
            btnKezd.TabIndex = 0;
            btnKezd.Text = "Játék kezdése";
            btnKezd.UseVisualStyleBackColor = true;
            btnKezd.Click += btnKezd_Click;
            // 
            // btnKesz
            // 
            btnKesz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnKesz.Location = new Point(240, 26);
            btnKesz.Name = "btnKesz";
            btnKesz.Size = new Size(86, 23);
            btnKesz.TabIndex = 1;
            btnKesz.Text = "Kész vagyok";
            btnKesz.UseVisualStyleBackColor = true;
            btnKesz.Visible = false;
            btnKesz.Click += btnKesz_Click;
            // 
            // lProbaFelirat
            // 
            lProbaFelirat.AutoSize = true;
            lProbaFelirat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lProbaFelirat.Location = new Point(12, 72);
            lProbaFelirat.Name = "lProbaFelirat";
            lProbaFelirat.Size = new Size(199, 21);
            lProbaFelirat.TabIndex = 2;
            lProbaFelirat.Text = "Hátralévő próbák száma:";
            lProbaFelirat.Visible = false;
            // 
            // lProbakSzama
            // 
            lProbakSzama.AutoSize = true;
            lProbakSzama.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lProbakSzama.Location = new Point(217, 72);
            lProbakSzama.Name = "lProbakSzama";
            lProbakSzama.Size = new Size(19, 21);
            lProbakSzama.TabIndex = 3;
            lProbakSzama.Text = "3";
            lProbakSzama.Visible = false;
            // 
            // nudPluszMO
            // 
            nudPluszMO.Enabled = false;
            nudPluszMO.Location = new Point(226, 109);
            nudPluszMO.Name = "nudPluszMO";
            nudPluszMO.Size = new Size(100, 23);
            nudPluszMO.TabIndex = 4;
            // 
            // nudMinuszMO
            // 
            nudMinuszMO.Enabled = false;
            nudMinuszMO.Location = new Point(226, 160);
            nudMinuszMO.Name = "nudMinuszMO";
            nudMinuszMO.Size = new Size(100, 23);
            nudMinuszMO.TabIndex = 5;
            // 
            // nudSzorozMO
            // 
            nudSzorozMO.Enabled = false;
            nudSzorozMO.Location = new Point(226, 211);
            nudSzorozMO.Name = "nudSzorozMO";
            nudSzorozMO.Size = new Size(100, 23);
            nudSzorozMO.TabIndex = 6;
            // 
            // nudOsztMO
            // 
            nudOsztMO.Enabled = false;
            nudOsztMO.Location = new Point(226, 264);
            nudOsztMO.Name = "nudOsztMO";
            nudOsztMO.Size = new Size(100, 23);
            nudOsztMO.TabIndex = 7;
            // 
            // lPluszA
            // 
            lPluszA.AutoSize = true;
            lPluszA.Location = new Point(21, 111);
            lPluszA.Name = "lPluszA";
            lPluszA.Size = new Size(12, 15);
            lPluszA.TabIndex = 8;
            lPluszA.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 111);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 9;
            label4.Text = "+";
            // 
            // lPluszB
            // 
            lPluszB.AutoSize = true;
            lPluszB.Location = new Point(125, 111);
            lPluszB.Name = "lPluszB";
            lPluszB.Size = new Size(12, 15);
            lPluszB.TabIndex = 10;
            lPluszB.Text = "?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 111);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 11;
            label6.Text = "=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 164);
            label7.Name = "label7";
            label7.Size = new Size(15, 15);
            label7.TabIndex = 15;
            label7.Text = "=";
            // 
            // lMinuszB
            // 
            lMinuszB.AutoSize = true;
            lMinuszB.Location = new Point(125, 164);
            lMinuszB.Name = "lMinuszB";
            lMinuszB.Size = new Size(12, 15);
            lMinuszB.TabIndex = 14;
            lMinuszB.Text = "?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 164);
            label9.Name = "label9";
            label9.Size = new Size(12, 15);
            label9.TabIndex = 13;
            label9.Text = "-";
            // 
            // lMinuszA
            // 
            lMinuszA.AutoSize = true;
            lMinuszA.Location = new Point(21, 164);
            lMinuszA.Name = "lMinuszA";
            lMinuszA.Size = new Size(12, 15);
            lMinuszA.TabIndex = 12;
            lMinuszA.Text = "?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(178, 213);
            label11.Name = "label11";
            label11.Size = new Size(15, 15);
            label11.TabIndex = 19;
            label11.Text = "=";
            // 
            // lSzorozB
            // 
            lSzorozB.AutoSize = true;
            lSzorozB.Location = new Point(125, 213);
            lSzorozB.Name = "lSzorozB";
            lSzorozB.Size = new Size(12, 15);
            lSzorozB.TabIndex = 18;
            lSzorozB.Text = "?";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(70, 213);
            label13.Name = "label13";
            label13.Size = new Size(12, 15);
            label13.TabIndex = 17;
            label13.Text = "*";
            // 
            // lSzorozA
            // 
            lSzorozA.AutoSize = true;
            lSzorozA.Location = new Point(21, 213);
            lSzorozA.Name = "lSzorozA";
            lSzorozA.Size = new Size(12, 15);
            lSzorozA.TabIndex = 16;
            lSzorozA.Text = "?";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(178, 266);
            label15.Name = "label15";
            label15.Size = new Size(15, 15);
            label15.TabIndex = 23;
            label15.Text = "=";
            // 
            // lOsztB
            // 
            lOsztB.AutoSize = true;
            lOsztB.Location = new Point(125, 266);
            lOsztB.Name = "lOsztB";
            lOsztB.Size = new Size(12, 15);
            lOsztB.TabIndex = 22;
            lOsztB.Text = "?";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(70, 266);
            label17.Name = "label17";
            label17.Size = new Size(17, 15);
            label17.TabIndex = 21;
            label17.Text = "%";
            // 
            // lOsztA
            // 
            lOsztA.AutoSize = true;
            lOsztA.Location = new Point(21, 266);
            lOsztA.Name = "lOsztA";
            lOsztA.Size = new Size(12, 15);
            lOsztA.TabIndex = 20;
            lOsztA.Text = "?";
            // 
            // btnSugo
            // 
            btnSugo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnSugo.Location = new Point(294, 72);
            btnSugo.Name = "btnSugo";
            btnSugo.Size = new Size(32, 23);
            btnSugo.TabIndex = 24;
            btnSugo.Text = "?";
            btnSugo.UseVisualStyleBackColor = true;
            btnSugo.Click += btnSugo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 323);
            Controls.Add(btnSugo);
            Controls.Add(label15);
            Controls.Add(lOsztB);
            Controls.Add(label17);
            Controls.Add(lOsztA);
            Controls.Add(label11);
            Controls.Add(lSzorozB);
            Controls.Add(label13);
            Controls.Add(lSzorozA);
            Controls.Add(label7);
            Controls.Add(lMinuszB);
            Controls.Add(label9);
            Controls.Add(lMinuszA);
            Controls.Add(label6);
            Controls.Add(lPluszB);
            Controls.Add(label4);
            Controls.Add(lPluszA);
            Controls.Add(nudOsztMO);
            Controls.Add(nudSzorozMO);
            Controls.Add(nudMinuszMO);
            Controls.Add(nudPluszMO);
            Controls.Add(lProbakSzama);
            Controls.Add(lProbaFelirat);
            Controls.Add(btnKesz);
            Controls.Add(btnKezd);
            Name = "Form1";
            Text = "Random feladatok";
            ((System.ComponentModel.ISupportInitialize)nudPluszMO).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinuszMO).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSzorozMO).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOsztMO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKezd;
        private Button btnKesz;
        private Label lProbaFelirat;
        private Label lProbakSzama;
        private NumericUpDown nudPluszMO;
        private NumericUpDown nudMinuszMO;
        private NumericUpDown nudSzorozMO;
        private NumericUpDown nudOsztMO;
        private Label lPluszA;
        private Label label4;
        private Label lPluszB;
        private Label label6;
        private Label label7;
        private Label lMinuszB;
        private Label label9;
        private Label lMinuszA;
        private Label label11;
        private Label lSzorozB;
        private Label label13;
        private Label lSzorozA;
        private Label label15;
        private Label lOsztB;
        private Label label17;
        private Label lOsztA;
        private Button btnSugo;
    }
}
