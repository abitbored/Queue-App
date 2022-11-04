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
            this.CurrentQueueDisplay = new System.Windows.Forms.TextBox();
            this.CurrentLocketDisplay = new System.Windows.Forms.TextBox();
            this.CurrentQueueLabel = new System.Windows.Forms.Label();
            this.CurrentLocketLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.Locket1Label = new System.Windows.Forms.Label();
            this.Locket1CurrentQueue = new System.Windows.Forms.TextBox();
            this.Locket2Label = new System.Windows.Forms.Label();
            this.Locket2CurrentQueue = new System.Windows.Forms.TextBox();
            this.Locket3Label = new System.Windows.Forms.Label();
            this.Locket3CurrentQueue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CurrentQueueDisplay
            // 
            this.CurrentQueueDisplay.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentQueueDisplay.Location = new System.Drawing.Point(217, 115);
            this.CurrentQueueDisplay.Name = "CurrentQueueDisplay";
            this.CurrentQueueDisplay.Size = new System.Drawing.Size(114, 74);
            this.CurrentQueueDisplay.TabIndex = 1;
            this.CurrentQueueDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentLocketDisplay
            // 
            this.CurrentLocketDisplay.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentLocketDisplay.Location = new System.Drawing.Point(452, 115);
            this.CurrentLocketDisplay.Name = "CurrentLocketDisplay";
            this.CurrentLocketDisplay.Size = new System.Drawing.Size(114, 74);
            this.CurrentLocketDisplay.TabIndex = 2;
            this.CurrentLocketDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentQueueLabel
            // 
            this.CurrentQueueLabel.AutoSize = true;
            this.CurrentQueueLabel.Location = new System.Drawing.Point(215, 65);
            this.CurrentQueueLabel.Name = "CurrentQueueLabel";
            this.CurrentQueueLabel.Size = new System.Drawing.Size(119, 38);
            this.CurrentQueueLabel.TabIndex = 3;
            this.CurrentQueueLabel.Text = "Number";
            // 
            // CurrentLocketLabel
            // 
            this.CurrentLocketLabel.AutoSize = true;
            this.CurrentLocketLabel.Location = new System.Drawing.Point(461, 65);
            this.CurrentLocketLabel.Name = "CurrentLocketLabel";
            this.CurrentLocketLabel.Size = new System.Drawing.Size(97, 38);
            this.CurrentLocketLabel.TabIndex = 4;
            this.CurrentLocketLabel.Text = "Locket";
            this.CurrentLocketLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(370, 133);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(42, 38);
            this.ToLabel.TabIndex = 5;
            this.ToLabel.Text = "to";
            // 
            // Locket1Label
            // 
            this.Locket1Label.AutoSize = true;
            this.Locket1Label.Location = new System.Drawing.Point(84, 381);
            this.Locket1Label.Name = "Locket1Label";
            this.Locket1Label.Size = new System.Drawing.Size(120, 38);
            this.Locket1Label.TabIndex = 7;
            this.Locket1Label.Text = "Locket 1";
            // 
            // Locket1CurrentQueue
            // 
            this.Locket1CurrentQueue.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Locket1CurrentQueue.Location = new System.Drawing.Point(87, 431);
            this.Locket1CurrentQueue.Name = "Locket1CurrentQueue";
            this.Locket1CurrentQueue.Size = new System.Drawing.Size(114, 74);
            this.Locket1CurrentQueue.TabIndex = 6;
            this.Locket1CurrentQueue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Locket2Label
            // 
            this.Locket2Label.AutoSize = true;
            this.Locket2Label.Location = new System.Drawing.Point(331, 381);
            this.Locket2Label.Name = "Locket2Label";
            this.Locket2Label.Size = new System.Drawing.Size(120, 38);
            this.Locket2Label.TabIndex = 9;
            this.Locket2Label.Text = "Locket 2";
            // 
            // Locket2CurrentQueue
            // 
            this.Locket2CurrentQueue.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Locket2CurrentQueue.Location = new System.Drawing.Point(334, 431);
            this.Locket2CurrentQueue.Name = "Locket2CurrentQueue";
            this.Locket2CurrentQueue.Size = new System.Drawing.Size(114, 74);
            this.Locket2CurrentQueue.TabIndex = 8;
            this.Locket2CurrentQueue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Locket3Label
            // 
            this.Locket3Label.AutoSize = true;
            this.Locket3Label.Location = new System.Drawing.Point(564, 381);
            this.Locket3Label.Name = "Locket3Label";
            this.Locket3Label.Size = new System.Drawing.Size(120, 38);
            this.Locket3Label.TabIndex = 11;
            this.Locket3Label.Text = "Locket 3";
            // 
            // Locket3CurrentQueue
            // 
            this.Locket3CurrentQueue.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Locket3CurrentQueue.Location = new System.Drawing.Point(567, 431);
            this.Locket3CurrentQueue.Name = "Locket3CurrentQueue";
            this.Locket3CurrentQueue.Size = new System.Drawing.Size(114, 74);
            this.Locket3CurrentQueue.TabIndex = 10;
            this.Locket3CurrentQueue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QueueDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Locket3Label);
            this.Controls.Add(this.Locket3CurrentQueue);
            this.Controls.Add(this.Locket2Label);
            this.Controls.Add(this.Locket2CurrentQueue);
            this.Controls.Add(this.Locket1Label);
            this.Controls.Add(this.Locket1CurrentQueue);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.CurrentLocketLabel);
            this.Controls.Add(this.CurrentQueueLabel);
            this.Controls.Add(this.CurrentLocketDisplay);
            this.Controls.Add(this.CurrentQueueDisplay);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "QueueDisplay";
            this.Text = "Queue Display";
            this.Load += new System.EventHandler(this.QueueDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CurrentQueueDisplay;
        private TextBox CurrentLocketDisplay;
        private Label CurrentQueueLabel;
        private Label CurrentLocketLabel;
        private Label ToLabel;
        private Label Locket1Label;
        private TextBox Locket1CurrentQueue;
        private Label Locket2Label;
        private TextBox Locket2CurrentQueue;
        private Label Locket3Label;
        private TextBox Locket3CurrentQueue;
    }
}