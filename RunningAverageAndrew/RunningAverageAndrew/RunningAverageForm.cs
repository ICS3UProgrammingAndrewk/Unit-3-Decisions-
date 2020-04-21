/*
 * Created by: Andrew Kuekam
 * Created on: 2020-04-21
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Running Average
 * This program...
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAverageAndrew
{
    public partial class frmRunningAverage : Form
    {
        // set variables
        double sum = 0;
        double userinput = 0;

        public frmRunningAverage()
        {
            InitializeComponent();
            // hide the lbl
            this.lblAnswer.Hide();
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            // show the lbl
            this.lblAnswer.Show();

            // declare local variables
            double userValue;
            double average;

            // get the user number
            userValue = double.Parse(txtAvrage.Text);

            // increment the number
            userinput++;

            // calculate the average
            sum = sum + userValue;
            average = sum / userinput;

            // display the average of the running
            lblAnswer.Text = Convert.ToString(average);

            // if the user enter -1, display a goodbye message and disable buttons
            if (userValue == -1)
            {
                MessageBox.Show("Running average ended.", "Running Average");
                this.BtnCalculator.Enabled = false;
                this.txtAvrage.Visible = false;
                this.Close();
            }

        }
    }
}
