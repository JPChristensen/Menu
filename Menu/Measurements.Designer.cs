namespace Menu
{
    partial class Measurements
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
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "Inch",
            "Foot",
            "Yard",
            "Mile"});
            this.cbFrom.Location = new System.Drawing.Point(32, 39);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(98, 28);
            this.cbFrom.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTo);
            this.groupBox2.Location = new System.Drawing.Point(262, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 85);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "Inch",
            "Foot",
            "Yard",
            "Mile"});
            this.cbTo.Location = new System.Drawing.Point(32, 39);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(98, 28);
            this.cbTo.TabIndex = 0;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.outputLabel.Location = new System.Drawing.Point(258, 188);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(170, 26);
            this.outputLabel.TabIndex = 4;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(142, 272);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(166, 57);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(12, 188);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(186, 26);
            this.tbValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter a number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result";
            // 
            // Measurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Measurements";
            this.Text = "Measurements";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}