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
            this.Score = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // CurrentQuestion
            // 
            this.CurrentQuestion.AutoSize = true;
            this.CurrentQuestion.Location = new System.Drawing.Point(921, 75);
            this.CurrentQuestion.Name = "CurrentQuestion";
            this.CurrentQuestion.Size = new System.Drawing.Size(112, 17);
            this.CurrentQuestion.TabIndex = 0;
            this.CurrentQuestion.Text = "CurrentQuestion";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(840, 633);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(65, 17);
            this.Score.TabIndex = 1;
            this.Score.Text = "Punten : ";
            // 
            // AnswerA
            // 
            this.AnswerA.Location = new System.Drawing.Point(313, 372);
            this.AnswerA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(85, 54);
            this.AnswerA.TabIndex = 2;
            this.AnswerA.Text = "A";
            this.AnswerA.UseVisualStyleBackColor = true;
            this.AnswerA.Click += new System.EventHandler(this.GiveAnswerA);
            // 
            // AnswerB
            // 
            this.AnswerB.Location = new System.Drawing.Point(948, 372);
            this.AnswerB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(85, 46);
            this.AnswerB.TabIndex = 3;
            this.AnswerB.Text = "B";
            this.AnswerB.UseVisualStyleBackColor = true;
            this.AnswerB.Click += new System.EventHandler(this.GiveAnswerB);
            // 
            // AnswerC
            // 
            this.AnswerC.Location = new System.Drawing.Point(313, 713);
            this.AnswerC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(85, 43);
            this.AnswerC.TabIndex = 4;
            this.AnswerC.Text = "C";
            this.AnswerC.UseVisualStyleBackColor = true;
            this.AnswerC.Click += new System.EventHandler(this.GiveAnswerC);
            // 
            // AnswerD
            // 
            this.AnswerD.Location = new System.Drawing.Point(948, 713);
            this.AnswerD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(85, 44);
            this.AnswerD.TabIndex = 5;
            this.AnswerD.Text = "D";
            this.AnswerD.UseVisualStyleBackColor = true;
            this.AnswerD.Click += new System.EventHandler(this.GiveAnswerD);
            // 
            // ModeStam
            // 
            this.ModeStam.Location = new System.Drawing.Point(16, 60);
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
            this.ModeSpelling.Location = new System.Drawing.Point(16, 114);
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
            this.TextAnswerA.Location = new System.Drawing.Point(483, 437);
            this.TextAnswerA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextAnswerA.Name = "TextAnswerA";
            this.TextAnswerA.Size = new System.Drawing.Size(46, 17);
            this.TextAnswerA.TabIndex = 8;
            this.TextAnswerA.Text = "label1";
            // 
            // TextAnswerB
            // 
            this.TextAnswerB.AutoSize = true;
            this.TextAnswerB.Location = new System.Drawing.Point(1156, 464);
            this.TextAnswerB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextAnswerB.Name = "TextAnswerB";
            this.TextAnswerB.Size = new System.Drawing.Size(46, 17);
            this.TextAnswerB.TabIndex = 9;
            this.TextAnswerB.Text = "label2";
            // 
            // TextAnswerC
            // 
            this.TextAnswerC.AutoSize = true;
            this.TextAnswerC.Location = new System.Drawing.Point(483, 819);
            this.TextAnswerC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextAnswerC.Name = "TextAnswerC";
            this.TextAnswerC.Size = new System.Drawing.Size(46, 17);
            this.TextAnswerC.TabIndex = 10;
            this.TextAnswerC.Text = "label3";
            // 
            // TextAnswerD
            // 
            this.TextAnswerD.AutoSize = true;
            this.TextAnswerD.Location = new System.Drawing.Point(1156, 829);
            this.TextAnswerD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextAnswerD.Name = "TextAnswerD";
            this.TextAnswerD.Size = new System.Drawing.Size(46, 17);
            this.TextAnswerD.TabIndex = 11;
            this.TextAnswerD.Text = "label4";
            // 
            // CheckSignal
            // 
            this.CheckSignal.Interval = 1000;
            this.CheckSignal.Tick += new System.EventHandler(this.CheckSignal_Tick);
            // 
            // ModeSubject
            // 
            this.ModeSubject.Location = new System.Drawing.Point(16, 168);
            this.ModeSubject.Name = "ModeSubject";
            this.ModeSubject.Size = new System.Drawing.Size(92, 47);
            this.ModeSubject.TabIndex = 13;
            this.ModeSubject.Text = "Subject";
            this.ModeSubject.UseVisualStyleBackColor = true;
            this.ModeSubject.Click += new System.EventHandler(this.ChangeToSubject);
            // 
            // StartTest
            // 
            this.StartTest.Location = new System.Drawing.Point(16, 283);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(92, 47);
            this.StartTest.TabIndex = 14;
            this.StartTest.Text = "Start Test";
            this.StartTest.UseVisualStyleBackColor = true;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // Taalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1880, 1013);
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
            this.Controls.Add(this.Score);
            this.Controls.Add(this.CurrentQuestion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Taalform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentQuestion;
        private System.Windows.Forms.Label Score;
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
    }
}

