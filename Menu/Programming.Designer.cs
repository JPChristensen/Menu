namespace Menu
{
    partial class Programming
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
            this.hexResultLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.hexCheckBox = new System.Windows.Forms.CheckBox();
            this.octalResultLabel = new System.Windows.Forms.Label();
            this.octalLabel = new System.Windows.Forms.Label();
            this.octalCheckBox = new System.Windows.Forms.CheckBox();
            this.binaryResultLabel = new System.Windows.Forms.Label();
            this.binaryLabel = new System.Windows.Forms.Label();
            this.binaryCheckBox = new System.Windows.Forms.CheckBox();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.userInputLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.convertGroupBox = new System.Windows.Forms.GroupBox();
            this.resultGBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // hexResultLabel
            // 
            this.hexResultLabel.BackColor = System.Drawing.SystemColors.Info;
            this.hexResultLabel.Location = new System.Drawing.Point(183, 496);
            this.hexResultLabel.Name = "hexResultLabel";
            this.hexResultLabel.Size = new System.Drawing.Size(155, 35);
            this.hexResultLabel.TabIndex = 25;
            this.hexResultLabel.Visible = false;
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(91, 496);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(37, 20);
            this.hexLabel.TabIndex = 24;
            this.hexLabel.Text = "Hex";
            // 
            // hexCheckBox
            // 
            this.hexCheckBox.AutoSize = true;
            this.hexCheckBox.Location = new System.Drawing.Point(130, 242);
            this.hexCheckBox.Name = "hexCheckBox";
            this.hexCheckBox.Size = new System.Drawing.Size(126, 24);
            this.hexCheckBox.TabIndex = 23;
            this.hexCheckBox.Text = "Hexadecimal";
            this.hexCheckBox.UseVisualStyleBackColor = true;
            // 
            // octalResultLabel
            // 
            this.octalResultLabel.BackColor = System.Drawing.SystemColors.Info;
            this.octalResultLabel.Location = new System.Drawing.Point(183, 428);
            this.octalResultLabel.Name = "octalResultLabel";
            this.octalResultLabel.Size = new System.Drawing.Size(155, 35);
            this.octalResultLabel.TabIndex = 22;
            this.octalResultLabel.Visible = false;
            // 
            // octalLabel
            // 
            this.octalLabel.AutoSize = true;
            this.octalLabel.Location = new System.Drawing.Point(87, 428);
            this.octalLabel.Name = "octalLabel";
            this.octalLabel.Size = new System.Drawing.Size(46, 20);
            this.octalLabel.TabIndex = 21;
            this.octalLabel.Text = "Octal";
            // 
            // octalCheckBox
            // 
            this.octalCheckBox.AutoSize = true;
            this.octalCheckBox.Location = new System.Drawing.Point(130, 194);
            this.octalCheckBox.Name = "octalCheckBox";
            this.octalCheckBox.Size = new System.Drawing.Size(72, 24);
            this.octalCheckBox.TabIndex = 20;
            this.octalCheckBox.Text = "Octal";
            this.octalCheckBox.UseVisualStyleBackColor = true;
            // 
            // binaryResultLabel
            // 
            this.binaryResultLabel.BackColor = System.Drawing.SystemColors.Info;
            this.binaryResultLabel.Location = new System.Drawing.Point(183, 364);
            this.binaryResultLabel.Name = "binaryResultLabel";
            this.binaryResultLabel.Size = new System.Drawing.Size(155, 35);
            this.binaryResultLabel.TabIndex = 19;
            this.binaryResultLabel.Visible = false;
            // 
            // binaryLabel
            // 
            this.binaryLabel.AutoSize = true;
            this.binaryLabel.Location = new System.Drawing.Point(87, 364);
            this.binaryLabel.Name = "binaryLabel";
            this.binaryLabel.Size = new System.Drawing.Size(53, 20);
            this.binaryLabel.TabIndex = 18;
            this.binaryLabel.Text = "Binary";
            // 
            // binaryCheckBox
            // 
            this.binaryCheckBox.AutoSize = true;
            this.binaryCheckBox.Location = new System.Drawing.Point(130, 143);
            this.binaryCheckBox.Name = "binaryCheckBox";
            this.binaryCheckBox.Size = new System.Drawing.Size(79, 24);
            this.binaryCheckBox.TabIndex = 17;
            this.binaryCheckBox.Text = "Binary";
            this.binaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(206, 29);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(154, 26);
            this.userInputTextBox.TabIndex = 16;
            // 
            // userInputLabel
            // 
            this.userInputLabel.AutoSize = true;
            this.userInputLabel.Location = new System.Drawing.Point(68, 29);
            this.userInputLabel.Name = "userInputLabel";
            this.userInputLabel.Size = new System.Drawing.Size(123, 20);
            this.userInputLabel.TabIndex = 15;
            this.userInputLabel.Text = "Enter a number:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(158, 592);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(111, 47);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // convertGroupBox
            // 
            this.convertGroupBox.Location = new System.Drawing.Point(72, 101);
            this.convertGroupBox.Name = "convertGroupBox";
            this.convertGroupBox.Size = new System.Drawing.Size(288, 198);
            this.convertGroupBox.TabIndex = 26;
            this.convertGroupBox.TabStop = false;
            this.convertGroupBox.Text = "Convert To";
            // 
            // resultGBox
            // 
            this.resultGBox.Location = new System.Drawing.Point(72, 325);
            this.resultGBox.Name = "resultGBox";
            this.resultGBox.Size = new System.Drawing.Size(288, 237);
            this.resultGBox.TabIndex = 27;
            this.resultGBox.TabStop = false;
            this.resultGBox.Text = "Results";
            // 
            // Programming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 669);
            this.Controls.Add(this.hexResultLabel);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.hexCheckBox);
            this.Controls.Add(this.octalResultLabel);
            this.Controls.Add(this.octalLabel);
            this.Controls.Add(this.octalCheckBox);
            this.Controls.Add(this.binaryResultLabel);
            this.Controls.Add(this.binaryLabel);
            this.Controls.Add(this.binaryCheckBox);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.userInputLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.convertGroupBox);
            this.Controls.Add(this.resultGBox);
            this.Name = "Programming";
            this.Text = "Programming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hexResultLabel;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.CheckBox hexCheckBox;
        private System.Windows.Forms.Label octalResultLabel;
        private System.Windows.Forms.Label octalLabel;
        private System.Windows.Forms.CheckBox octalCheckBox;
        private System.Windows.Forms.Label binaryResultLabel;
        private System.Windows.Forms.Label binaryLabel;
        private System.Windows.Forms.CheckBox binaryCheckBox;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Label userInputLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox convertGroupBox;
        private System.Windows.Forms.GroupBox resultGBox;
    }
}