namespace Shit3
{
    partial class MainForm
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
            this.comboBoxWordsOfChoice = new System.Windows.Forms.ComboBox();
            this.labelWordOfChoice = new System.Windows.Forms.Label();
            this.labelTimeLimitInSeconds = new System.Windows.Forms.Label();
            this.numericUpDownTimeLimitInSeconds = new System.Windows.Forms.NumericUpDown();
            this.buttonNewChallenge = new System.Windows.Forms.Button();
            this.labelGameBoard = new System.Windows.Forms.Label();
            this.textBoxGameBoard = new System.Windows.Forms.TextBox();
            this.buttonRescramble = new System.Windows.Forms.Button();
            this.labelSecondsLeft = new System.Windows.Forms.Label();
            this.textBoxSecondsLeft = new System.Windows.Forms.TextBox();
            this.buttonSubmitSolution = new System.Windows.Forms.Button();
            this.textBoxUserCode = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonGiveUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelObfuscatedSentence = new System.Windows.Forms.Label();
            this.textBoxObfuscatedSentence = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelKeyword = new System.Windows.Forms.Label();
            this.labelOriginalSentence = new System.Windows.Forms.Label();
            this.textBoxHostSentence = new System.Windows.Forms.TextBox();
            this.groupBoxNewChallenge = new System.Windows.Forms.GroupBox();
            this.labelMinimumLegLength = new System.Windows.Forms.Label();
            this.numericUpDownMinLegLength = new System.Windows.Forms.NumericUpDown();
            this.labelMaxLegLength = new System.Windows.Forms.Label();
            this.numericUpDownMaxLegLength = new System.Windows.Forms.NumericUpDown();
            this.groupBoxGameControls = new System.Windows.Forms.GroupBox();
            this.groupBoxSolution = new System.Windows.Forms.GroupBox();
            this.labelNormalizedSentence = new System.Windows.Forms.Label();
            this.textBoxNormalizedSentence = new System.Windows.Forms.TextBox();
            this.groupBoxGameBoard = new System.Windows.Forms.GroupBox();
            this.groupBoxGameResult = new System.Windows.Forms.GroupBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.labelScoreEvaluation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeLimitInSeconds)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxNewChallenge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinLegLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxLegLength)).BeginInit();
            this.groupBoxGameControls.SuspendLayout();
            this.groupBoxSolution.SuspendLayout();
            this.groupBoxGameBoard.SuspendLayout();
            this.groupBoxGameResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxWordsOfChoice
            // 
            this.comboBoxWordsOfChoice.FormattingEnabled = true;
            this.comboBoxWordsOfChoice.Location = new System.Drawing.Point(310, 25);
            this.comboBoxWordsOfChoice.Name = "comboBoxWordsOfChoice";
            this.comboBoxWordsOfChoice.Size = new System.Drawing.Size(100, 24);
            this.comboBoxWordsOfChoice.TabIndex = 0;
            // 
            // labelWordOfChoice
            // 
            this.labelWordOfChoice.AutoSize = true;
            this.labelWordOfChoice.Location = new System.Drawing.Point(195, 28);
            this.labelWordOfChoice.Name = "labelWordOfChoice";
            this.labelWordOfChoice.Size = new System.Drawing.Size(107, 17);
            this.labelWordOfChoice.TabIndex = 1;
            this.labelWordOfChoice.Text = "Word of choice:";
            // 
            // labelTimeLimitInSeconds
            // 
            this.labelTimeLimitInSeconds.AutoSize = true;
            this.labelTimeLimitInSeconds.Location = new System.Drawing.Point(164, 61);
            this.labelTimeLimitInSeconds.Name = "labelTimeLimitInSeconds";
            this.labelTimeLimitInSeconds.Size = new System.Drawing.Size(138, 17);
            this.labelTimeLimitInSeconds.TabIndex = 30;
            this.labelTimeLimitInSeconds.Text = "Time limit (seconds):";
            // 
            // numericUpDownTimeLimitInSeconds
            // 
            this.numericUpDownTimeLimitInSeconds.Location = new System.Drawing.Point(310, 59);
            this.numericUpDownTimeLimitInSeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTimeLimitInSeconds.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTimeLimitInSeconds.Name = "numericUpDownTimeLimitInSeconds";
            this.numericUpDownTimeLimitInSeconds.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownTimeLimitInSeconds.TabIndex = 29;
            this.numericUpDownTimeLimitInSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTimeLimitInSeconds.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // buttonNewChallenge
            // 
            this.buttonNewChallenge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewChallenge.Location = new System.Drawing.Point(16, 158);
            this.buttonNewChallenge.Name = "buttonNewChallenge";
            this.buttonNewChallenge.Size = new System.Drawing.Size(394, 62);
            this.buttonNewChallenge.TabIndex = 31;
            this.buttonNewChallenge.Text = "New challenge!";
            this.buttonNewChallenge.UseVisualStyleBackColor = true;
            this.buttonNewChallenge.Click += new System.EventHandler(this.buttonNewChallenge_Click);
            // 
            // labelGameBoard
            // 
            this.labelGameBoard.AutoSize = true;
            this.labelGameBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameBoard.ForeColor = System.Drawing.Color.Red;
            this.labelGameBoard.Location = new System.Drawing.Point(170, 26);
            this.labelGameBoard.Name = "labelGameBoard";
            this.labelGameBoard.Size = new System.Drawing.Size(113, 18);
            this.labelGameBoard.TabIndex = 33;
            this.labelGameBoard.Text = "GAME BOARD:";
            // 
            // textBoxGameBoard
            // 
            this.textBoxGameBoard.BackColor = System.Drawing.Color.White;
            this.textBoxGameBoard.Font = new System.Drawing.Font("Consolas", 13F);
            this.textBoxGameBoard.Location = new System.Drawing.Point(18, 49);
            this.textBoxGameBoard.Multiline = true;
            this.textBoxGameBoard.Name = "textBoxGameBoard";
            this.textBoxGameBoard.ReadOnly = true;
            this.textBoxGameBoard.Size = new System.Drawing.Size(400, 438);
            this.textBoxGameBoard.TabIndex = 32;
            // 
            // buttonRescramble
            // 
            this.buttonRescramble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRescramble.Enabled = false;
            this.buttonRescramble.Location = new System.Drawing.Point(16, 30);
            this.buttonRescramble.Name = "buttonRescramble";
            this.buttonRescramble.Size = new System.Drawing.Size(394, 34);
            this.buttonRescramble.TabIndex = 34;
            this.buttonRescramble.Text = "Rescramble";
            this.buttonRescramble.UseVisualStyleBackColor = true;
            this.buttonRescramble.Click += new System.EventHandler(this.buttonRescramble_Click);
            // 
            // labelSecondsLeft
            // 
            this.labelSecondsLeft.AutoSize = true;
            this.labelSecondsLeft.Location = new System.Drawing.Point(701, 32);
            this.labelSecondsLeft.Name = "labelSecondsLeft";
            this.labelSecondsLeft.Size = new System.Drawing.Size(90, 17);
            this.labelSecondsLeft.TabIndex = 36;
            this.labelSecondsLeft.Text = "Seconds left:";
            // 
            // textBoxSecondsLeft
            // 
            this.textBoxSecondsLeft.BackColor = System.Drawing.Color.White;
            this.textBoxSecondsLeft.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSecondsLeft.Location = new System.Drawing.Point(797, 22);
            this.textBoxSecondsLeft.Name = "textBoxSecondsLeft";
            this.textBoxSecondsLeft.ReadOnly = true;
            this.textBoxSecondsLeft.Size = new System.Drawing.Size(100, 33);
            this.textBoxSecondsLeft.TabIndex = 35;
            this.textBoxSecondsLeft.TabStop = false;
            this.textBoxSecondsLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSubmitSolution
            // 
            this.buttonSubmitSolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmitSolution.Enabled = false;
            this.buttonSubmitSolution.Location = new System.Drawing.Point(171, 82);
            this.buttonSubmitSolution.Name = "buttonSubmitSolution";
            this.buttonSubmitSolution.Size = new System.Drawing.Size(239, 34);
            this.buttonSubmitSolution.TabIndex = 38;
            this.buttonSubmitSolution.Text = "Submit solution!";
            this.buttonSubmitSolution.UseVisualStyleBackColor = true;
            this.buttonSubmitSolution.Click += new System.EventHandler(this.buttonSubmitSolution_Click);
            // 
            // textBoxUserCode
            // 
            this.textBoxUserCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUserCode.Enabled = false;
            this.textBoxUserCode.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserCode.Location = new System.Drawing.Point(16, 81);
            this.textBoxUserCode.MaxLength = 4;
            this.textBoxUserCode.Name = "textBoxUserCode";
            this.textBoxUserCode.Size = new System.Drawing.Size(140, 33);
            this.textBoxUserCode.TabIndex = 37;
            this.textBoxUserCode.Text = "----";
            this.textBoxUserCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Gigi", 18F);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelStatus.Location = new System.Drawing.Point(20, 16);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(230, 41);
            this.labelStatus.TabIndex = 39;
            this.labelStatus.Text = "Here is the status";
            // 
            // buttonGiveUp
            // 
            this.buttonGiveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGiveUp.Enabled = false;
            this.buttonGiveUp.Location = new System.Drawing.Point(16, 133);
            this.buttonGiveUp.Name = "buttonGiveUp";
            this.buttonGiveUp.Size = new System.Drawing.Size(394, 34);
            this.buttonGiveUp.TabIndex = 40;
            this.buttonGiveUp.Text = "Fuck it, I give up!";
            this.buttonGiveUp.UseVisualStyleBackColor = true;
            this.buttonGiveUp.Click += new System.EventHandler(this.buttonGiveUp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelSecondsLeft);
            this.panel1.Controls.Add(this.textBoxSecondsLeft);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 77);
            this.panel1.TabIndex = 41;
            // 
            // labelObfuscatedSentence
            // 
            this.labelObfuscatedSentence.AutoSize = true;
            this.labelObfuscatedSentence.Location = new System.Drawing.Point(585, 123);
            this.labelObfuscatedSentence.Name = "labelObfuscatedSentence";
            this.labelObfuscatedSentence.Size = new System.Drawing.Size(147, 17);
            this.labelObfuscatedSentence.TabIndex = 48;
            this.labelObfuscatedSentence.Text = "Obfuscated sentence:";
            // 
            // textBoxObfuscatedSentence
            // 
            this.textBoxObfuscatedSentence.BackColor = System.Drawing.Color.White;
            this.textBoxObfuscatedSentence.Location = new System.Drawing.Point(462, 152);
            this.textBoxObfuscatedSentence.Multiline = true;
            this.textBoxObfuscatedSentence.Name = "textBoxObfuscatedSentence";
            this.textBoxObfuscatedSentence.ReadOnly = true;
            this.textBoxObfuscatedSentence.Size = new System.Drawing.Size(400, 61);
            this.textBoxObfuscatedSentence.TabIndex = 47;
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.White;
            this.textBoxCode.Font = new System.Drawing.Font("Consolas", 13F);
            this.textBoxCode.ForeColor = System.Drawing.Color.Blue;
            this.textBoxCode.Location = new System.Drawing.Point(462, 52);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(400, 33);
            this.textBoxCode.TabIndex = 45;
            // 
            // labelKeyword
            // 
            this.labelKeyword.AutoSize = true;
            this.labelKeyword.Location = new System.Drawing.Point(641, 23);
            this.labelKeyword.Name = "labelKeyword";
            this.labelKeyword.Size = new System.Drawing.Size(45, 17);
            this.labelKeyword.TabIndex = 44;
            this.labelKeyword.Text = "Code:";
            // 
            // labelOriginalSentence
            // 
            this.labelOriginalSentence.AutoSize = true;
            this.labelOriginalSentence.Location = new System.Drawing.Point(159, 23);
            this.labelOriginalSentence.Name = "labelOriginalSentence";
            this.labelOriginalSentence.Size = new System.Drawing.Size(123, 17);
            this.labelOriginalSentence.TabIndex = 43;
            this.labelOriginalSentence.Text = "Original sentence:";
            // 
            // textBoxHostSentence
            // 
            this.textBoxHostSentence.BackColor = System.Drawing.Color.White;
            this.textBoxHostSentence.Location = new System.Drawing.Point(16, 52);
            this.textBoxHostSentence.Multiline = true;
            this.textBoxHostSentence.Name = "textBoxHostSentence";
            this.textBoxHostSentence.ReadOnly = true;
            this.textBoxHostSentence.Size = new System.Drawing.Size(400, 61);
            this.textBoxHostSentence.TabIndex = 42;
            // 
            // groupBoxNewChallenge
            // 
            this.groupBoxNewChallenge.Controls.Add(this.labelMinimumLegLength);
            this.groupBoxNewChallenge.Controls.Add(this.numericUpDownMinLegLength);
            this.groupBoxNewChallenge.Controls.Add(this.labelMaxLegLength);
            this.groupBoxNewChallenge.Controls.Add(this.numericUpDownMaxLegLength);
            this.groupBoxNewChallenge.Controls.Add(this.buttonNewChallenge);
            this.groupBoxNewChallenge.Controls.Add(this.comboBoxWordsOfChoice);
            this.groupBoxNewChallenge.Controls.Add(this.labelWordOfChoice);
            this.groupBoxNewChallenge.Controls.Add(this.numericUpDownTimeLimitInSeconds);
            this.groupBoxNewChallenge.Controls.Add(this.labelTimeLimitInSeconds);
            this.groupBoxNewChallenge.Location = new System.Drawing.Point(17, 83);
            this.groupBoxNewChallenge.Name = "groupBoxNewChallenge";
            this.groupBoxNewChallenge.Size = new System.Drawing.Size(426, 237);
            this.groupBoxNewChallenge.TabIndex = 49;
            this.groupBoxNewChallenge.TabStop = false;
            this.groupBoxNewChallenge.Text = "Game parameters";
            // 
            // labelMinimumLegLength
            // 
            this.labelMinimumLegLength.AutoSize = true;
            this.labelMinimumLegLength.Location = new System.Drawing.Point(169, 92);
            this.labelMinimumLegLength.Name = "labelMinimumLegLength";
            this.labelMinimumLegLength.Size = new System.Drawing.Size(133, 17);
            this.labelMinimumLegLength.TabIndex = 35;
            this.labelMinimumLegLength.Text = "Minimum leg length:";
            // 
            // numericUpDownMinLegLength
            // 
            this.numericUpDownMinLegLength.Location = new System.Drawing.Point(310, 90);
            this.numericUpDownMinLegLength.Name = "numericUpDownMinLegLength";
            this.numericUpDownMinLegLength.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownMinLegLength.TabIndex = 34;
            this.numericUpDownMinLegLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMinLegLength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelMaxLegLength
            // 
            this.labelMaxLegLength.AutoSize = true;
            this.labelMaxLegLength.Location = new System.Drawing.Point(166, 123);
            this.labelMaxLegLength.Name = "labelMaxLegLength";
            this.labelMaxLegLength.Size = new System.Drawing.Size(136, 17);
            this.labelMaxLegLength.TabIndex = 33;
            this.labelMaxLegLength.Text = "Maximum leg length:";
            // 
            // numericUpDownMaxLegLength
            // 
            this.numericUpDownMaxLegLength.Location = new System.Drawing.Point(310, 121);
            this.numericUpDownMaxLegLength.Name = "numericUpDownMaxLegLength";
            this.numericUpDownMaxLegLength.Size = new System.Drawing.Size(100, 22);
            this.numericUpDownMaxLegLength.TabIndex = 32;
            this.numericUpDownMaxLegLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMaxLegLength.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // groupBoxGameControls
            // 
            this.groupBoxGameControls.Controls.Add(this.buttonRescramble);
            this.groupBoxGameControls.Controls.Add(this.textBoxUserCode);
            this.groupBoxGameControls.Controls.Add(this.buttonSubmitSolution);
            this.groupBoxGameControls.Controls.Add(this.buttonGiveUp);
            this.groupBoxGameControls.Location = new System.Drawing.Point(17, 326);
            this.groupBoxGameControls.Name = "groupBoxGameControls";
            this.groupBoxGameControls.Size = new System.Drawing.Size(426, 184);
            this.groupBoxGameControls.TabIndex = 50;
            this.groupBoxGameControls.TabStop = false;
            this.groupBoxGameControls.Text = "Game actions";
            // 
            // groupBoxSolution
            // 
            this.groupBoxSolution.Controls.Add(this.labelNormalizedSentence);
            this.groupBoxSolution.Controls.Add(this.textBoxNormalizedSentence);
            this.groupBoxSolution.Controls.Add(this.textBoxObfuscatedSentence);
            this.groupBoxSolution.Controls.Add(this.textBoxHostSentence);
            this.groupBoxSolution.Controls.Add(this.labelOriginalSentence);
            this.groupBoxSolution.Controls.Add(this.labelObfuscatedSentence);
            this.groupBoxSolution.Controls.Add(this.labelKeyword);
            this.groupBoxSolution.Controls.Add(this.textBoxCode);
            this.groupBoxSolution.Location = new System.Drawing.Point(17, 593);
            this.groupBoxSolution.Name = "groupBoxSolution";
            this.groupBoxSolution.Size = new System.Drawing.Size(880, 232);
            this.groupBoxSolution.TabIndex = 51;
            this.groupBoxSolution.TabStop = false;
            this.groupBoxSolution.Text = "Solution";
            // 
            // labelNormalizedSentence
            // 
            this.labelNormalizedSentence.AutoSize = true;
            this.labelNormalizedSentence.Location = new System.Drawing.Point(156, 123);
            this.labelNormalizedSentence.Name = "labelNormalizedSentence";
            this.labelNormalizedSentence.Size = new System.Drawing.Size(145, 17);
            this.labelNormalizedSentence.TabIndex = 50;
            this.labelNormalizedSentence.Text = "Normalized sentence:";
            // 
            // textBoxNormalizedSentence
            // 
            this.textBoxNormalizedSentence.BackColor = System.Drawing.Color.White;
            this.textBoxNormalizedSentence.Location = new System.Drawing.Point(16, 152);
            this.textBoxNormalizedSentence.Multiline = true;
            this.textBoxNormalizedSentence.Name = "textBoxNormalizedSentence";
            this.textBoxNormalizedSentence.ReadOnly = true;
            this.textBoxNormalizedSentence.Size = new System.Drawing.Size(400, 61);
            this.textBoxNormalizedSentence.TabIndex = 49;
            // 
            // groupBoxGameBoard
            // 
            this.groupBoxGameBoard.Controls.Add(this.labelGameBoard);
            this.groupBoxGameBoard.Controls.Add(this.textBoxGameBoard);
            this.groupBoxGameBoard.Location = new System.Drawing.Point(461, 83);
            this.groupBoxGameBoard.Name = "groupBoxGameBoard";
            this.groupBoxGameBoard.Size = new System.Drawing.Size(436, 504);
            this.groupBoxGameBoard.TabIndex = 52;
            this.groupBoxGameBoard.TabStop = false;
            // 
            // groupBoxGameResult
            // 
            this.groupBoxGameResult.Controls.Add(this.labelScoreEvaluation);
            this.groupBoxGameResult.Controls.Add(this.labelScore);
            this.groupBoxGameResult.Controls.Add(this.textBoxScore);
            this.groupBoxGameResult.Location = new System.Drawing.Point(17, 516);
            this.groupBoxGameResult.Name = "groupBoxGameResult";
            this.groupBoxGameResult.Size = new System.Drawing.Size(426, 71);
            this.groupBoxGameResult.TabIndex = 53;
            this.groupBoxGameResult.TabStop = false;
            this.groupBoxGameResult.Text = "Game result";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(46, 30);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(49, 17);
            this.labelScore.TabIndex = 15;
            this.labelScore.Text = "Score:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.BackColor = System.Drawing.Color.White;
            this.textBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBoxScore.Location = new System.Drawing.Point(101, 23);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.ReadOnly = true;
            this.textBoxScore.Size = new System.Drawing.Size(89, 32);
            this.textBoxScore.TabIndex = 14;
            this.textBoxScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelScoreEvaluation
            // 
            this.labelScoreEvaluation.AutoSize = true;
            this.labelScoreEvaluation.Location = new System.Drawing.Point(195, 30);
            this.labelScoreEvaluation.Name = "labelScoreEvaluation";
            this.labelScoreEvaluation.Size = new System.Drawing.Size(157, 17);
            this.labelScoreEvaluation.TabIndex = 16;
            this.labelScoreEvaluation.Text = "Evaluation of the result.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 837);
            this.Controls.Add(this.groupBoxGameResult);
            this.Controls.Add(this.groupBoxGameBoard);
            this.Controls.Add(this.groupBoxSolution);
            this.Controls.Add(this.groupBoxGameControls);
            this.Controls.Add(this.groupBoxNewChallenge);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Shit3";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeLimitInSeconds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxNewChallenge.ResumeLayout(false);
            this.groupBoxNewChallenge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinLegLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxLegLength)).EndInit();
            this.groupBoxGameControls.ResumeLayout(false);
            this.groupBoxGameControls.PerformLayout();
            this.groupBoxSolution.ResumeLayout(false);
            this.groupBoxSolution.PerformLayout();
            this.groupBoxGameBoard.ResumeLayout(false);
            this.groupBoxGameBoard.PerformLayout();
            this.groupBoxGameResult.ResumeLayout(false);
            this.groupBoxGameResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWordsOfChoice;
        private System.Windows.Forms.Label labelWordOfChoice;
        private System.Windows.Forms.Label labelTimeLimitInSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeLimitInSeconds;
        private System.Windows.Forms.Button buttonNewChallenge;
        private System.Windows.Forms.Label labelGameBoard;
        private System.Windows.Forms.TextBox textBoxGameBoard;
        private System.Windows.Forms.Button buttonRescramble;
        private System.Windows.Forms.Label labelSecondsLeft;
        private System.Windows.Forms.TextBox textBoxSecondsLeft;
        private System.Windows.Forms.Button buttonSubmitSolution;
        private System.Windows.Forms.TextBox textBoxUserCode;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonGiveUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelObfuscatedSentence;
        private System.Windows.Forms.TextBox textBoxObfuscatedSentence;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelKeyword;
        private System.Windows.Forms.Label labelOriginalSentence;
        private System.Windows.Forms.TextBox textBoxHostSentence;
        private System.Windows.Forms.GroupBox groupBoxNewChallenge;
        private System.Windows.Forms.GroupBox groupBoxGameControls;
        private System.Windows.Forms.GroupBox groupBoxSolution;
        private System.Windows.Forms.GroupBox groupBoxGameBoard;
        private System.Windows.Forms.Label labelNormalizedSentence;
        private System.Windows.Forms.TextBox textBoxNormalizedSentence;
        private System.Windows.Forms.Label labelMinimumLegLength;
        private System.Windows.Forms.NumericUpDown numericUpDownMinLegLength;
        private System.Windows.Forms.Label labelMaxLegLength;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxLegLength;
        private System.Windows.Forms.GroupBox groupBoxGameResult;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label labelScoreEvaluation;
    }
}

