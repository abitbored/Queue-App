namespace QueueApp
{
    partial class QueueNumberPrinter
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
            this.label1 = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.YourQueueNumberLabel = new System.Windows.Forms.Label();
            this.YourQueueNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue Number Printer";
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(319, 140);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(145, 63);
            this.PrintButton.TabIndex = 6;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.RecallButton_Click);
            // 
            // YourQueueNumberLabel
            // 
            this.YourQueueNumberLabel.AutoSize = true;
            this.YourQueueNumberLabel.Location = new System.Drawing.Point(257, 290);
            this.YourQueueNumberLabel.Name = "YourQueueNumberLabel";
            this.YourQueueNumberLabel.Size = new System.Drawing.Size(269, 38);
            this.YourQueueNumberLabel.TabIndex = 7;
            this.YourQueueNumberLabel.Text = "Your queue number:";
            // 
            // YourQueueNumberTextBox
            // 
            this.YourQueueNumberTextBox.Location = new System.Drawing.Point(329, 346);
            this.YourQueueNumberTextBox.Name = "YourQueueNumberTextBox";
            this.YourQueueNumberTextBox.ReadOnly = true;
            this.YourQueueNumberTextBox.Size = new System.Drawing.Size(125, 43);
            this.YourQueueNumberTextBox.TabIndex = 8;
            this.YourQueueNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QueueNumberPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.YourQueueNumberTextBox);
            this.Controls.Add(this.YourQueueNumberLabel);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "QueueNumberPrinter";
            this.Text = "QueueNumberPrinter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button PrintButton;
        private Label YourQueueNumberLabel;
        private TextBox YourQueueNumberTextBox;
    }
}