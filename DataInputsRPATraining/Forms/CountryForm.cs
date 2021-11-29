using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataInputsRPATraining
{
    public partial class CountryForm : Form
    {
        public CountryForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   //Type        Variable              String
            string        name                = "this string";
        }



        private void ConfirmCountry_Btn_Click(object sender, EventArgs e)
        {
            // Type                     // Variable     // Keyword                                          //Array of RadioButton
            RadioButton[]               countryArrayRB = new                RadioButton[3]              { usa_RB, japan_RB, china_RB };


            

                        RadioButton countryBR                   = usa_RB;

            // Loop    //Type           Variable
            foreach (RadioButton        countryRB              in countryArrayRB)
            {
                //  usa_RB.Checked;
                if (countryRB.Checked)
                {
                    
                    Debug.WriteLine("Logged into " + countryRB.Text + ".");


                    // usa_RB.Text "USA"
                    InventorySelection(countryRB.Text.ToLower());
                    break;
                }
                
            }            
           
        }


        private void InventorySelection(string countryName)
        {
            if (countryName.Equals("usa"))
            {
                Debug.WriteLine("Opening USA Form");
                this.Hide();
                USAInventory usaForm = new USAInventory();
                usaForm.Show();
            }
            else if (countryName.Equals("japan"))
            {
                Debug.WriteLine("Opening Japan Form");
                this.Hide();
                JapanInventory japanForm = new JapanInventory();
                japanForm.Show();
            }
            else
            {
                Debug.WriteLine("Opening China Form");
                this.Hide();
                ChinaInventory chinaForm = new ChinaInventory();
                chinaForm.Show();
            }
            this.Close();

        }

        private void CountryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2) Application.Exit();
        }
    }
}
