namespace QueueApp
{
    partial class QueueDisplay
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
            this.CurrentQueueLabel = new System.Windows.Forms.Label();
            this.CurrentLocketLabel = new System.Windows.Forms.Label();
            this.Locket1Label = new System.Windows.Forms.Label();
            this.Locket3Label = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.Locket2Label = new System.Windows.Forms.Label();
            this.CurrentQueueNumberLabel = new System.Windows.Forms.Label();
            this.CurrentLocketNumberLabel = new System.Windows.Forms.Label();
            this.CurrentLocket1QueueLabel = new System.Windows.Forms.Label();
            this.CurrentLocket2QueueLabel = new System.Windows.Forms.Label();
            this.CurrentLocket3QueueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentQueueLabel
            // 
            this.CurrentQueueLabel.AutoSize = true;
            this.CurrentQueueLabel.Location = new System.Drawing.Point(218, 92);
            this.CurrentQueueLabel.Name = "CurrentQueueLabel";
            this.CurrentQueueLabel.Size = new System.Drawing.Size(93, 30);
            this.CurrentQueueLabel.TabIndex = 3;
            this.CurrentQueueLabel.Text = "Number";
            // 
            // CurrentLocketLabel
            // 
            this.CurrentLocketLabel.AutoSize = true;
            this.CurrentLocketLabel.Location = new System.Drawing.Point(483, 92);
            this.CurrentLocketLabel.Name = "CurrentLocketLabel";
            this.CurrentLocketLabel.Size = new System.Drawing.Size(76, 30);
            this.CurrentLocketLabel.TabIndex = 4;
            this.CurrentLocketLabel.Text = "Locket";
            this.CurrentLocketLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Locket1Label
            // 
            this.Locket1Label.AutoSize = true;
            this.Locket1Label.Location = new System.Drawing.Point(87, 408);
            this.Locket1Label.Name = "Locket1Label";
            this.Locket1Label.Size = new System.Drawing.Size(94, 30);
            this.Locket1Label.TabIndex = 7;
            this.Locket1Label.Text = "Locket 1";
            // 
            // Locket3Label
            // 
            this.Locket3Label.AutoSize = true;
            this.Locket3Label.Location = new System.Drawing.Point(603, 408);
            this.Locket3Label.Name = "Locket3Label";
            this.Locket3Label.Size = new System.Drawing.Size(94, 30);
            this.Locket3Label.TabIndex = 11;
            this.Locket3Label.Text = "Locket 3";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(377, 155);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(33, 30);
            this.ToLabel.TabIndex = 5;
            this.ToLabel.Text = "to";
            // 
            // Locket2Label
            // 
            this.Locket2Label.AutoSize = true;
            this.Locket2Label.Location = new System.Drawing.Point(346, 408);
            this.Locket2Label.Name = "Locket2Label";
            this.Locket2Label.Size = new System.Drawing.Size(94, 30);
            this.Locket2Label.TabIndex = 9;
            this.Locket2Label.Text = "Locket 2";
            this.Locket2Label.Click += new System.EventHandler(this.Locket2Label_Click);
            // 
            // CurrentQueueNumberLabel
            // 
            this.CurrentQueueNumberLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentQueueNumberLabel.Location = new System.Drawing.Point(196, 143);
            this.CurrentQueueNumberLabel.Name = "CurrentQueueNumberLabel";
            this.CurrentQueueNumberLabel.Size = new System.Drawing.Size(137, 45);
            this.CurrentQueueNumberLabel.TabIndex = 3;
            this.CurrentQueueNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentLocketNumberLabel
            // 
            this.CurrentLocketNumberLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentLocketNumberLabel.Location = new System.Drawing.Point(465, 143);
            this.CurrentLocketNumberLabel.Name = "CurrentLocketNumberLabel";
            this.CurrentLocketNumberLabel.Size = new System.Drawing.Size(113, 45);
            this.CurrentLocketNumberLabel.TabIndex = 4;
            this.CurrentLocketNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentLocketNumberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CurrentLocket1QueueLabel
            // 
            this.CurrentLocket1QueueLabel.Location = new System.Drawing.Point(53, 438);
            this.CurrentLocket1QueueLabel.Name = "CurrentLocket1QueueLabel";
            this.CurrentLocket1QueueLabel.Size = new System.Drawing.Size(162, 30);
            this.CurrentLocket1QueueLabel.TabIndex = 7;
            this.CurrentLocket1QueueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentLocket2QueueLabel
            // 
            this.CurrentLocket2QueueLabel.Location = new System.Drawing.Point(312, 438);
            this.CurrentLocket2QueueLabel.Name = "CurrentLocket2QueueLabel";
            this.CurrentLocket2QueueLabel.Size = new System.Drawing.Size(162, 30);
            this.CurrentLocket2QueueLabel.TabIndex = 9;
            this.CurrentLocket2QueueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentLocket2QueueLabel.Click += new System.EventHandler(this.Locket2Label_Click);
            // 
            // CurrentLocket3QueueLabel
            // 
            this.CurrentLocket3QueueLabel.Location = new System.Drawing.Point(569, 438);
            this.CurrentLocket3QueueLabel.Name = "CurrentLocket3QueueLabel";
            this.CurrentLocket3QueueLabel.Size = new System.Drawing.Size(162, 30);
            this.CurrentLocket3QueueLabel.TabIndex = 11;
            this.CurrentLocket3QueueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QueueDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CurrentLocket3QueueLabel);
            this.Controls.Add(this.Locket3Label);
            this.Controls.Add(this.CurrentLocket2QueueLabel);
            this.Controls.Add(this.CurrentLocket1QueueLabel);
            this.Controls.Add(this.Locket2Label);
            this.Controls.Add(this.Locket1Label);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.CurrentLocketNumberLabel);
            this.Controls.Add(this.CurrentQueueNumberLabel);
            this.Controls.Add(this.CurrentLocketLabel);
            this.Controls.Add(this.CurrentQueueLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "QueueDisplay";
            this.Text = "Queue Display";
            this.Load += new System.EventHandler(this.QueueDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label CurrentQueueLabel;
        private Label CurrentLocketLabel;
        private Label Locket1Label;
        private Label Locket3Label;
        private Label ToLabel;
        private Label Locket2Label;
        public Label CurrentQueueNumberLabel;
        public Label CurrentLocketNumberLabel;
        public Label CurrentLocket1QueueLabel;
        public Label CurrentLocket2QueueLabel;
        public Label CurrentLocket3QueueLabel;
    }
}