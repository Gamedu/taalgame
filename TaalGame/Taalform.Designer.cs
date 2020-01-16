namespace TaalGame
{
    partial class Taalform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taalform));
            this.CurrentQuestion = new System.Windows.Forms.Label();
            this.TextPunten = new System.Windows.Forms.Label();
            this.AnswerA = new System.Windows.Forms.Button();
            this.AnswerB = new System.Windows.Forms.Button();
            this.AnswerC = new System.Windows.Forms.Button();
            this.AnswerD = new System.Windows.Forms.Button();
            this.ModeStam = new System.Windows.Forms.Button();
            this.ModeSpelling = new System.Windows.Forms.Button();
            this.TextAnswerA = new System.Windows.Forms.Label();
            this.TextAnswerB = new System.Windows.Forms.Label();
            this.TextAnswerC = new System.Windows.Forms.Label();
            this.TextAnswerD = new System.Windows.Forms.Label();
            this.CheckSignal = new System.Windows.Forms.Timer(this.components);
            this.ModeSubject = new System.Windows.Forms.Button();
            this.StartTest = new System.Windows.Forms.Button();
            this.ScoreLive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentQuestion
            // 
            this.CurrentQuestion.AutoSize = true;
            this.CurrentQuestion.BackColor = System.Drawing.Color.Transparent;
            this.CurrentQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CurrentQuestion.Location = new System.Drawing.Point(343, 43);
            this.CurrentQuestion.Name = "CurrentQuestion";
            this.CurrentQuestion.Size = new System.Drawing.Size(233, 36);
            this.CurrentQuestion.TabIndex = 0;
            this.CurrentQuestion.Text = "CurrentQuestion";
            // 
            // TextPunten
            // 
            this.TextPunten.AutoSize = true;
            this.TextPunten.BackColor = System.Drawing.Color.Transparent;
            this.TextPunten.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TextPunten.Location = new System.Drawing.Point(583, 415);
            this.TextPunten.Name = "TextPunten";
            this.TextPunten.Size = new System.Drawing.Size(125, 39);
            this.TextPunten.TabIndex = 1;
            this.TextPunten.Text = "Punten";
            // 
            // AnswerA
            // 
            this.AnswerA.BackColor = System.Drawing.Color.Transparent;
            this.AnswerA.Location = new System.Drawing.Point(228, 260);
            this.AnswerA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(85, 54);
            this.AnswerA.TabIndex = 2;
            this.AnswerA.UseVisualStyleBackColor = false;
            this.AnswerA.Click += new System.EventHandler(this.GiveAnswerA);
            // 
            // AnswerB
            // 
            this.AnswerB.BackColor = System.Drawing.Color.Transparent;
            this.AnswerB.Location = new System.Drawing.Point(702, 260);
            this.AnswerB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(85, 54);
            this.AnswerB.TabIndex = 3;
            this.AnswerB.UseVisualStyleBackColor = false;
            this.AnswerB.Click += new System.EventHandler(this.GiveAnswerB);
            // 
            // AnswerC
            // 
            this.AnswerC.BackColor = System.Drawing.Color.Transparent;
            this.AnswerC.Location = new System.Drawing.Point(228, 502);
            this.AnswerC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(85, 54);
            this.AnswerC.TabIndex = 4;
            this.AnswerC.UseVisualStyleBackColor = false;
            this.AnswerC.Click += new System.EventHandler(this.GiveAnswerC);
            // 
            // AnswerD
            // 
            this.AnswerD.BackColor = System.Drawing.Color.Transparent;
            this.AnswerD.Location = new System.Drawing.Point(702, 502);
            this.AnswerD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(85, 54);
            this.AnswerD.TabIndex = 5;
            this.AnswerD.UseVisualStyleBackColor = false;
            this.AnswerD.Click += new System.EventHandler(this.GiveAnswerD);
            // 
            // ModeStam
            // 
            this.ModeStam.Location = new System.Drawing.Point(13, 364);
            this.ModeStam.Margin = new System.Windows.Forms.Padding(4);
            this.ModeStam.Name = "ModeStam";
            this.ModeStam.Size = new System.Drawing.Size(92, 47);
            this.ModeStam.TabIndex = 6;
            this.ModeStam.Text = "Stam";
            this.ModeStam.UseVisualStyleBackColor = true;
            this.ModeStam.Click += new System.EventHandler(this.ChangeToStam);
            // 
            // ModeSpelling
            // 
            this.ModeSpelling.Location = new System.Drawing.Point(13, 418);
            this.ModeSpelling.Margin = new System.Windows.Forms.Padding(4);
            this.ModeSpelling.Name = "ModeSpelling";
            this.ModeSpelling.Size = new System.Drawing.Size(92, 47);
            this.ModeSpelling.TabIndex = 7;
            this.ModeSpelling.Text = "Spelling";
            this.ModeSpelling.UseVisualStyleBackColor = true;
            this.ModeSpelling.Click += new System.EventHandler(this.ChangeToSpelling);
            // 
            // TextAnswerA
            // 
            this.TextAnswerA.AutoSize = true;
            this.TextAnswerA.BackColor = System.Drawing.Color.Transparent;
            this.TextAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TextAnswerA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextAnswerA.Location = new System.Drawing.Point(231, 316);
            this.TextAnswerA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextAnswerA.Name = "TextAnswerA";
            this.TextAnswerA.Size = new System.Drawing.Size(58, 58);
            this.TextAnswerA.TabIndex = 8;
            this.TextAnswerA.Text = "A";
            // 
            // TextAnswerB
            // 
            this.TextAnswerB.AutoSize = true;
            this.TextAnswerB.BackColor = System.Drawing.Color.Transparent;
            this.TextAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TextAnswerB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextAnswerB.Location = new System.Drawing.Point(701, 316);
            this.TextAnswerB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextAnswerB.Name = "TextAnswerB";
            this.TextAnswerB.Size = new System.Drawing.Size(58, 58);
            this.TextAnswerB.TabIndex = 9;
            this.TextAnswerB.Text = "B";
            // 
            // TextAnswerC
            // 
            this.TextAnswerC.AutoSize = true;
            this.TextAnswerC.BackColor = System.Drawing.Color.Transparent;
            this.TextAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TextAnswerC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextAnswerC.Location = new System.Drawing.Point(231, 558);
            this.TextAnswerC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextAnswerC.Name = "TextAnswerC";
            this.TextAnswerC.Size = new System.Drawing.Size(61, 58);
            this.TextAnswerC.TabIndex = 10;
            this.TextAnswerC.Text = "C";
            // 
            // TextAnswerD
            // 
            this.TextAnswerD.AutoSize = true;
            this.TextAnswerD.BackColor = System.Drawing.Color.Transparent;
            this.TextAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TextAnswerD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextAnswerD.Location = new System.Drawing.Point(701, 558);
            this.TextAnswerD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextAnswerD.Name = "TextAnswerD";
            this.TextAnswerD.Size = new System.Drawing.Size(61, 58);
            this.TextAnswerD.TabIndex = 11;
            this.TextAnswerD.Text = "D";
            // 
            // CheckSignal
            // 
            this.CheckSignal.Interval = 1000;
            this.CheckSignal.Tick += new System.EventHandler(this.CheckSignal_Tick);
            // 
            // ModeSubject
            // 
            this.ModeSubject.Location = new System.Drawing.Point(13, 472);
            this.ModeSubject.Name = "ModeSubject";
            this.ModeSubject.Size = new System.Drawing.Size(92, 47);
            this.ModeSubject.TabIndex = 13;
            this.ModeSubject.Text = "Subject";
            this.ModeSubject.UseVisualStyleBackColor = true;
            this.ModeSubject.Click += new System.EventHandler(this.ChangeToSubject);
            // 
            // StartTest
            // 
            this.StartTest.Location = new System.Drawing.Point(13, 587);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(92, 47);
            this.StartTest.TabIndex = 14;
            this.StartTest.Text = "Start Test";
            this.StartTest.UseVisualStyleBackColor = true;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // ScoreLive
            // 
            this.ScoreLive.AutoSize = true;
            this.ScoreLive.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ScoreLive.Location = new System.Drawing.Point(599, 454);
            this.ScoreLive.Name = "ScoreLive";
            this.ScoreLive.Size = new System.Drawing.Size(109, 39);
            this.ScoreLive.TabIndex = 15;
            this.ScoreLive.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(109, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(112, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 39);
            this.label2.TabIndex = 17;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(111, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 39);
            this.label3.TabIndex = 18;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(111, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 39);
            this.label4.TabIndex = 19;
            this.label4.Text = "4";
            // 
            // Taalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1417, 763);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreLive);
            this.Controls.Add(this.StartTest);
            this.Controls.Add(this.ModeSubject);
            this.Controls.Add(this.TextAnswerD);
            this.Controls.Add(this.TextAnswerC);
            this.Controls.Add(this.TextAnswerB);
            this.Controls.Add(this.TextAnswerA);
            this.Controls.Add(this.ModeSpelling);
            this.Controls.Add(this.ModeStam);
            this.Controls.Add(this.AnswerD);
            this.Controls.Add(this.AnswerC);
            this.Controls.Add(this.AnswerB);
            this.Controls.Add(this.AnswerA);
            this.Controls.Add(this.TextPunten);
            this.Controls.Add(this.CurrentQuestion);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Taalform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentQuestion;
        private System.Windows.Forms.Label TextPunten;
        private System.Windows.Forms.Button AnswerA;
        private System.Windows.Forms.Button AnswerB;
        private System.Windows.Forms.Button AnswerC;
        private System.Windows.Forms.Button AnswerD;
        private System.Windows.Forms.Button ModeStam;
        private System.Windows.Forms.Button ModeSpelling;
        private System.Windows.Forms.Label TextAnswerA;
        private System.Windows.Forms.Label TextAnswerB;
        private System.Windows.Forms.Label TextAnswerC;
        private System.Windows.Forms.Label TextAnswerD;
        private System.Windows.Forms.Timer CheckSignal;
        private System.Windows.Forms.Button ModeSubject;
        private System.Windows.Forms.Button StartTest;
        private System.Windows.Forms.Label ScoreLive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

