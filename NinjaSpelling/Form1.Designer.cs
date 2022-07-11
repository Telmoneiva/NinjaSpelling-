namespace NinjaSpelling
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.startBut = new System.Windows.Forms.Button();
            this.gameScreen = new System.Windows.Forms.Panel();
            this.txbLetter = new System.Windows.Forms.GroupBox();
            this.butEnter = new System.Windows.Forms.Button();
            this.textLetter = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labRemainingLives = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreScreen = new System.Windows.Forms.Panel();
            this.lblTotalW = new System.Windows.Forms.Label();
            this.lblTotalC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gameScreen.SuspendLayout();
            this.txbLetter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.scoreScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBut
            // 
            this.startBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBut.Location = new System.Drawing.Point(12, 463);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(893, 112);
            this.startBut.TabIndex = 3;
            this.startBut.Text = "S T A R T";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // gameScreen
            // 
            this.gameScreen.Controls.Add(this.txbLetter);
            this.gameScreen.Controls.Add(this.groupBox2);
            this.gameScreen.Controls.Add(this.groupBox1);
            this.gameScreen.Controls.Add(this.txbWord);
            this.gameScreen.Controls.Add(this.label1);
            this.gameScreen.Location = new System.Drawing.Point(12, 12);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(893, 445);
            this.gameScreen.TabIndex = 2;
            this.gameScreen.Visible = false;
            // 
            // txbLetter
            // 
            this.txbLetter.Controls.Add(this.butEnter);
            this.txbLetter.Controls.Add(this.textLetter);
            this.txbLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLetter.ForeColor = System.Drawing.Color.DimGray;
            this.txbLetter.Location = new System.Drawing.Point(57, 134);
            this.txbLetter.Name = "txbLetter";
            this.txbLetter.Size = new System.Drawing.Size(522, 298);
            this.txbLetter.TabIndex = 4;
            this.txbLetter.TabStop = false;
            this.txbLetter.Text = "Write A Letter ";
            // 
            // butEnter
            // 
            this.butEnter.ForeColor = System.Drawing.Color.DarkOrange;
            this.butEnter.Location = new System.Drawing.Point(6, 101);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(470, 64);
            this.butEnter.TabIndex = 1;
            this.butEnter.Text = "R E P E A T    T H E   P H R A S E  ";
            this.butEnter.UseVisualStyleBackColor = true;
            this.butEnter.Click += new System.EventHandler(this.butEnter_Click);
            // 
            // textLetter
            // 
            this.textLetter.Location = new System.Drawing.Point(6, 31);
            this.textLetter.MaxLength = 20;
            this.textLetter.Name = "textLetter";
            this.textLetter.Size = new System.Drawing.Size(470, 32);
            this.textLetter.TabIndex = 0;
            this.textLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLetter_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labRemainingLives);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(608, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remaining Lives";
            // 
            // labRemainingLives
            // 
            this.labRemainingLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRemainingLives.ForeColor = System.Drawing.Color.Red;
            this.labRemainingLives.Location = new System.Drawing.Point(11, 56);
            this.labRemainingLives.Name = "labRemainingLives";
            this.labRemainingLives.Size = new System.Drawing.Size(221, 29);
            this.labRemainingLives.TabIndex = 0;
            this.labRemainingLives.Text = "5";
            this.labRemainingLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Location = new System.Drawing.Point(608, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remaining Time";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 0;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbWord
            // 
            this.txbWord.Enabled = false;
            this.txbWord.Location = new System.Drawing.Point(57, 68);
            this.txbWord.Name = "txbWord";
            this.txbWord.Size = new System.Drawing.Size(789, 20);
            this.txbWord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identify The Scret Answer ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreScreen
            // 
            this.scoreScreen.Controls.Add(this.lblTotalW);
            this.scoreScreen.Controls.Add(this.lblTotalC);
            this.scoreScreen.Controls.Add(this.label3);
            this.scoreScreen.Location = new System.Drawing.Point(12, 12);
            this.scoreScreen.Name = "scoreScreen";
            this.scoreScreen.Size = new System.Drawing.Size(893, 123);
            this.scoreScreen.TabIndex = 4;
            this.scoreScreen.Visible = false;
            // 
            // lblTotalW
            // 
            this.lblTotalW.AutoSize = true;
            this.lblTotalW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalW.ForeColor = System.Drawing.Color.Red;
            this.lblTotalW.Location = new System.Drawing.Point(17, 77);
            this.lblTotalW.Name = "lblTotalW";
            this.lblTotalW.Size = new System.Drawing.Size(51, 20);
            this.lblTotalW.TabIndex = 2;
            this.lblTotalW.Text = "label5";
            // 
            // lblTotalC
            // 
            this.lblTotalC.AutoSize = true;
            this.lblTotalC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalC.ForeColor = System.Drawing.Color.Green;
            this.lblTotalC.Location = new System.Drawing.Point(17, 47);
            this.lblTotalC.Name = "lblTotalC";
            this.lblTotalC.Size = new System.Drawing.Size(51, 20);
            this.lblTotalC.TabIndex = 1;
            this.lblTotalC.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "SCORE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 584);
            this.Controls.Add(this.scoreScreen);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.gameScreen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gameScreen.ResumeLayout(false);
            this.gameScreen.PerformLayout();
            this.txbLetter.ResumeLayout(false);
            this.txbLetter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.scoreScreen.ResumeLayout(false);
            this.scoreScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBut;
        private System.Windows.Forms.Panel gameScreen;
        private System.Windows.Forms.GroupBox txbLetter;
        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.TextBox textLetter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labRemainingLives;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel scoreScreen;
        private System.Windows.Forms.Label lblTotalW;
        private System.Windows.Forms.Label lblTotalC;
        private System.Windows.Forms.Label label3;
    }
}

