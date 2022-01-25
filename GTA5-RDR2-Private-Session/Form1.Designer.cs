
namespace GTA5_RDR2_Private_Session
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SuspendDurationInput = new System.Windows.Forms.NumericUpDown();
            this.RDR2 = new System.Windows.Forms.Button();
            this.GTA5 = new System.Windows.Forms.Button();
            this.ResumeProgrammeTimer = new System.Windows.Forms.Timer(this.components);
            this.Delay_Label = new System.Windows.Forms.Label();
            this.SweepingProgressBar = new System.Windows.Forms.ProgressBar();
            this.Clk = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SuspendDurationInput)).BeginInit();
            this.SuspendLayout();
            // 
            // SuspendDurationInput
            // 
            this.SuspendDurationInput.DecimalPlaces = 1;
            this.SuspendDurationInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.SuspendDurationInput.Location = new System.Drawing.Point(218, 114);
            this.SuspendDurationInput.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.SuspendDurationInput.Name = "SuspendDurationInput";
            this.SuspendDurationInput.Size = new System.Drawing.Size(120, 20);
            this.SuspendDurationInput.TabIndex = 2;
            this.SuspendDurationInput.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // RDR2
            // 
            this.RDR2.Image = global::GTA5_RDR2_Private_Session.Properties.Resources.RDR2LogoEdited3;
            this.RDR2.Location = new System.Drawing.Point(33, 113);
            this.RDR2.Name = "RDR2";
            this.RDR2.Size = new System.Drawing.Size(144, 58);
            this.RDR2.TabIndex = 1;
            this.RDR2.UseVisualStyleBackColor = true;
            this.RDR2.Click += new System.EventHandler(this.RDR2_Click);
            // 
            // GTA5
            // 
            this.GTA5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GTA5.Image = global::GTA5_RDR2_Private_Session.Properties.Resources.GTA5LogoEdited1;
            this.GTA5.Location = new System.Drawing.Point(33, 25);
            this.GTA5.Margin = new System.Windows.Forms.Padding(0);
            this.GTA5.Name = "GTA5";
            this.GTA5.Size = new System.Drawing.Size(144, 58);
            this.GTA5.TabIndex = 0;
            this.GTA5.UseVisualStyleBackColor = true;
            this.GTA5.Click += new System.EventHandler(this.GTA5_Click);
            // 
            // ResumeProgrammeTimer
            // 
            this.ResumeProgrammeTimer.Interval = 8000;
            this.ResumeProgrammeTimer.Tick += new System.EventHandler(this.ResumeProgrammeTimer_Tick);
            // 
            // Delay_Label
            // 
            this.Delay_Label.AutoSize = true;
            this.Delay_Label.Location = new System.Drawing.Point(215, 96);
            this.Delay_Label.Name = "Delay_Label";
            this.Delay_Label.Size = new System.Drawing.Size(83, 13);
            this.Delay_Label.TabIndex = 3;
            this.Delay_Label.Text = "Delay (seconds)";
            // 
            // SweepingProgressBar
            // 
            this.SweepingProgressBar.Location = new System.Drawing.Point(218, 59);
            this.SweepingProgressBar.Name = "SweepingProgressBar";
            this.SweepingProgressBar.Size = new System.Drawing.Size(120, 23);
            this.SweepingProgressBar.Step = 100;
            this.SweepingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SweepingProgressBar.TabIndex = 4;
            // 
            // Clk
            // 
            this.Clk.Interval = 1;
            this.Clk.Tick += new System.EventHandler(this.Clk_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 195);
            this.Controls.Add(this.SweepingProgressBar);
            this.Controls.Add(this.Delay_Label);
            this.Controls.Add(this.SuspendDurationInput);
            this.Controls.Add(this.RDR2);
            this.Controls.Add(this.GTA5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "R* Session Sweeper";
            ((System.ComponentModel.ISupportInitialize)(this.SuspendDurationInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GTA5;
        private System.Windows.Forms.Button RDR2;
        private System.Windows.Forms.NumericUpDown SuspendDurationInput;
        private System.Windows.Forms.Timer ResumeProgrammeTimer;
        private System.Windows.Forms.Label Delay_Label;
        private System.Windows.Forms.ProgressBar SweepingProgressBar;
        private System.Windows.Forms.Timer Clk;
    }
}

