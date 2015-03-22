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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 453);
            this.Controls.Add(this.labelWordOfChoice);
            this.Controls.Add(this.comboBoxWordsOfChoice);
            this.Name = "MainForm";
            this.Text = "Shit3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWordsOfChoice;
        private System.Windows.Forms.Label labelWordOfChoice;
    }
}

