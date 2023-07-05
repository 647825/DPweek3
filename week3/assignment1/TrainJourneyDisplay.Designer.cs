namespace assignment1
{
    partial class TrainJourneyDisplay
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
            this.lstBoxStations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBoxStations
            // 
            this.lstBoxStations.FormattingEnabled = true;
            this.lstBoxStations.ItemHeight = 15;
            this.lstBoxStations.Location = new System.Drawing.Point(12, 12);
            this.lstBoxStations.Name = "lstBoxStations";
            this.lstBoxStations.Size = new System.Drawing.Size(310, 79);
            this.lstBoxStations.TabIndex = 0;
            // 
            // TrainJourneyDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.lstBoxStations);
            this.Name = "TrainJourneyDisplay";
            this.Text = "TrainJourneyDisplay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrainJourneyDisplay_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxStations;
    }
}