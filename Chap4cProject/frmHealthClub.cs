using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap4cProject
{
    public partial class frmHealthClub : Form
    {
        public frmHealthClub()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare variables.
            decimal decBaseFee, decTotalFee;
            int intMonths;
            bool blnValid = true;
            string strErr = "";
            // Constants for base fees, additional fees, and month limits.
            const decimal decAdultFee = 40, decChildFee = 20, decStudentFee = 25, decSeniorFee = 30;
            const decimal decYogaFee = 10, decKarateFee = 30, decTrainerFee = 50;
            const int intMaxMonths = 24, intMinMonths = 1;
            // Clear old output
            lblMonthlyFee.Text = "";
            lblTotal.Text = "";
            // Parse number of months and validate
            if (!int.TryParse(txtMonths.Text, out intMonths))
            {
                // This code is for when user entered non-integer value
                blnValid = false;
                strErr = "Months must be an integer value.";
            }
            else // User entered integer value
            {
                if (intMonths < intMinMonths || intMonths > intMaxMonths)
                {
                    blnValid = false;
                    strErr = "Months must be in the range " + intMinMonths.ToString() +
                        " to " + intMaxMonths.ToString();
                }
            }
            // If input is valid, then proceed with calculations
            if (blnValid)
            {
                // determine base monthly fee
                if (radAdult.Checked)
                {
                    decBaseFee = decAdultFee;
                }
                else if (radChild.Checked)
                {
                    decBaseFee = decChildFee;
                }
                else if (radStudent.Checked)
                {
                    decBaseFee = decStudentFee;
                }
                else // user chose Senior
                {
                    decBaseFee = decSeniorFee;
                }
                // check for additional fees
                if (chkYoga.Checked)
                {
                    decBaseFee += decYogaFee;
                }
                if (chkKarate.Checked)
                {
                    decBaseFee += decKarateFee;
                }
                if (chkTrainer.Checked)
                {
                    decBaseFee += decTrainerFee;
                }
                // calculate total fee
                decTotalFee = decBaseFee * intMonths;
                // display output
                lblMonthlyFee.Text = decBaseFee.ToString("c");
                lblTotal.Text = decTotalFee.ToString("c");
            }
            else // invalid input
            {
                MessageBox.Show(strErr, "Invalid Input");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            radAdult.Checked = true;
            chkYoga.Checked = false;
            chkKarate.Checked = false;
            chkTrainer.Checked = false;
            txtMonths.Clear();
            lblMonthlyFee.Text = "";
            lblTotal.Text = "";
            radAdult.Focus();
        }

        private void radAdult_CheckedChanged(object sender, EventArgs e)
        {
            lblMonthlyFee.Text = "";
            lblTotal.Text = "";
        }
    }
}
