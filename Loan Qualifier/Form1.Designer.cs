namespace Loan_Qualifier
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
            this.salaryPromptLabel = new System.Windows.Forms.Label();
            this.yearsPromptLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.decisionLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryPromptLabel
            // 
            this.salaryPromptLabel.AutoSize = true;
            this.salaryPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryPromptLabel.Location = new System.Drawing.Point(98, 61);
            this.salaryPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salaryPromptLabel.Name = "salaryPromptLabel";
            this.salaryPromptLabel.Size = new System.Drawing.Size(115, 20);
            this.salaryPromptLabel.TabIndex = 0;
            this.salaryPromptLabel.Text = "Annual salary:";
            // 
            // yearsPromptLabel
            // 
            this.yearsPromptLabel.AutoSize = true;
            this.yearsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsPromptLabel.Location = new System.Drawing.Point(98, 114);
            this.yearsPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearsPromptLabel.Name = "yearsPromptLabel";
            this.yearsPromptLabel.Size = new System.Drawing.Size(161, 20);
            this.yearsPromptLabel.TabIndex = 1;
            this.yearsPromptLabel.Text = "Years at current job:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(324, 59);
            this.salaryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(214, 22);
            this.salaryTextBox.TabIndex = 2;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(324, 114);
            this.yearsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(214, 22);
            this.yearsTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(98, 165);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(118, 20);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "Loan decision:";
            // 
            // decisionLabel
            // 
            this.decisionLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.decisionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decisionLabel.Location = new System.Drawing.Point(101, 226);
            this.decisionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(437, 38);
            this.decisionLabel.TabIndex = 5;
            this.decisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkButton.ForeColor = System.Drawing.Color.White;
            this.checkButton.Location = new System.Drawing.Point(101, 304);
            this.checkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(109, 43);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Check Qualifications";
            this.checkButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(261, 304);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(109, 43);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(429, 304);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 43);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 381);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.yearsPromptLabel);
            this.Controls.Add(this.salaryPromptLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Loan Qualifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salaryPromptLabel;
        private System.Windows.Forms.Label yearsPromptLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label decisionLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

