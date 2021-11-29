using System;
using System.Windows.Forms;

namespace DataInputsRPATraining
{
    public partial class LoginFormMain : Form
    {
        // Username and password
        const string username = "Username";
        const string password = "password";

        public LoginFormMain()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
    
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(!LoginVerifier())
            {
                invalidUser_Label.Visible = true;
                invalidUser_Label.Text = "Incorrect username or password";
                return;
            }
            // Login verified
            invalidUser_Label.Visible = false;
            this.Hide();            
            CountryForm countryForm = new CountryForm();
            countryForm.Show();
            this.Close();
        }

        private bool LoginVerifier()
        {
            if (userName_Texbox.Text.ToLower() != username.ToLower())
            {
                return false;
            }

            if (password_Textbox.Text != password)
            {
                return false;
            }
            return true;            
        }

        private void LoginFormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count.Equals(2)) Application.Exit();
        }
    }
}
