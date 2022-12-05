namespace QueueApp
{
    partial class QueueControl
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
            this.QueueControllerLabel = new System.Windows.Forms.Label();
            this.ChooseLocketLabel = new System.Windows.Forms.Label();
            this.ChooseLocketDropDown = new System.Windows.Forms.ComboBox();
            this.QueueListBox = new System.Windows.Forms.ListBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.BreakButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CurrentQueueNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 600);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // QueueControllerLabel
            // 
            this.QueueControllerLabel.AutoSize = true;
            this.QueueControllerLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QueueControllerLabel.Location = new System.Drawing.Point(12, 9);
            this.QueueControllerLabel.Name = "QueueControllerLabel";
            this.QueueControllerLabel.Size = new System.Drawing.Size(265, 45);
            this.QueueControllerLabel.TabIndex = 0;
            this.QueueControllerLabel.Text = "Queue Controller";
            // 
            // ChooseLocketLabel
            // 
            this.ChooseLocketLabel.AutoSize = true;
            this.ChooseLocketLabel.Location = new System.Drawing.Point(12, 74);
            this.ChooseLocketLabel.Name = "ChooseLocketLabel";
            this.ChooseLocketLabel.Size = new System.Drawing.Size(76, 30);
            this.ChooseLocketLabel.TabIndex = 1;
            this.ChooseLocketLabel.Text = "Locket";
            // 
            // ChooseLocketDropDown
            // 
            this.ChooseLocketDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseLocketDropDown.FormattingEnabled = true;
            this.ChooseLocketDropDown.Location = new System.Drawing.Point(115, 71);
            this.ChooseLocketDropDown.Name = "ChooseLocketDropDown";
            this.ChooseLocketDropDown.Size = new System.Drawing.Size(76, 38);
            this.ChooseLocketDropDown.TabIndex = 2;
            // 
            // QueueListBox
            // 
            this.QueueListBox.FormattingEnabled = true;
            this.QueueListBox.ItemHeight = 30;
            this.QueueListBox.Location = new System.Drawing.Point(12, 121);
            this.QueueListBox.Name = "QueueListBox";
            this.QueueListBox.Size = new System.Drawing.Size(329, 424);
            this.QueueListBox.TabIndex = 3;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(492, 193);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(145, 63);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BreakButton
            // 
            this.BreakButton.Location = new System.Drawing.Point(492, 337);
            this.BreakButton.Name = "BreakButton";
            this.BreakButton.Size = new System.Drawing.Size(145, 63);
            this.BreakButton.TabIndex = 7;
            this.BreakButton.Text = "Break";
            this.BreakButton.UseVisualStyleBackColor = true;
            this.BreakButton.Click += new System.EventHandler(this.BreakButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(245, 74);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(96, 41);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CurrentQueueNumberLabel
            // 
            this.CurrentQueueNumberLabel.Location = new System.Drawing.Point(643, 24);
            this.CurrentQueueNumberLabel.Name = "CurrentQueueNumberLabel";
            this.CurrentQueueNumberLabel.Size = new System.Drawing.Size(76, 30);
            this.CurrentQueueNumberLabel.TabIndex = 1;
            // 
            // QueueControl
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.BreakButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.QueueListBox);
            this.Controls.Add(this.ChooseLocketDropDown);
            this.Controls.Add(this.CurrentQueueNumberLabel);
            this.Controls.Add(this.ChooseLocketLabel);
            this.Controls.Add(this.QueueControllerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QueueControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label QueueControllerLabel;
        private Label ChooseLocketLabel;
        private ComboBox ChooseLocketDropDown;
        private ListBox QueueListBox;
        private Button NextButton;
        private Button BreakButton;
        private Label CurrentQueueNumberLabel;
        internal Button RefreshButton;
    }
}