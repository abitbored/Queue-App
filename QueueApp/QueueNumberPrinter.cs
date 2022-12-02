using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueApp
{
    public partial class QueueNumberPrinter : Form
    {
        private QueueClass queue = new QueueClass();
        public QueueNumberPrinter()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            NewQueueNumberLabel.Text = queue.QueueGeneratedNumber("A-");
            QueueClass.getNumberInQueue = NewQueueNumberLabel.Text;

            QueueClass.Queue.Enqueue(QueueClass.getNumberInQueue);
        }
    }
}
