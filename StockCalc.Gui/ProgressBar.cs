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
using StockCalc.Data;

namespace StockCalc.Gui
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void WorkerDoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    Simulate();
                    backgroundWorker1.ReportProgress(i);
                }
               
            }
        }

        private void WorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            
        }

        private void WorkerRunComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            Display("Work Completed Successfully");
        }

        private void Simulate()
        {
            Thread.Sleep(100);
        }

        private void Display(string text)
        {
            MessageBox.Show(text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}
