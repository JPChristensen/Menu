namespace Menu
{
    partial class MenuForm
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
            this.buttonMath = new System.Windows.Forms.Button();
            this.buttonMeasure = new System.Windows.Forms.Button();
            this.buttonProgram = new System.Windows.Forms.Button();
            this.buttonTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMath
            // 
            this.buttonMath.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMath.Location = new System.Drawing.Point(12, 25);
            this.buttonMath.Name = "buttonMath";
            this.buttonMath.Size = new System.Drawing.Size(224, 79);
            this.buttonMath.TabIndex = 1;
            this.buttonMath.Text = "Basic Math Calculator";
            this.buttonMath.UseVisualStyleBackColor = true;
            this.buttonMath.Click += new System.EventHandler(this.Button_BasicMath);
            // 
            // buttonMeasure
            // 
            this.buttonMeasure.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeasure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMeasure.Location = new System.Drawing.Point(304, 25);
            this.buttonMeasure.Name = "buttonMeasure";
            this.buttonMeasure.Size = new System.Drawing.Size(224, 79);
            this.buttonMeasure.TabIndex = 2;
            this.buttonMeasure.Text = "Convert Measurements";
            this.buttonMeasure.UseVisualStyleBackColor = true;
            this.buttonMeasure.Click += new System.EventHandler(this.Button_Measure);
            // 
            // buttonProgram
            // 
            this.buttonProgram.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProgram.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonProgram.Location = new System.Drawing.Point(304, 145);
            this.buttonProgram.Name = "buttonProgram";
            this.buttonProgram.Size = new System.Drawing.Size(224, 78);
            this.buttonProgram.TabIndex = 5;
            this.buttonProgram.Text = "Programming Calculator";
            this.buttonProgram.UseVisualStyleBackColor = true;
            this.buttonProgram.Click += new System.EventHandler(this.Button_Program);
            // 
            // buttonTime
            // 
            this.buttonTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTime.Location = new System.Drawing.Point(12, 145);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(224, 78);
            this.buttonTime.TabIndex = 4;
            this.buttonTime.Text = "Time Difference";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.Click += new System.EventHandler(this.Button_Time);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(540, 251);
            this.Controls.Add(this.buttonProgram);
            this.Controls.Add(this.buttonTime);
            this.Controls.Add(this.buttonMeasure);
            this.Controls.Add(this.buttonMath);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMath;
        private System.Windows.Forms.Button buttonMeasure;
        private System.Windows.Forms.Button buttonProgram;
        private System.Windows.Forms.Button buttonTime;
    }
}

