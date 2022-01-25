
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
            this.GTA5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GTA5
            // 
            this.GTA5.Image = global::GTA5_RDR2_Private_Session.Properties.Resources.GTA5_Logo;
            this.GTA5.Location = new System.Drawing.Point(306, 113);
            this.GTA5.Name = "GTA5";
            this.GTA5.Size = new System.Drawing.Size(188, 80);
            this.GTA5.TabIndex = 0;
            this.GTA5.Text = "GTA5";
            this.GTA5.UseVisualStyleBackColor = true;
            this.GTA5.Click += new System.EventHandler(this.GTA5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GTA5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GTA5;
    }
}

