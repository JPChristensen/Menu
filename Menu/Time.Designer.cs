namespace Menu
{
    partial class Time
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
            this.enterButton = new System.Windows.Forms.Button();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(33, 190);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(130, 49);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.Button_Enter);
            // 
            // labelFrom
            // 
            this.labelFrom.Location = new System.Drawing.Point(29, 31);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(134, 23);
            this.labelFrom.TabIndex = 3;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.Location = new System.Drawing.Point(206, 31);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(134, 23);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "To";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(33, 69);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(130, 26);
            this.tbFrom.TabIndex = 5;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(210, 69);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(130, 26);
            this.tbTo.TabIndex = 6;
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelResult.Location = new System.Drawing.Point(29, 129);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(134, 23);
            this.labelResult.TabIndex = 7;
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 261);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.enterButton);
            this.Name = "Time";
            this.Text = "Time";
            this.Load += new System.EventHandler(this.Time_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label labelResult;
    }
}