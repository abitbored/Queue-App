﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace QueueApp
{
    public partial class QueueControl : Form
    {
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

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (QueueClass.Queue.Count >= 1)
            {
                SendLocketQueueNumber(CheckLocket());
                DisplayQueue();

                if (CheckLocket() == 1)
                {
                    PlayNotificationSound(LocketClass.locket1, 1);
                }
                if (CheckLocket() == 2)
                {
                    PlayNotificationSound(LocketClass.locket2, 2);
                }
                if (CheckLocket() == 3)
                {
                    PlayNotificationSound(LocketClass.locket3, 3);
                }
                QueueClass.Queue.Dequeue();
                ClickRefresh();
            }
        }

        private void SendLocketQueueNumber(int locketNumber)
        {
            if (locketNumber == 1)
            {
                LocketClass.locket1 = QueueClass.Queue.Peek();
            }

            if (locketNumber == 2)
            {
                LocketClass.locket2 = QueueClass.Queue.Peek();
            }

            if (locketNumber == 3)
            {
                LocketClass.locket3 = QueueClass.Queue.Peek();
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
            DisplayQueue();
            UpdateDisplay();
        }

        public void DisplayQueue()
        {
            QueueListBox.Items.Clear();

            foreach (object queue in QueueClass.Queue)
            {
                QueueListBox.Items.Add(queue);
            }

            if (QueueClass.Queue.Count >= 1)
            {
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
        }

        public void ClickRefresh()
        {
            RefreshButton.PerformClick();
        }
        
        public void UpdateDisplay()
        {
            QueueDisplay.queueDisplayInstance.CurrentLocket1QueueLabel.Text = LocketClass.locket1;
            QueueDisplay.queueDisplayInstance.CurrentLocket2QueueLabel.Text = LocketClass.locket2;
            QueueDisplay.queueDisplayInstance.CurrentLocket3QueueLabel.Text = LocketClass.locket3;
        }

        private void PlayNotificationSound(string currentQueue, int locket)
        {
            string path = @"./notification/";

            SoundPlayer antrianNomor = new SoundPlayer(path + "antrian_nomor.wav");
            SoundPlayer a = new SoundPlayer(path + "a.wav");
            SoundPlayer menuju = new SoundPlayer(path + "menuju.wav");
            SoundPlayer loket = new SoundPlayer(path + "loket.wav");
            SoundPlayer satu = new SoundPlayer(path + "satu.wav");
            SoundPlayer dua = new SoundPlayer(path + "dua.wav");
            SoundPlayer tiga = new SoundPlayer(path + "tiga.wav");

            try
            {
                string[] currentQueueArr = currentQueue.Split('-');

                int currentQueueNumber = Int16.Parse(currentQueueArr[1]);

                string antrian = Terbilang(currentQueueNumber);

                string[] currentQueueTerbilang = antrian.Split(' ');

                antrianNomor.PlaySync();
                a.PlaySync();

                foreach (var bilang in currentQueueTerbilang)
                {
                    SoundPlayer angka = new SoundPlayer(path + bilang + ".wav");
                    angka.PlaySync();
                }

                menuju.PlaySync();
                loket.PlaySync();

                if (locket == 1)
                {
                    satu.PlaySync();
                }
                if (locket == 2)
                {
                    dua.PlaySync();
                }
                if (locket == 3)
                {
                    tiga.PlaySync();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string Terbilang(long a)
        {
            string[] bilangan = new string[] { "", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas" };
            var kalimat = "";
            // 1 - 11
            if (a < 12)
            {
                kalimat = bilangan[a];
            }
            // 12 - 19
            else if (a < 20)
            {
                kalimat = bilangan[a - 10] + " Belas";
            }
            // 20 - 99
            else if (a < 100)
            {
                var utama = a / 10;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 1));
                var belakang = a % 10;
                kalimat = bilangan[depan] + " Puluh " + bilangan[belakang];
            }
            // 100 - 199
            else if (a < 200)
            {
                kalimat = "Seratus " + Terbilang(a - 100);
            }
            // 200 - 999
            else if (a < 1000)
            {
                var utama = a / 100;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 1));
                var belakang = a % 100;
                kalimat = bilangan[depan] + " Ratus " + Terbilang(belakang);
            }
            // 1,000 - 1,999
            else if (a < 2000)
            {
                kalimat = "Seribu " + Terbilang(a - 1000);
            }
            // 2,000 - 9,999
            else if (a < 10000)
            {
                var utama = a / 1000;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 1));
                var belakang = a % 1000;
                kalimat = bilangan[depan] + " Ribu " + Terbilang(belakang);
            }
            // 10,000 - 99,999
            else if (a < 100000)
            {
                var utama = a / 100;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 2));
                var belakang = a % 1000;
                kalimat = Terbilang(depan) + " Ribu " + Terbilang(belakang);
            }
            // 100,000 - 999,999
            else if (a < 1000000)
            {
                var utama = a / 1000;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 3));
                var belakang = a % 1000;
                kalimat = Terbilang(depan) + " Ribu " + Terbilang(belakang);
            }
            // 1,000,000 - 	99,999,999
            else if (a < 100000000)
            {
                var utama = a / 1000000;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 1));//Substring(0, 4));
                var belakang = a % 1000000;
                kalimat = Terbilang(depan) + " Juta " + Terbilang(belakang);
            }
            else if (a < 1000000000)
            {
                var utama = a / 1000000;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 4));
                var belakang = a % 1000000;
                kalimat = Terbilang(depan) + " Juta " + Terbilang(belakang);
            }
            else if (a < 10000000000)
            {
                var utama = a / 1000000000;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 1));
                var belakang = a % 1000000000;
                kalimat = Terbilang(depan) + " Milyar " + Terbilang(belakang);
            }
            else if (a < 100000000000)
            {
                var utama = a / 1000000000;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 2));
                var belakang = a % 1000000000;
                kalimat = Terbilang(depan) + " Milyar " + Terbilang(belakang);
            }
            else if (a < 1000000000000)
            {
                var utama = a / 1000000000;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 3));
                var belakang = a % 1000000000;
                kalimat = Terbilang(depan) + " Milyar " + Terbilang(belakang);
            }
            else if (a < 10000000000000)
            {
                var utama = a / 10000000000;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 1));
                var belakang = a % 10000000000;
                kalimat = Terbilang(depan) + " Triliun " + Terbilang(belakang);
            }
            else if (a < 100000000000000)
            {
                var utama = a / 1000000000000;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 2));
                var belakang = a % 1000000000000;
                kalimat = Terbilang(depan) + " Triliun " + Terbilang(belakang);
            }

            else if (a < 1000000000000000)
            {
                var utama = a / 1000000000000;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 3));
                var belakang = a % 1000000000000;
                kalimat = Terbilang(depan) + " Triliun " + Terbilang(belakang);
            }

            else if (a < 10000000000000000)
            {
                var utama = a / 1000000000000000;
                var depan = Convert.ToInt32(utama.ToString().Substring(0, 1));
                var belakang = a % 1000000000000000;
                kalimat = Terbilang(depan) + " Kuadriliun " + Terbilang(belakang);
            }

            var pisah = kalimat.Split(' ');
            List<string> full = new List<string>();// = [];
            for (var i = 0; i < pisah.Length; i++)
            {
                if (pisah[i] != "") { full.Add(pisah[i]); }
            }
            return CombineTerbilang(full.ToArray());// full.Concat(' '); .join(' ');
        }

        static string CombineTerbilang(string[] arr)
        {
            return string.Join(" ", arr);
        }
    }
}
