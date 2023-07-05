namespace assignment1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewDisplay = new System.Windows.Forms.Button();
            this.btnNextStation = new System.Windows.Forms.Button();
            this.btnNewJDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewDisplay
            // 
            this.btnNewDisplay.Location = new System.Drawing.Point(12, 212);
            this.btnNewDisplay.Name = "btnNewDisplay";
            this.btnNewDisplay.Size = new System.Drawing.Size(112, 23);
            this.btnNewDisplay.TabIndex = 0;
            this.btnNewDisplay.Text = "New Display";
            this.btnNewDisplay.UseVisualStyleBackColor = true;
            this.btnNewDisplay.Click += new System.EventHandler(this.btnNewDisplay_Click);
            // 
            // btnNextStation
            // 
            this.btnNextStation.Location = new System.Drawing.Point(110, 55);
            this.btnNextStation.Name = "btnNextStation";
            this.btnNextStation.Size = new System.Drawing.Size(143, 56);
            this.btnNextStation.TabIndex = 1;
            this.btnNextStation.Text = "Next Station";
            this.btnNextStation.UseVisualStyleBackColor = true;
            this.btnNextStation.Click += new System.EventHandler(this.btnNextStation_Click);
            // 
            // btnNewJDisplay
            // 
            this.btnNewJDisplay.Location = new System.Drawing.Point(130, 212);
            this.btnNewJDisplay.Name = "btnNewJDisplay";
            this.btnNewJDisplay.Size = new System.Drawing.Size(112, 23);
            this.btnNewJDisplay.TabIndex = 2;
            this.btnNewJDisplay.Text = "New Journey Display";
            this.btnNewJDisplay.UseVisualStyleBackColor = true;
            this.btnNewJDisplay.Click += new System.EventHandler(this.btnNewJDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 247);
            this.Controls.Add(this.btnNewJDisplay);
            this.Controls.Add(this.btnNextStation);
            this.Controls.Add(this.btnNewDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewDisplay;
        private System.Windows.Forms.Button btnNextStation;
        private System.Windows.Forms.Button btnNewJDisplay;
    }
}
