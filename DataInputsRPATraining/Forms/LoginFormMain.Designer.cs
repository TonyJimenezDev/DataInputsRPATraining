
namespace DataInputsRPATraining
{
    partial class LoginFormMain
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
            this.userName_Texbox = new System.Windows.Forms.TextBox();
            this.password_Textbox = new System.Windows.Forms.TextBox();
            this.username_Label = new System.Windows.Forms.Label();
            this.password_Label = new System.Windows.Forms.Label();
            this.title_Label = new System.Windows.Forms.Label();
            this.login_Btn = new System.Windows.Forms.Button();
            this.invalidUser_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userName_Texbox
            // 
            this.userName_Texbox.Location = new System.Drawing.Point(140, 192);
            this.userName_Texbox.Margin = new System.Windows.Forms.Padding(4);
            this.userName_Texbox.Name = "userName_Texbox";
            this.userName_Texbox.Size = new System.Drawing.Size(132, 22);
            this.userName_Texbox.TabIndex = 0;
            // 
            // password_Textbox
            // 
            this.password_Textbox.Location = new System.Drawing.Point(140, 274);
            this.password_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.Size = new System.Drawing.Size(132, 22);
            this.password_Textbox.TabIndex = 1;
            this.password_Textbox.UseSystemPasswordChar = true;
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.BackColor = System.Drawing.Color.Black;
            this.username_Label.ForeColor = System.Drawing.Color.White;
            this.username_Label.Location = new System.Drawing.Point(173, 161);
            this.username_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(71, 16);
            this.username_Label.TabIndex = 2;
            this.username_Label.Text = "Username";
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.BackColor = System.Drawing.Color.Black;
            this.password_Label.ForeColor = System.Drawing.Color.White;
            this.password_Label.Location = new System.Drawing.Point(173, 242);
            this.password_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(68, 16);
            this.password_Label.TabIndex = 3;
            this.password_Label.Text = "Password";
            // 
            // title_Label
            // 
            this.title_Label.AutoSize = true;
            this.title_Label.BackColor = System.Drawing.Color.Black;
            this.title_Label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Label.ForeColor = System.Drawing.Color.White;
            this.title_Label.Location = new System.Drawing.Point(143, 75);
            this.title_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(98, 25);
            this.title_Label.TabIndex = 4;
            this.title_Label.Text = "Welcome";
            // 
            // login_Btn
            // 
            this.login_Btn.BackColor = System.Drawing.Color.Black;
            this.login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_Btn.ForeColor = System.Drawing.Color.White;
            this.login_Btn.Location = new System.Drawing.Point(156, 337);
            this.login_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(95, 27);
            this.login_Btn.TabIndex = 5;
            this.login_Btn.Text = "Login";
            this.login_Btn.UseVisualStyleBackColor = false;
            this.login_Btn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // invalidUser_Label
            // 
            this.invalidUser_Label.AutoSize = true;
            this.invalidUser_Label.ForeColor = System.Drawing.Color.Red;
            this.invalidUser_Label.Location = new System.Drawing.Point(104, 405);
            this.invalidUser_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invalidUser_Label.Name = "invalidUser_Label";
            this.invalidUser_Label.Size = new System.Drawing.Size(202, 16);
            this.invalidUser_Label.TabIndex = 6;
            this.invalidUser_Label.Text = "Incorrect username or password!";
            this.invalidUser_Label.Visible = false;
            // 
            // LoginFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(424, 481);
            this.Controls.Add(this.invalidUser_Label);
            this.Controls.Add(this.login_Btn);
            this.Controls.Add(this.title_Label);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.username_Label);
            this.Controls.Add(this.password_Textbox);
            this.Controls.Add(this.userName_Texbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFormMain_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName_Texbox;
        private System.Windows.Forms.TextBox password_Textbox;
        private System.Windows.Forms.Label username_Label;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.Button login_Btn;
        private System.Windows.Forms.Label invalidUser_Label;
    }
}

