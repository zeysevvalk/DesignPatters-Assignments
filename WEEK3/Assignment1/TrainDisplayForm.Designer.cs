namespace Assignment1
{
    partial class TrainDisplayForm
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
            lblStation = new Label();
            lblTrack = new Label();
            lblTime = new Label();
            SuspendLayout();
            // 
            // lblStation
            // 
            lblStation.AutoSize = true;
            lblStation.Location = new Point(375, 221);
            lblStation.Name = "lblStation";
            lblStation.Size = new Size(150, 32);
            lblStation.TabIndex = 0;
            lblStation.Text = "Next Station:";
            // 
            // lblTrack
            // 
            lblTrack.AutoSize = true;
            lblTrack.Location = new Point(434, 291);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(73, 32);
            lblTrack.TabIndex = 1;
            lblTrack.Text = "Track:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(429, 379);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(93, 32);
            lblTime.TabIndex = 2;
            lblTime.Text = "Arrival: ";
            // 
            // TrainDisplayForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 656);
            Controls.Add(lblTime);
            Controls.Add(lblTrack);
            Controls.Add(lblStation);
            Name = "TrainDisplayForm";
            Text = "TrainDisplayForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStation;
        private Label lblTrack;
        private Label lblTime;
    }
}