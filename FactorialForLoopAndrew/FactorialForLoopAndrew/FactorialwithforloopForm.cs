/*
 * Created by: Andrew Kuekam
 * Created on: 2020-04-09
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Factorialwithforloop
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

namespace FactorialForLoopAndrew
{
    public partial class frmFactorialwithforloop : Form
    {
        public frmFactorialwithforloop()
        {
            InitializeComponent();
            // Hide the lbl
            this.lblAnswer.Hide();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // show the txt
            lblAnswer.Show();

            //declare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // clear the items from the listBox
            this.lstFactorialNumber.Items.Clear();

            // initialize the final answer to 1
            factorialAnswer = 1;

            // get the number from user
            factorialAnswer = Convert.ToDouble(this.txtNumber.Text);

            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                //display numbers
                this.lstFactorialNumber.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;
            }

            // covert the factorialAnswer to a string and add it to a label
            this.lblAnswer.Text = this.txtNumber.Text + "! =" + Convert.ToSingle(factorialAnswer);

        }
    }
}
