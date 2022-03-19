using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                //names constants
                const decimal MINIMUM_SALARY = 40000m;
                const int MINIMUM_YEARS_ON_JOB = 2;

                //local variables
                decimal salary;
                int yearsOnJob;

                //get the salary and years on the job
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                //determine whether the user qualifies
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        //display message that the user qualifies
                        decisionLabel.Text = "Congratulations! You qualify for the loan.";
                    }
                    else
                    {
                        //user not qualify
                        decisionLabel.Text = "You need a minimum of " + MINIMUM_YEARS_ON_JOB.ToString() + " to qualify.";
                    }
                }
                else
                {
                    decisionLabel.Text = "You need a minimum salary of " + MINIMUM_SALARY.ToString() + " to qualify.";
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            salaryTextBox.Text = ""; //simply way to clear textbox
            yearsTextBox.Clear(); //better way to clear a textBox
            //decisionLabel.Text = ""; //simple way to clear a label
            decisionLabel.Text = string.Empty; 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
