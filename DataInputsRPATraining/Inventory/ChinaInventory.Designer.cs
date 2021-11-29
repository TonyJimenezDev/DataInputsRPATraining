
namespace DataInputsRPATraining
{
    partial class ChinaInventory
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
            this.chinaProductCode_TB = new System.Windows.Forms.TextBox();
            this.chinaQuantity_TB = new System.Windows.Forms.TextBox();
            this.chinaUnitPrice_TB = new System.Windows.Forms.TextBox();
            this.chinaCostCentre_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chinaSubmit_Btn = new System.Windows.Forms.Button();
            this.titleInventory_Label = new System.Windows.Forms.Label();
            this.completed_Label = new System.Windows.Forms.Label();
            this.back_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chinaProductCode_TB
            // 
            this.chinaProductCode_TB.Location = new System.Drawing.Point(187, 128);
            this.chinaProductCode_TB.Margin = new System.Windows.Forms.Padding(4);
            this.chinaProductCode_TB.Name = "chinaProductCode_TB";
            this.chinaProductCode_TB.Size = new System.Drawing.Size(132, 22);
            this.chinaProductCode_TB.TabIndex = 0;
            // 
            // chinaQuantity_TB
            // 
            this.chinaQuantity_TB.Location = new System.Drawing.Point(187, 175);
            this.chinaQuantity_TB.Margin = new System.Windows.Forms.Padding(4);
            this.chinaQuantity_TB.Name = "chinaQuantity_TB";
            this.chinaQuantity_TB.Size = new System.Drawing.Size(132, 22);
            this.chinaQuantity_TB.TabIndex = 1;
            // 
            // chinaUnitPrice_TB
            // 
            this.chinaUnitPrice_TB.Location = new System.Drawing.Point(187, 218);
            this.chinaUnitPrice_TB.Margin = new System.Windows.Forms.Padding(4);
            this.chinaUnitPrice_TB.Name = "chinaUnitPrice_TB";
            this.chinaUnitPrice_TB.Size = new System.Drawing.Size(132, 22);
            this.chinaUnitPrice_TB.TabIndex = 2;
            // 
            // chinaCostCentre_TB
            // 
            this.chinaCostCentre_TB.Location = new System.Drawing.Point(187, 266);
            this.chinaCostCentre_TB.Margin = new System.Windows.Forms.Padding(4);
            this.chinaCostCentre_TB.Name = "chinaCostCentre_TB";
            this.chinaCostCentre_TB.Size = new System.Drawing.Size(132, 22);
            this.chinaCostCentre_TB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(83, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cost Centre";
            // 
            // chinaSubmit_Btn
            // 
            this.chinaSubmit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chinaSubmit_Btn.ForeColor = System.Drawing.Color.White;
            this.chinaSubmit_Btn.Location = new System.Drawing.Point(187, 330);
            this.chinaSubmit_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.chinaSubmit_Btn.Name = "chinaSubmit_Btn";
            this.chinaSubmit_Btn.Size = new System.Drawing.Size(100, 28);
            this.chinaSubmit_Btn.TabIndex = 8;
            this.chinaSubmit_Btn.Text = "Submit";
            this.chinaSubmit_Btn.UseVisualStyleBackColor = true;
            this.chinaSubmit_Btn.Click += new System.EventHandler(this.ChinaSubmit_Btn_Click);
            // 
            // titleInventory_Label
            // 
            this.titleInventory_Label.AutoSize = true;
            this.titleInventory_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.titleInventory_Label.ForeColor = System.Drawing.Color.SeaShell;
            this.titleInventory_Label.Location = new System.Drawing.Point(116, 49);
            this.titleInventory_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleInventory_Label.Name = "titleInventory_Label";
            this.titleInventory_Label.Size = new System.Drawing.Size(153, 24);
            this.titleInventory_Label.TabIndex = 9;
            this.titleInventory_Label.Text = "China\'s Inventory";
            // 
            // completed_Label
            // 
            this.completed_Label.AutoSize = true;
            this.completed_Label.ForeColor = System.Drawing.Color.White;
            this.completed_Label.Location = new System.Drawing.Point(16, 380);
            this.completed_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.completed_Label.Name = "completed_Label";
            this.completed_Label.Size = new System.Drawing.Size(37, 16);
            this.completed_Label.TabIndex = 10;
            this.completed_Label.Text = "Error";
            this.completed_Label.Visible = false;
            // 
            // back_Btn
            // 
            this.back_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_Btn.ForeColor = System.Drawing.Color.White;
            this.back_Btn.Location = new System.Drawing.Point(1, 2);
            this.back_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_Btn.Name = "back_Btn";
            this.back_Btn.Size = new System.Drawing.Size(53, 25);
            this.back_Btn.TabIndex = 22;
            this.back_Btn.Text = "Back";
            this.back_Btn.UseVisualStyleBackColor = true;
            this.back_Btn.Click += new System.EventHandler(this.Back_Btn_Click);
            // 
            // ChinaInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(429, 407);
            this.Controls.Add(this.back_Btn);
            this.Controls.Add(this.completed_Label);
            this.Controls.Add(this.titleInventory_Label);
            this.Controls.Add(this.chinaSubmit_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chinaCostCentre_TB);
            this.Controls.Add(this.chinaUnitPrice_TB);
            this.Controls.Add(this.chinaQuantity_TB);
            this.Controls.Add(this.chinaProductCode_TB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChinaInventory";
            this.Text = "ChinaInventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChinaInventory_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chinaProductCode_TB;
        private System.Windows.Forms.TextBox chinaQuantity_TB;
        private System.Windows.Forms.TextBox chinaUnitPrice_TB;
        private System.Windows.Forms.TextBox chinaCostCentre_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button chinaSubmit_Btn;
        private System.Windows.Forms.Label titleInventory_Label;
        private System.Windows.Forms.Label completed_Label;
        private System.Windows.Forms.Button back_Btn;
    }
}