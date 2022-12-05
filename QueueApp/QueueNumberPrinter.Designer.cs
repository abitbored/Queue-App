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
            this.NewQueueNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue Number Printer";
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(320, 140);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(145, 63);
            this.PrintButton.TabIndex = 6;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // YourQueueNumberLabel
            // 
            this.YourQueueNumberLabel.AutoSize = true;
            this.YourQueueNumberLabel.Location = new System.Drawing.Point(287, 290);
            this.YourQueueNumberLabel.Name = "YourQueueNumberLabel";
            this.YourQueueNumberLabel.Size = new System.Drawing.Size(210, 30);
            this.YourQueueNumberLabel.TabIndex = 7;
            this.YourQueueNumberLabel.Text = "Your queue number:";
            // 
            // NewQueueNumberLabel
            // 
            this.NewQueueNumberLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewQueueNumberLabel.Location = new System.Drawing.Point(275, 340);
            this.NewQueueNumberLabel.Name = "NewQueueNumberLabel";
            this.NewQueueNumberLabel.Size = new System.Drawing.Size(232, 45);
            this.NewQueueNumberLabel.TabIndex = 0;
            this.NewQueueNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QueueNumberPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.YourQueueNumberLabel);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.NewQueueNumberLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "QueueNumberPrinter";
            this.Text = "QueueNumberPrinter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button PrintButton;
        private Label YourQueueNumberLabel;
        private Label NewQueueNumberLabel;
    }
}