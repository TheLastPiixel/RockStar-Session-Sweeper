using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime;

namespace GTA5_RDR2_Private_Session
{
    public partial class Form1 : Form
    {
        public string programme;
        public int delay = 8000;

        public Form1()
        {
            InitializeComponent();
        }

        private void GTA5_Click(object sender, EventArgs e)
        {
            programme = "GTA5";
            CheckIfProgrammeRunning();
        }

        private void RDR2_Click(object sender, EventArgs e)
        {
            programme = "RDR2";
            CheckIfProgrammeRunning();
        }

        private void Clk_Tick(object sender, EventArgs e)
        {
            SweepingProgressBar.PerformStep();
            if (SweepingProgressBar.Value == SweepingProgressBar.Maximum)
            {
                Clk.Stop();
            }
        }

        private void ResumeProgrammeTimer_Tick(object sender, EventArgs e)
        {
            //Resume programme
            string cmd = "-r " + programme + ".exe";
            System.Diagnostics.Process.Start("pssuspend64.exe", cmd);

            //Re-enable buttons
            GTA5.Enabled = true;
            RDR2.Enabled = true;

            ResumeProgrammeTimer.Stop();
        }

        private void ErrorLabelTimer_Tick(object sender, EventArgs e)
        {
            //Resets error label
            ErrorLabel.Text = "";
            ErrorLabelTimer.Stop();
        }

        private void CheckIfProgrammeRunning()
        {
            //Check if requested programme is running
            if (Process.GetProcessesByName(programme).Length > 0)
            {
                SuspendProgramme();
            }
            else
            {
                ErrorLabel.Text = programme + ".exe is not running!";
                ErrorLabelTimer.Start();
            }
        }

        private void SuspendProgramme()
        {
            //Disables buttons
            GTA5.Enabled = false;
            RDR2.Enabled = false;

            //Sets delay before programme is resumed
            delay = Convert.ToInt32(SuspendDurationInput.Value * 1000);
            ResumeProgrammeTimer.Interval = delay;

            //Suspends process
            System.Diagnostics.Process.Start("pssuspend64.exe", programme + ".exe");

            //Starts countdown for programme to resume
            StartProgressBar();
            ResumeProgrammeTimer.Start();
        }

        private void StartProgressBar()
        {
            SweepingProgressBar.Value = 0;
            SweepingProgressBar.Maximum = delay / 500;
            Clk.Start();
        }
    }
}
