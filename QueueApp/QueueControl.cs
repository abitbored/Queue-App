using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace QueueApp
{
    public partial class QueueControl : Form
    {
        public QueueControl()
        {
            InitializeComponent();
        }

        private void OpenDisplayWIndowButton_Click(object sender, EventArgs e)
        {
            QueueDisplay newDisplayWindow = new QueueDisplay();
            newDisplayWindow.Show();
        }

        private void OpenPrinterWindowButton_Click_1(object sender, EventArgs e)
        {
            QueueNumberPrinter newPrinterWindow = new QueueNumberPrinter();
            newPrinterWindow.Show();
        }

        private void RecallButton_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string CurrentQueue = QueueClass.Queue.Peek();
            CurrentQueueNumberLabel.Text = CurrentQueue;
            QueueClass.Queue.Dequeue();
            RefreshButton.PerformClick();
        }

        private void BreakButton_Click(object sender, EventArgs e)
        {

        }

        private void QueueListBox_Load(object sender, EventArgs e)
        {
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DisplayQueue(QueueClass.Queue);
        }

        public void DisplayQueue(IEnumerable queueList)
        {
            QueueListBox.Items.Clear();
            foreach (object queue in queueList)
            {
                QueueListBox.Items.Add(queue);
            }
        }


    }
}
