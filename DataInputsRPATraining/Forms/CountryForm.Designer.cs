
namespace DataInputsRPATraining
{
    partial class CountryForm
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
            this.countryQuestion_Label = new System.Windows.Forms.Label();
            this.usa_RB = new System.Windows.Forms.RadioButton();
            this.japan_RB = new System.Windows.Forms.RadioButton();
            this.china_RB = new System.Windows.Forms.RadioButton();
            this.confirmCountry_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countryQuestion_Label
            // 
            this.countryQuestion_Label.AutoSize = true;
            this.countryQuestion_Label.BackColor = System.Drawing.Color.Black;
            this.countryQuestion_Label.ForeColor = System.Drawing.Color.White;
            this.countryQuestion_Label.Location = new System.Drawing.Point(113, 94);
            this.countryQuestion_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryQuestion_Label.Name = "countryQuestion_Label";
            this.countryQuestion_Label.Size = new System.Drawing.Size(173, 16);
            this.countryQuestion_Label.TabIndex = 0;
            this.countryQuestion_Label.Text = "Which country for inventory?";
            // 
            // usa_RB
            // 
            this.usa_RB.AutoSize = true;
            this.usa_RB.ForeColor = System.Drawing.Color.White;
            this.usa_RB.Location = new System.Drawing.Point(164, 161);
            this.usa_RB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usa_RB.Name = "usa_RB";
            this.usa_RB.Size = new System.Drawing.Size(54, 20);
            this.usa_RB.TabIndex = 1;
            this.usa_RB.Text = "USA";
            this.usa_RB.UseVisualStyleBackColor = true;
            // 
            // japan_RB
            // 
            this.japan_RB.AutoSize = true;
            this.japan_RB.ForeColor = System.Drawing.Color.White;
            this.japan_RB.Location = new System.Drawing.Point(164, 214);
            this.japan_RB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.japan_RB.Name = "japan_RB";
            this.japan_RB.Size = new System.Drawing.Size(64, 20);
            this.japan_RB.TabIndex = 2;
            this.japan_RB.Text = "Japan";
            this.japan_RB.UseVisualStyleBackColor = true;
            // 
            // china_RB
            // 
            this.china_RB.AutoSize = true;
            this.china_RB.BackColor = System.Drawing.Color.Black;
            this.china_RB.ForeColor = System.Drawing.Color.White;
            this.china_RB.Location = new System.Drawing.Point(164, 266);
            this.china_RB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.china_RB.Name = "china_RB";
            this.china_RB.Size = new System.Drawing.Size(60, 20);
            this.china_RB.TabIndex = 3;
            this.china_RB.Text = "China";
            this.china_RB.UseVisualStyleBackColor = false;
            // 
            // confirmCountry_Btn
            // 
            this.confirmCountry_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmCountry_Btn.ForeColor = System.Drawing.Color.White;
            this.confirmCountry_Btn.Location = new System.Drawing.Point(148, 343);
            this.confirmCountry_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmCountry_Btn.Name = "confirmCountry_Btn";
            this.confirmCountry_Btn.Size = new System.Drawing.Size(100, 28);
            this.confirmCountry_Btn.TabIndex = 4;
            this.confirmCountry_Btn.Text = "Confirm";
            this.confirmCountry_Btn.UseVisualStyleBackColor = true;
            this.confirmCountry_Btn.Click += new System.EventHandler(this.ConfirmCountry_Btn_Click);
            // 
            // CountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(424, 481);
            this.Controls.Add(this.confirmCountry_Btn);
            this.Controls.Add(this.china_RB);
            this.Controls.Add(this.japan_RB);
            this.Controls.Add(this.usa_RB);
            this.Controls.Add(this.countryQuestion_Label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CountryForm";
            this.Text = "Country Input";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CountryForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryQuestion_Label;
        private System.Windows.Forms.RadioButton usa_RB;
        private System.Windows.Forms.RadioButton japan_RB;
        private System.Windows.Forms.RadioButton china_RB;
        private System.Windows.Forms.Button confirmCountry_Btn;
    }
}