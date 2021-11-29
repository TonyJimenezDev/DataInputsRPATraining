using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataInputsRPATraining
{
    public partial class ChinaInventory : Form
    {

        public ChinaInventory()
        {
            InitializeComponent();
        }

        private void ChinaSubmit_Btn_Click(object sender, EventArgs e)
        {
            try
            {                
                InputData.ChinaCostCentre = double.Parse(chinaCostCentre_TB.Text);
                InputData.ChinaProduct = chinaProductCode_TB.Text;
                InputData.ChinaQuantity += int.Parse(chinaQuantity_TB.Text);
                InputData.ChinaUnitPrice += double.Parse(chinaUnitPrice_TB.Text);
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
                chinaCostCentre_TB.Clear();
                chinaProductCode_TB.Clear();
                chinaQuantity_TB.Clear();
                chinaUnitPrice_TB.Clear();
            }
        }

        private void Back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountryForm countryForm = new CountryForm();
            countryForm.Show();
            this.Close();
        }

        private void ChinaInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2) Application.Exit();
        }
    }
}
