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

namespace GTA5_RDR2_Private_Session
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GTA5_Click(object sender, EventArgs e)
        {
            Processes();
        }

        void Processes()
        {
            Process GTA5 = new Process();
            GTA5.StartInfo = new ProcessStartInfo("Test.bat");
            GTA5.StartInfo.WorkingDirectory = "Test.bat";
            GTA5.StartInfo.CreateNoWindow = true;
            GTA5.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            GTA5.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            GTA5.Start();

            System.Diagnostics.Debug.WriteLine("I am here!");
        }
    }
}
