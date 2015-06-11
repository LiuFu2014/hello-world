using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTest
{
    public partial class Form2 : Form
    {
        public int int_Test { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 辅助线程处理
        /// Handles the DoWork event of the backgroundWorker1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DoWorkEventArgs"/> instance containing the event data.</param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int c = 1;
            int j =c + 1;
            for (int i = 0; i < 1000; i++)
            {
                //label2.Text = i.ToString();
                //int_Test = 6;
                Thread.Sleep(50);
                backgroundWorker1.ReportProgress(i);
            }
     
            //Thread.Sleep(2000);
            //backgroundWorker1.ReportProgress(2);
        }

        /// <summary>
        /// 辅助线程进度更新事件
        /// Handles the ProgressChanged event of the backgroundWorker1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ProgressChangedEventArgs"/> instance containing the event data.</param>
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = e.ProgressPercentage.ToString();
            //Application.DoEvents();
        }

        /// <summary>
        /// 辅助线程完成事件
        /// Handles the RunWorkerCompleted event of the backgroundWorker1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = "已完成";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }
    }
}
