﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApp
{
    class QueueClass
    {
        private int counter;
        public static string getNumberInQueue = "";
        public static Queue<string> Queue;

        public QueueClass()
        {
            counter = 1000;
            Queue = new Queue<string>();
        }
        public string QueueGeneratedNumber(string QueueNumber)
        {
            counter++;
            QueueNumber += counter.ToString().Trim('1');
            return QueueNumber;
        }
    }
}
