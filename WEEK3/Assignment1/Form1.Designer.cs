namespace Assignment1
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
            btnNextStation = new Button();
            btnReverseJourney = new Button();
            SuspendLayout();
            // 
            // btnNextStation
            // 
            btnNextStation.Location = new Point(385, 168);
            btnNextStation.Name = "btnNextStation";
            btnNextStation.Size = new Size(324, 99);
            btnNextStation.TabIndex = 0;
            btnNextStation.Text = "Next Station";
            btnNextStation.UseVisualStyleBackColor = true;
            btnNextStation.Click += btnNextStation_Click;
            // 
            // btnReverseJourney
            // 
            btnReverseJourney.Location = new Point(394, 363);
            btnReverseJourney.Name = "btnReverseJourney";
            btnReverseJourney.Size = new Size(315, 107);
            btnReverseJourney.TabIndex = 1;
            btnReverseJourney.Text = "Reverse Journey";
            btnReverseJourney.UseVisualStyleBackColor = true;
            btnReverseJourney.Click += btnReverseJourney_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 739);
            Controls.Add(btnReverseJourney);
            Controls.Add(btnNextStation);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNextStation;
        private Button btnReverseJourney;
    }
}
