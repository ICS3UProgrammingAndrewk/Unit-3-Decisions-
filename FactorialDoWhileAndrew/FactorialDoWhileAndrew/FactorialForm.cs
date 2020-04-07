/*
 * Created by: Andrew Kuekam
 * Created on: 2020-04-04
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
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

namespace FactorialDoWhileAndrew
{
    public partial class frmFactorialDoWhle : Form
    {
        public frmFactorialDoWhle()
        {
            InitializeComponent();
            // Hide lade
            this.lblAnswer.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Show lbl
            this.lblAnswer.Show();

            // declare local variables
            Double factorialAnswer;
            Double factoriaNumber;
            int factorialCounter;

            // clear the items fro the listbox
            this.lstFactorialNumbers.Items.Clear();

            //initialize the final answer to 1
            factorialAnswer = 1;

            // get the number fromthe user
            factoriaNumber = Convert.ToDouble(this.txtNumber.Text);

            // set the counter to 0
            factorialCounter = 0;

            // multiply the country by the next increamented
            do
            {
                // increment the country by 1
                factorialCounter = factorialCounter + 1;

                // list the counter number in the listbox for the user to see
                lstFactorialNumbers.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;

            } while (factorialCounter < factoriaNumber);

            // convert the factorialAnswer to a String and insert it into the label
            this.lblAnswer.Text = this.txtNumber.Text + " ! = " + Convert.ToString(factorialAnswer);

        }
    }
}
