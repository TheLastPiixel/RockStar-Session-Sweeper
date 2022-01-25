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
        public int currentTick = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void GTA5_Click(object sender, EventArgs e)
        {
            programme = "GTA5.exe";
            SuspendProgramme(programme);
        }

        private void RDR2_Click(object sender, EventArgs e)
        {
            programme = "RDR2.exe";
            SuspendProgramme(programme);
        }

        private void SuspendProgramme(string programme)
        {
            //Disables buttons
            GTA5.Enabled = false;
            RDR2.Enabled = false;

            //Sets delay before programme is resumed
            delay = Convert.ToInt32(SuspendDurationInput.Value * 1000);
            ResumeProgrammeTimer.Interval = delay;

            //Suspends process
            System.Diagnostics.Process.Start("pssuspend64.exe", programme);

            //Starts countdown for programme to resume
            ResumeProgrammeTimer.Start();
            //ProgressBar();
        }

        private void ResumeProgrammeTimer_Tick(object sender, EventArgs e)
        {
            //Resume programme
            string cmd = "-r " + programme;
            System.Diagnostics.Process.Start("pssuspend64.exe", cmd);

            //Re-enable buttons
            GTA5.Enabled = true;
            RDR2.Enabled = true;

            ResumeProgrammeTimer.Stop();
        }

        private void ProgressBar()
        {
            SweepingProgressBar.Value = 0;
            currentTick = 0;
            Clk.Start();

            int interval = (delay / SweepingProgressBar.Maximum);
            while (currentTick < delay)
            {
                if (currentTick % interval == 0 && SweepingProgressBar.Value < SweepingProgressBar.Maximum)
                {
                    SweepingProgressBar.Value++;
                }
            }
        }

        private void Clk_Tick(object sender, EventArgs e)
        {
            currentTick = currentTick++;
        }
    }
}
