using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text.Trim(),
                    placeNumberValue.Text.Trim(),
                    prizeAmountValue.Text.Trim(),
                    prizePercentageValue.Text.Trim()
                    );

                GlobalConfig.Connection.CreatePrize( model );

                // clear out the form
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";

                MessageBox.Show("You have succesfully created a Prize.");
            }
            else
            {
                MessageBox.Show("You have entered invalid information. Please try again!");
            }
        }

        private bool Validation()
        {
            bool output = true;
            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text.Trim(), out placeNumber);
            bool prizeAmountValidNumber = decimal.TryParse(prizeAmountValue.Text.Trim(), out prizeAmount);
            bool prizePercentageValidNumber = double.TryParse(prizePercentageValue.Text.Trim(), out prizePercentage);


            if (!placeNumberValidNumber) 
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValue.Text.Trim().Length == 0)
            {
                output = false;
            }

            if (!prizeAmountValidNumber || !prizePercentageValidNumber)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage < 0)
            {
                output = false;
            }

            if (prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
