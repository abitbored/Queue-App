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
        //LocketClass locket1 = new LocketClass("Locket 1", 1);
        //LocketClass locket2 = new LocketClass("Locket 2", 2);
        //LocketClass locket3 = new LocketClass("Locket 3", 3);
        public static QueueControl queueControlInstance;
        QueueDisplay queueDisplay = new QueueDisplay();
        public QueueControl()
        {
            InitializeComponent();

            queueControlInstance = this;

            for (int i = 1; i <= 3; i++)
            {
                ChooseLocketDropDown.Items.Add(i);
            }
            ChooseLocketDropDown.SelectedIndex = 0;

            QueueDisplay newDisplayWindow = new QueueDisplay();
            newDisplayWindow.Show();

            QueueNumberPrinter newPrinterWindow = new QueueNumberPrinter();
            newPrinterWindow.Show();
        }

        //private void OpenQueueNumberPrinter()
        //{
        //    QueueNumberPrinter queueNumberPrinter = new QueueNumberPrinter(this);
        //}

        //private void OpenDisplayWIndowButton_Click(object sender, EventArgs e)
        //{
        //    QueueDisplay newDisplayWindow = new QueueDisplay();
        //    newDisplayWindow.Show();
        //}

        //private void OpenPrinterWindowButton_Click_1(object sender, EventArgs e)
        //{
        //    QueueNumberPrinter newPrinterWindow = new QueueNumberPrinter();
        //    newPrinterWindow.Show();
        //}

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
                LocketClass.locket1 = QueueClass.Queue.Dequeue();
            }

            if (locketNumber == 2)
            {
                LocketClass.locket2 = QueueClass.Queue.Dequeue();
            }

            if (locketNumber == 3)
            {
                LocketClass.locket3 = QueueClass.Queue.Dequeue();
            }
        }

        private int CheckLocket()
        {
            return Int16.Parse(ChooseLocketDropDown.GetItemText(ChooseLocketDropDown.SelectedItem));
        }

        private void BreakButton_Click(object sender, EventArgs e)
        {
            if (CheckLocket() == 1)
            {
                QueueDisplay.queueDisplayInstance.CurrentLocket1QueueLabel.Text = "On Break";
                QueueDisplay.queueDisplayInstance.CurrentLocket1QueueLabel.ForeColor = Color.Red;
            }

            if (CheckLocket() == 2)
            {
                QueueDisplay.queueDisplayInstance.CurrentLocket2QueueLabel.Text = "On Break";
                QueueDisplay.queueDisplayInstance.CurrentLocket2QueueLabel.ForeColor = Color.Red;
            }

            if (CheckLocket() == 3)
            {
                QueueDisplay.queueDisplayInstance.CurrentLocket3QueueLabel.Text = "On Break";
                QueueDisplay.queueDisplayInstance.CurrentLocket3QueueLabel.ForeColor = Color.Red;
            }
        }

        private void QueueListBox_Load(object sender, EventArgs e)
        {
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DisplayQueue(QueueClass.Queue);
            UpdateDisplay();
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
                CurrentQueueNumberLabel.Text = LocketClass.locket1;
                QueueDisplay.queueDisplayInstance.CurrentQueueNumberLabel.Text = LocketClass.locket1;
                QueueDisplay.queueDisplayInstance.CurrentLocketNumberLabel.Text = "1";
            }
            if (CheckLocket() == 2)
            {
                CurrentQueueNumberLabel.Text = LocketClass.locket2;
                QueueDisplay.queueDisplayInstance.CurrentQueueNumberLabel.Text = LocketClass.locket2;
                QueueDisplay.queueDisplayInstance.CurrentLocketNumberLabel.Text = "2";
            }
            if (CheckLocket() == 3)
            {
                CurrentQueueNumberLabel.Text = LocketClass.locket3;
                QueueDisplay.queueDisplayInstance.CurrentQueueNumberLabel.Text = LocketClass.locket3;
                QueueDisplay.queueDisplayInstance.CurrentLocketNumberLabel.Text = "3";
            }
        }

        public void ClickRefresh()
        {
            RefreshButton.PerformClick();
        }
        public string x;
        public void UpdateDisplay()
        {
            //LocketClass.locket1 = "Negro";
            //x = LocketClass.locket1;
            QueueDisplay.queueDisplayInstance.CurrentLocket1QueueLabel.Text = LocketClass.locket1;
            QueueDisplay.queueDisplayInstance.CurrentLocket2QueueLabel.Text = LocketClass.locket2;
            QueueDisplay.queueDisplayInstance.CurrentLocket3QueueLabel.Text = LocketClass.locket3;
        }
    }
}
