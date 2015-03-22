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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeLimitInSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxWordsOfChoice
            // 
            this.comboBoxWordsOfChoice.FormattingEnabled = true;
            this.comboBoxWordsOfChoice.Location = new System.Drawing.Point(149, 42);
            this.comboBoxWordsOfChoice.Name = "comboBoxWordsOfChoice";
            this.comboBoxWordsOfChoice.Size = new System.Drawing.Size(223, 24);
            this.comboBoxWordsOfChoice.TabIndex = 0;
            // 
            // labelWordOfChoice
            // 
            this.labelWordOfChoice.AutoSize = true;
            this.labelWordOfChoice.Location = new System.Drawing.Point(36, 45);
            this.labelWordOfChoice.Name = "labelWordOfChoice";
            this.labelWordOfChoice.Size = new System.Drawing.Size(107, 17);
            this.labelWordOfChoice.TabIndex = 1;
            this.labelWordOfChoice.Text = "Word of choice:";
            // 
            // labelTimeLimitInSeconds
            // 
            this.labelTimeLimitInSeconds.AutoSize = true;
            this.labelTimeLimitInSeconds.Location = new System.Drawing.Point(492, 45);
            this.labelTimeLimitInSeconds.Name = "labelTimeLimitInSeconds";
            this.labelTimeLimitInSeconds.Size = new System.Drawing.Size(138, 17);
            this.labelTimeLimitInSeconds.TabIndex = 30;
            this.labelTimeLimitInSeconds.Text = "Time limit (seconds):";
            // 
            // numericUpDownTimeLimitInSeconds
            // 
            this.numericUpDownTimeLimitInSeconds.Location = new System.Drawing.Point(639, 43);
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
            this.numericUpDownTimeLimitInSeconds.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTimeLimitInSeconds.TabIndex = 29;
            this.numericUpDownTimeLimitInSeconds.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // buttonNewChallenge
            // 
            this.buttonNewChallenge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewChallenge.Location = new System.Drawing.Point(39, 86);
            this.buttonNewChallenge.Name = "buttonNewChallenge";
            this.buttonNewChallenge.Size = new System.Drawing.Size(719, 33);
            this.buttonNewChallenge.TabIndex = 31;
            this.buttonNewChallenge.Text = "New challenge!";
            this.buttonNewChallenge.UseVisualStyleBackColor = true;
            // 
            // labelGameBoard
            // 
            this.labelGameBoard.AutoSize = true;
            this.labelGameBoard.Location = new System.Drawing.Point(347, 146);
            this.labelGameBoard.Name = "labelGameBoard";
            this.labelGameBoard.Size = new System.Drawing.Size(105, 17);
            this.labelGameBoard.TabIndex = 33;
            this.labelGameBoard.Text = "GAME BOARD:";
            // 
            // textBoxGameBoard
            // 
            this.textBoxGameBoard.BackColor = System.Drawing.Color.White;
            this.textBoxGameBoard.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGameBoard.Location = new System.Drawing.Point(201, 176);
            this.textBoxGameBoard.Multiline = true;
            this.textBoxGameBoard.Name = "textBoxGameBoard";
            this.textBoxGameBoard.ReadOnly = true;
            this.textBoxGameBoard.Size = new System.Drawing.Size(400, 400);
            this.textBoxGameBoard.TabIndex = 32;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.labelGameBoard);
            this.Controls.Add(this.textBoxGameBoard);
            this.Controls.Add(this.buttonNewChallenge);
            this.Controls.Add(this.labelTimeLimitInSeconds);
            this.Controls.Add(this.numericUpDownTimeLimitInSeconds);
            this.Controls.Add(this.labelWordOfChoice);
            this.Controls.Add(this.comboBoxWordsOfChoice);
            this.Name = "MainForm";
            this.Text = "Shit3";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeLimitInSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWordsOfChoice;
        private System.Windows.Forms.Label labelWordOfChoice;
        private System.Windows.Forms.Label labelTimeLimitInSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeLimitInSeconds;
        private System.Windows.Forms.Button buttonNewChallenge;
        private System.Windows.Forms.Label labelGameBoard;
        private System.Windows.Forms.TextBox textBoxGameBoard;
    }
}

