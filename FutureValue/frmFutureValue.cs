using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        /* Wendy Faulk
         * 5/11/2021 (saved incorrectly) redo: 5/14/2021 
         * Week 4 Murach Practice Assignments (Individual)
         * Exercise 6-1 Enhance the Future Value application 
         */

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            int numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);

            int months = numberOfYears * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            // Step 6. Modify code in btnCalculate_Click.
            decimal futureValue = CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        // Step 5. Create a method to calculate the future value
        private decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthyInterestRate);
            }
            return futureValue;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Step 9. Enter statement to clear the Future Value text box.
        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }
    }
}
