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
        LocketClass locket1 = new LocketClass("Locket 1", 1);
        LocketClass locket2 = new LocketClass("Locket 2", 2);
        LocketClass locket3 = new LocketClass("Locket 3", 3);
        public QueueControl()
        {
            InitializeComponent();

            for (int i = 1; i <= 3; i++)
            {
                ChooseLocketDropDown.Items.Add(i);
            }
            ChooseLocketDropDown.SelectedIndex = 0;
        }

        //private void OpenQueueNumberPrinter()
        //{
        //    QueueNumberPrinter queueNumberPrinter = new QueueNumberPrinter(this);
        //}

        private void OpenDisplayWIndowButton_Click(object sender, EventArgs e)
        {
            QueueDisplay newDisplayWindow = new QueueDisplay();
            newDisplayWindow.Show();
        }

        private void OpenPrinterWindowButton_Click_1(object sender, EventArgs e)
        {
            QueueNumberPrinter newPrinterWindow = new QueueNumberPrinter(this);
            newPrinterWindow.Show();
        }

        private void RecallButton_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (QueueClass.Queue == null)
            {
                return;
            }

            if (QueueClass.Queue.Count >= 1)
            {
                SendLocketQueueNumber(CheckLocket());
            }


            ClickRefresh();
        }

        private void SendLocketQueueNumber(int locketNumber)
        {
            if (locketNumber == 1)
            {
                locket1.queueNumber = QueueClass.Queue.Dequeue();
            }

            if (locketNumber == 2)
            {
                locket2.queueNumber = QueueClass.Queue.Dequeue();
            }

            if (locketNumber == 3)
            {
                locket3.queueNumber = QueueClass.Queue.Dequeue();
            }
        }

        private int CheckLocket()
        {
            return Int16.Parse(ChooseLocketDropDown.GetItemText(ChooseLocketDropDown.SelectedItem));
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
            if (queueList == null)
            {
                return;
            }

            foreach (object queue in queueList)
            {
                QueueListBox.Items.Add(queue);
            }

            if (CheckLocket() == 1)
            {
                CurrentQueueNumberLabel.Text = locket1.queueNumber;
            }
            if (CheckLocket() == 2)
            {
                CurrentQueueNumberLabel.Text = locket2.queueNumber;
            }
            if (CheckLocket() == 3)
            {
                CurrentQueueNumberLabel.Text = locket3.queueNumber;
            }
        }

        public void ClickRefresh()
        {
            RefreshButton.PerformClick();
        }
    }
}
