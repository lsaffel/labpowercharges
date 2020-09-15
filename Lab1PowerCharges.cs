using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1PowerCharges
{

    /*
     * Windows Forms App
     * Author: Lisa Saffel
     * Date: June 24, 2020
     * Purpose: To calculate and display total power charges for a residential, commercial or industrial customer
     * 
     * */
    public partial class Lab1PowerCharges : Form
    {

        public Lab1PowerCharges()
        {
            InitializeComponent();
        }


        // exits the application when the Exit button is clicked on the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();       // exit the application
        }

        // calculates the rate for a residential customer when the calculate button is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double RES_FLAT_RATE = 6;             // flat rate for residential customer
            const double RES_POWER_RATE = 0.052;        // power rate for residential customer
            const double COMM_FLAT_RATE = 60;           // flat rate for commercial customer
            const double COMM_POWER_RATE = 0.045;       // power rate for commercial customer
            const double IND_FLAT_RATE_PEAK = 76;       // flat rate for peak hours for industrial customer
            const double IND_FLAT_RATE_OFFPEAK = 40;    // flat rate for off peak hours for industrial customer
            const double IND_POWER_RATE_PEAK = 0.065;       // power rate for peak hours for industrial customer
            const double IND_POWER_RATE_OFFPEAK = 0.028;    // power rate for off peak hours for industrial customer

            int kwhUsedResComm;          // the input number of kwh for a residential or commercial customer
            double totalCharges;            // the total amount that will be charged to the customer
            double kwhIndustrialPeak;       // the input number of the kwh for an industrial customer for peak hours
            double kwhIndustrialOffPeak;    // the input number of the kwh for an industrial customer for off peak hours
            double industrialPeakCharges;   // the charges for an industrial customer for peak hours
            double industrialOffPeakCharges;   // the charges for an industrial customer for off peak hours

            // calculate the total charges for either residential, commercial or industrial,
            // based on which customer type radio button is selected (residential, commercial or industrial)
            if (rdoResidential.Checked)     // calculate the charges for a residential customer 
                                            // and display the result to the total charges box
            {
                // check that the kwh input value is provided and make sure that it is non-negative
                if (Validator.IsProvided(txtKwhResComm, "Kwh Used") &&
                 Validator.IsNonNegativeInt(txtKwhResComm, "Kwh Used")
                  )

                    CalculateResCharges(RES_FLAT_RATE, RES_POWER_RATE, out kwhUsedResComm, out totalCharges);
            }
            else if (rdoCommercial.Checked)     // calculate the charges for a commercial customer
                                                // and display the result to the total charges box
            {
                // check that the kwh input value is provided and make sure that it is non-negative
                if (Validator.IsProvided(txtKwhResComm, "Kwh Used") &&
                Validator.IsNonNegativeInt(txtKwhResComm, "Kwh Used")
                 )

                    CalculateCommCharges(COMM_FLAT_RATE, COMM_POWER_RATE, out kwhUsedResComm, out totalCharges);
            }
            else                  // calculate the charges for an industrial customer, for peak and off peak hours
            {
                // check that each value is provided and make sure that both are non-negative
                if (Validator.IsProvided(txtKwhIndPeak, "Peak Hours Kwh Used") &&
                    Validator.IsProvided(txtKwhIndOffPeak, "Off-peak Kwh Used") &&
                    Validator.IsNonNegativeDouble(txtKwhIndPeak, "Kwh Used") &&
                    Validator.IsNonNegativeDouble(txtKwhIndOffPeak, "Kwh Used")
                    )
 
                    // the input is good, therefore do the calculation
                   CalculateIndustrialCharges(IND_FLAT_RATE_PEAK, IND_FLAT_RATE_OFFPEAK, IND_POWER_RATE_PEAK, IND_POWER_RATE_OFFPEAK, out totalCharges, out kwhIndustrialPeak, out kwhIndustrialOffPeak, out industrialPeakCharges, out industrialOffPeakCharges);
            }

        }

        // calculate the total charges for an industrial customer, including both peak and off-peak hours
        // and display the result to the total charges box
        private void CalculateIndustrialCharges(double IND_FLAT_RATE_PEAK, double IND_FLAT_RATE_OFFPEAK, double IND_POWER_RATE_PEAK, double IND_POWER_RATE_OFFPEAK, out double totalCharges, out double kwhIndustrialPeak, out double kwhIndustrialOffPeak, out double industrialPeakCharges, out double industrialOffPeakCharges)
        {
            // calculate the peak hours charges for an industrial customer
            kwhIndustrialPeak = Convert.ToDouble(txtKwhIndPeak.Text);
            industrialPeakCharges = IND_FLAT_RATE_PEAK;         // initialize the variable to the flat rate
            if (kwhIndustrialPeak > 1000)                       // if the hours are above 1000, add the extra charges
                industrialPeakCharges = industrialPeakCharges + ((kwhIndustrialPeak - 1000) * IND_POWER_RATE_PEAK);

            // calculate the off peak hours charges for an industrial customer
            kwhIndustrialOffPeak = Convert.ToDouble(txtKwhIndOffPeak.Text);
            industrialOffPeakCharges = IND_FLAT_RATE_OFFPEAK;   // initialize the variable to the flat rate
            if (kwhIndustrialOffPeak > 1000)                    // if the hours are above 1000, add the extra charges
                industrialOffPeakCharges = industrialOffPeakCharges + ((kwhIndustrialOffPeak - 1000) * IND_POWER_RATE_OFFPEAK);

            // add together the charges for an industrial customer for peak and off peak hours
            totalCharges = industrialPeakCharges + industrialOffPeakCharges;

            txtTotalCharges.Text = totalCharges.ToString("c");      // display the total charges as currency
                                                                    // to the total charges text box
        }

        // calculate the total charges for a residential customer
        private void CalculateResCharges(double resFlatRate, double resPowerRate, out int kwhUsedRes, out double totalCharges)
        {
            kwhUsedRes = Convert.ToInt32(txtKwhResComm.Text);              // convert text input kwh to a double
            totalCharges = resFlatRate + (kwhUsedRes * resPowerRate);   // add flat rate + power rate
            txtTotalCharges.Text = totalCharges.ToString("c");                  // display total charges as currency
        }

        // calculate the total charges for a commercial customer
        private void CalculateCommCharges(double commFlatRate, double commPowerRate, out int kwhUsedComm, out double totalCharges)
        {
            kwhUsedComm = Convert.ToInt32(txtKwhResComm.Text);              // convert text input kwh to a double

            totalCharges = commFlatRate;            // initialize the total charges to the flat rate

            if (kwhUsedComm > 1000)                // if the hours used are greater than 1000, charge 
                                                    // extra for those hours above 1000
            {
                totalCharges = totalCharges + (kwhUsedComm - 1000) * commPowerRate;
            }
           
 //               totalCharges = commFlatRate + (kwhUsedComm * commPowerRate);   // add flat rate + power rate

            txtTotalCharges.Text = totalCharges.ToString("c");                  // display total charges as currency
        }


        // clears the values in the form, sets the focus back to the input kwh textbox
        // and sets the residential radio button to checked
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKwhResComm.Text = "";                // clear the entered kwh back to blank, no value
            txtTotalCharges.Text = "";              // clear out the output total charges to blank, no value
            txtKwhIndPeak.Text = "";                // clear out the industrial peak hours to blank, no value
            txtKwhIndOffPeak.Text = "";             // clear out the industrial off-peak hours to blank, no value
            txtKwhResComm.Focus();                  // put the focus back onto the input box to enter the number of hours
            rdoResidential.Checked = true;          // set the default back to a residential customer
        }

  

        // the industrial radio button has been selected, therefore
        // hide the residential / commercial panel and show the industrial panel, to input the kwh correctly
        private void rdoIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            pnlResidentialCommercial.Visible = false;
            pnlIndustrial.Visible = true;
        }

        // the commercial radio button has been selected, therefore
        // show the residential / commercial panel and hide the industrial panel
        private void rdoCommercial_CheckedChanged(object sender, EventArgs e)
        {
            pnlResidentialCommercial.Visible = true;
            pnlIndustrial.Visible = false;
        }

        // the residential radio button has been selected, therefore
        // show the residential / commercial panel and hide the industrial panel
        private void rdoResidential_CheckedChanged(object sender, EventArgs e)
        {
            pnlResidentialCommercial.Visible = true;
            pnlIndustrial.Visible = false;
        }

        // set the initial focus onto the text box to input the kwh
        private void Lab1PowerCharges_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtKwhResComm;
        }
    }
}
