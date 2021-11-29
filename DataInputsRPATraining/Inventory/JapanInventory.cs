using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataInputsRPATraining
{
    public partial class JapanInventory : Form
    {
        public JapanInventory()
        {
            InitializeComponent();
        }

        private void JapanSubmit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                InputData.JapanCostCentre = double.Parse(japanCostCentre_TB.Text);
                InputData.JapanProduct = japanProductCode_TB.Text;
                InputData.JapanQuantity += int.Parse(japanQuantity_TB.Text);
                InputData.JapanUnitPrice += double.Parse(japanUnitPrice_TB.Text);
                completed_Label.ForeColor = Color.Green;
                completed_Label.Text = "Submitted";
                completed_Label.Visible = true;
            }
            catch (Exception ex)
            {
                completed_Label.ForeColor = Color.Red;
                completed_Label.Visible = true;
                completed_Label.Text = "One of more variable data is not entered or correct.";
                Console.WriteLine(ex.Message);
            }
            finally
            {
                japanCostCentre_TB.Clear();
                japanProductCode_TB.Clear();
                japanQuantity_TB.Clear();
                japanUnitPrice_TB.Clear();
            }
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountryForm countryForm = new CountryForm();
            countryForm.Show();
            this.Close();
        }

        private void JapanInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2) 
                Application.Exit();
        }
    }
}
