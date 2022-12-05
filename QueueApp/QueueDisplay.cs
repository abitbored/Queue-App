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
    public partial class QueueDisplay : Form
    {
        public static QueueDisplay queueDisplayInstance;
        public Label lbl;
        public QueueDisplay()
        {
            InitializeComponent();
            queueDisplayInstance = this;
            lbl = CurrentLocket1QueueLabel;
        }

        private void QueueDisplay_Load(object sender, EventArgs e)
        {

        }

        private void QueueDisplayLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Locket2Label_Click(object sender, EventArgs e)
        {

        }
    }
}
