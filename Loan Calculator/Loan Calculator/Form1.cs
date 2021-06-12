using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Calculator
{
    public partial class Form1 : Form
    {
        // We put these variables here so we can use it all functions outside of the form
        decimal loan_amount = 0.00m;
        int number_of_months = 0;
        decimal interest_rate = 0.005m;

        public Form1()
        {
            InitializeComponent();
        }
        private void btn_calc_Click(object sender, EventArgs e)
        {
            // assign new values to the variables.
            // Parse statement take a string and try to interpret as a decimal
            // Try Parse
            if (decimal.TryParse(txt_loanAmount.Text, out loan_amount))
            {
                if(int.TryParse(txt_numberOfMonths.Text, out number_of_months))
                {
                    if (decimal.TryParse(txt_interestRate.Text, out interest_rate))
                    {
                        // success because it ran thru all 3 cases
                        // calculate the loan
                        int counter = 0;
                        while(counter < number_of_months)
                        {
                            loan_amount = loan_amount + loan_amount * interest_rate;
                            listBox1.Items.Add("At month " + counter + " the loan is: " + loan_amount.ToString("c"));
                            counter = counter + 1;
                        }
                        // done with the while loop
                        txt_endingValue.Text = loan_amount.ToString("c");
                    }
                }
            }

            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_endingValue.Text = "";
            txt_interestRate.Text = "";
            txt_loanAmount.Text = "";
            txt_numberOfMonths.Text = "";
            listBox1.Items.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
