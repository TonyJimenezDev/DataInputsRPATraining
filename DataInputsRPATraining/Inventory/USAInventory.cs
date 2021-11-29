using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataInputsRPATraining
{
    public partial class USAInventory : Form
    {
        public USAInventory()
        {
            InitializeComponent();
        }

        private void USASubmit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                InputData.USACostCentre = double.Parse(usaCostCentre_TB.Text);
                InputData.USAProduct = usaProductCode_TB.Text;
                InputData.USAQuantity += int.Parse(usaQuantity_TB.Text);
                InputData.USAUnitPrice += double.Parse(usaUnitPrice_TB.Text);
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
                usaCostCentre_TB.Clear();
                usaProductCode_TB.Clear();
                usaQuantity_TB.Clear();
                usaUnitPrice_TB.Clear();
            }
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountryForm countryForm = new CountryForm();
            countryForm.Show();
            this.Close();
        }

        private void USAInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2) Application.Exit();
        }
    }
}
