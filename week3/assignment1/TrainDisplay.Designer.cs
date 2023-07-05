namespace assignment1
{
    partial class TrainDisplay
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
            this.lbltStation = new System.Windows.Forms.Label();
            this.lbltTrack = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblTrack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltStation
            // 
            this.lbltStation.AutoSize = true;
            this.lbltStation.Location = new System.Drawing.Point(39, 26);
            this.lbltStation.Name = "lbltStation";
            this.lbltStation.Size = new System.Drawing.Size(89, 15);
            this.lbltStation.TabIndex = 0;
            this.lbltStation.Text = "Current station:";
            // 
            // lbltTrack
            // 
            this.lbltTrack.AutoSize = true;
            this.lbltTrack.Location = new System.Drawing.Point(39, 69);
            this.lbltTrack.Name = "lbltTrack";
            this.lbltTrack.Size = new System.Drawing.Size(80, 15);
            this.lbltTrack.TabIndex = 1;
            this.lbltTrack.Text = "Railway Track:";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(160, 26);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(43, 15);
            this.lblStation.TabIndex = 2;
            this.lblStation.Text = "station";
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(160, 69);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(33, 15);
            this.lblTrack.TabIndex = 3;
            this.lblTrack.Text = "track";
            // 
            // TrainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lbltTrack);
            this.Controls.Add(this.lbltStation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrainDisplay";
            this.Text = "TrainDisplay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrainDisplay_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltStation;
        private System.Windows.Forms.Label lbltTrack;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblTrack;
    }
}