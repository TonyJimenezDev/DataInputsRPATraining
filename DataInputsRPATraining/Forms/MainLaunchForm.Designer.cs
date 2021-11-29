
namespace DataInputsRPATraining.Forms
{
    partial class MainLaunchForm
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
            this.launcher_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // launcher_ProgressBar
            // 
            this.launcher_ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.launcher_ProgressBar.Location = new System.Drawing.Point(0, 0);
            this.launcher_ProgressBar.Name = "launcher_ProgressBar";
            this.launcher_ProgressBar.Size = new System.Drawing.Size(120, 27);
            this.launcher_ProgressBar.TabIndex = 0;
            // 
            // MainLaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(120, 27);
            this.Controls.Add(this.launcher_ProgressBar);
            this.Name = "MainLaunchForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainLaunchForm";
            this.Load += new System.EventHandler(this.MainLaunchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar launcher_ProgressBar;
    }
}