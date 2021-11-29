using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataInputsRPATraining.Forms
{
    public partial class MainLaunchForm : Form
    {
        public MainLaunchForm()
        {
            InitializeComponent();
        }

        private void MainLaunchForm_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            
            this.FormBorderStyle = FormBorderStyle.None;
            for (int i = 0; i <= 100; i++)
            {
                launcher_ProgressBar.ForeColor = Color.Blue;
                launcher_ProgressBar.Value = i;
                Task.Delay(40).Wait();
                if (launcher_ProgressBar.Value == 100)
                {
                    launcher_ProgressBar.Value = 100;
                    LoginFormMain loginFormMain = new LoginFormMain();
                    loginFormMain.Show();
                }
            }            
            this.Opacity = 0;
            this.Visible = false;
        }

        private void MainLaunchForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
