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
            this.CurrentQuestion = new System.Windows.Forms.Label();
            this.ResultAnswer = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // CurrentQuestion
            // 
            this.CurrentQuestion.AutoSize = true;
            this.CurrentQuestion.Location = new System.Drawing.Point(196, 54);
            this.CurrentQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentQuestion.Name = "CurrentQuestion";
            this.CurrentQuestion.Size = new System.Drawing.Size(96, 15);
            this.CurrentQuestion.TabIndex = 0;
            this.CurrentQuestion.Text = "CurrentQuestion";
            // 
            // ResultAnswer
            // 
            this.ResultAnswer.AutoSize = true;
            this.ResultAnswer.Location = new System.Drawing.Point(375, 137);
            this.ResultAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultAnswer.Name = "ResultAnswer";
            this.ResultAnswer.Size = new System.Drawing.Size(55, 15);
            this.ResultAnswer.TabIndex = 1;
            this.ResultAnswer.Text = "Punten : ";
            // 
            // AnswerA
            // 
            this.AnswerA.Location = new System.Drawing.Point(174, 71);
            this.AnswerA.Margin = new System.Windows.Forms.Padding(2);
            this.AnswerA.Name = "AnswerA";
            this.AnswerA.Size = new System.Drawing.Size(64, 44);
            this.AnswerA.TabIndex = 2;
            this.AnswerA.Text = "A";
            this.AnswerA.UseVisualStyleBackColor = true;
            this.AnswerA.Click += new System.EventHandler(this.GiveAnswerA);
            // 
            // AnswerB
            // 
            this.AnswerB.Location = new System.Drawing.Point(174, 119);
            this.AnswerB.Margin = new System.Windows.Forms.Padding(2);
            this.AnswerB.Name = "AnswerB";
            this.AnswerB.Size = new System.Drawing.Size(64, 37);
            this.AnswerB.TabIndex = 3;
            this.AnswerB.Text = "B";
            this.AnswerB.UseVisualStyleBackColor = true;
            this.AnswerB.Click += new System.EventHandler(this.GiveAnswerB);
            // 
            // AnswerC
            // 
            this.AnswerC.Location = new System.Drawing.Point(174, 161);
            this.AnswerC.Margin = new System.Windows.Forms.Padding(2);
            this.AnswerC.Name = "AnswerC";
            this.AnswerC.Size = new System.Drawing.Size(64, 35);
            this.AnswerC.TabIndex = 4;
            this.AnswerC.Text = "C";
            this.AnswerC.UseVisualStyleBackColor = true;
            this.AnswerC.Click += new System.EventHandler(this.GiveAnswerC);
            // 
            // AnswerD
            // 
            this.AnswerD.Location = new System.Drawing.Point(174, 201);
            this.AnswerD.Margin = new System.Windows.Forms.Padding(2);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(64, 36);
            this.AnswerD.TabIndex = 5;
            this.AnswerD.Text = "D";
            this.AnswerD.UseVisualStyleBackColor = true;
            this.AnswerD.Click += new System.EventHandler(this.GiveAnswerD);
            // 
            // ModeStam
            // 
            this.ModeStam.Location = new System.Drawing.Point(12, 49);
            this.ModeStam.Name = "ModeStam";
            this.ModeStam.Size = new System.Drawing.Size(69, 38);
            this.ModeStam.TabIndex = 6;
            this.ModeStam.Text = "Stam";
            this.ModeStam.UseVisualStyleBackColor = true;
            this.ModeStam.Click += new System.EventHandler(this.ChangeToStam);
            // 
            // ModeSpelling
            // 
            this.ModeSpelling.Location = new System.Drawing.Point(12, 93);
            this.ModeSpelling.Name = "ModeSpelling";
            this.ModeSpelling.Size = new System.Drawing.Size(69, 38);
            this.ModeSpelling.TabIndex = 7;
            this.ModeSpelling.Text = "Spelling";
            this.ModeSpelling.UseVisualStyleBackColor = true;
            this.ModeSpelling.Click += new System.EventHandler(this.ChangeToSpelling);
            // 
            // TextAnswerA
            // 
            this.TextAnswerA.AutoSize = true;
            this.TextAnswerA.Location = new System.Drawing.Point(264, 87);
            this.TextAnswerA.Name = "TextAnswerA";
            this.TextAnswerA.Size = new System.Drawing.Size(41, 15);
            this.TextAnswerA.TabIndex = 8;
            this.TextAnswerA.Text = "label1";
            // 
            // TextAnswerB
            // 
            this.TextAnswerB.AutoSize = true;
            this.TextAnswerB.Location = new System.Drawing.Point(264, 131);
            this.TextAnswerB.Name = "TextAnswerB";
            this.TextAnswerB.Size = new System.Drawing.Size(41, 15);
            this.TextAnswerB.TabIndex = 9;
            this.TextAnswerB.Text = "label2";
            // 
            // TextAnswerC
            // 
            this.TextAnswerC.AutoSize = true;
            this.TextAnswerC.Location = new System.Drawing.Point(264, 172);
            this.TextAnswerC.Name = "TextAnswerC";
            this.TextAnswerC.Size = new System.Drawing.Size(41, 15);
            this.TextAnswerC.TabIndex = 10;
            this.TextAnswerC.Text = "label3";
            // 
            // TextAnswerD
            // 
            this.TextAnswerD.AutoSize = true;
            this.TextAnswerD.Location = new System.Drawing.Point(264, 213);
            this.TextAnswerD.Name = "TextAnswerD";
            this.TextAnswerD.Size = new System.Drawing.Size(41, 15);
            this.TextAnswerD.TabIndex = 11;
            this.TextAnswerD.Text = "label4";
            // 
            // Taalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Controls.Add(this.ResultAnswer);
            this.Controls.Add(this.CurrentQuestion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Taalform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Taalform_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentQuestion;
        private System.Windows.Forms.Label ResultAnswer;
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
    }
}

