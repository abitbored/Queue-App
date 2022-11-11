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
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.RecallButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.BreakButton = new System.Windows.Forms.Button();
            this.OpenDisplayWIndowButton = new System.Windows.Forms.Button();
            this.OpenPrinterWindowButton = new System.Windows.Forms.Button();
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
            this.QueueControllerLabel.Size = new System.Drawing.Size(329, 54);
            this.QueueControllerLabel.TabIndex = 0;
            this.QueueControllerLabel.Text = "Queue Controller";
            this.QueueControllerLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ChooseLocketLabel
            // 
            this.ChooseLocketLabel.AutoSize = true;
            this.ChooseLocketLabel.Location = new System.Drawing.Point(12, 74);
            this.ChooseLocketLabel.Name = "ChooseLocketLabel";
            this.ChooseLocketLabel.Size = new System.Drawing.Size(97, 38);
            this.ChooseLocketLabel.TabIndex = 1;
            this.ChooseLocketLabel.Text = "Locket";
            // 
            // ChooseLocketDropDown
            // 
            this.ChooseLocketDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseLocketDropDown.FormattingEnabled = true;
            this.ChooseLocketDropDown.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ChooseLocketDropDown.Location = new System.Drawing.Point(115, 71);
            this.ChooseLocketDropDown.Name = "ChooseLocketDropDown";
            this.ChooseLocketDropDown.Size = new System.Drawing.Size(76, 45);
            this.ChooseLocketDropDown.TabIndex = 2;
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 37;
            this.HistoryListBox.Location = new System.Drawing.Point(12, 171);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(329, 374);
            this.HistoryListBox.TabIndex = 3;
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Location = new System.Drawing.Point(12, 130);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(105, 38);
            this.HistoryLabel.TabIndex = 4;
            this.HistoryLabel.Text = "History";
            // 
            // RecallButton
            // 
            this.RecallButton.Location = new System.Drawing.Point(492, 130);
            this.RecallButton.Name = "RecallButton";
            this.RecallButton.Size = new System.Drawing.Size(145, 63);
            this.RecallButton.TabIndex = 5;
            this.RecallButton.Text = "Recall";
            this.RecallButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(492, 245);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(145, 63);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // BreakButton
            // 
            this.BreakButton.Location = new System.Drawing.Point(492, 360);
            this.BreakButton.Name = "BreakButton";
            this.BreakButton.Size = new System.Drawing.Size(145, 63);
            this.BreakButton.TabIndex = 7;
            this.BreakButton.Text = "Break";
            this.BreakButton.UseVisualStyleBackColor = true;
            // 
            // OpenDisplayWIndowButton
            // 
            this.OpenDisplayWIndowButton.Location = new System.Drawing.Point(347, 478);
            this.OpenDisplayWIndowButton.Name = "OpenDisplayWIndowButton";
            this.OpenDisplayWIndowButton.Size = new System.Drawing.Size(127, 52);
            this.OpenDisplayWIndowButton.TabIndex = 8;
            this.OpenDisplayWIndowButton.Text = "Display";
            this.OpenDisplayWIndowButton.UseVisualStyleBackColor = true;
            // 
            // OpenPrinterWindowButton
            // 
            this.OpenPrinterWindowButton.Location = new System.Drawing.Point(643, 478);
            this.OpenPrinterWindowButton.Name = "OpenPrinterWindowButton";
            this.OpenPrinterWindowButton.Size = new System.Drawing.Size(127, 52);
            this.OpenPrinterWindowButton.TabIndex = 9;
            this.OpenPrinterWindowButton.Text = "Printer";
            this.OpenPrinterWindowButton.UseVisualStyleBackColor = true;
            // 
            // QueueControl
            // 
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.OpenPrinterWindowButton);
            this.Controls.Add(this.OpenDisplayWIndowButton);
            this.Controls.Add(this.BreakButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RecallButton);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.HistoryListBox);
            this.Controls.Add(this.ChooseLocketDropDown);
            this.Controls.Add(this.ChooseLocketLabel);
            this.Controls.Add(this.QueueControllerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "QueueControl";
            this.Text = "Queue Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label QueueControllerLabel;
        private Label ChooseLocketLabel;
        private ComboBox ChooseLocketDropDown;
        private ListBox HistoryListBox;
        private Label HistoryLabel;
        private Button RecallButton;
        private Button NextButton;
        private Button BreakButton;
        private Button OpenDisplayWIndowButton;
        private Button OpenPrinterWindowButton;
    }
}