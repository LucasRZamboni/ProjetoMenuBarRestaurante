using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoBar
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();

            backgroundWorker1.RunWorkerAsync();
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i <= 101; i++)
            {
                // Wait 45 milliseconds.
                Thread.Sleep(45);
                // Report progress.
                backgroundWorker1.ReportProgress(i);
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
            // Set the text.
            label2.Text = e.ProgressPercentage.ToString() + "%";
            if (label2.Text == "100%")
            {

                label3.Text = "Loaded!";
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // TODO: do something with final calculation.

            
            var login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
