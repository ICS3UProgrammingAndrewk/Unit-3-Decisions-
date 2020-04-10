/*
 * Created by: Andrew Kuekam
 * Created on: 2020-04-07
 * Created for: ICS3U Programming
 * Daily Assignment – Day 22 - Perfect Squares
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

namespace PerfectsquareAndrew
{
    public partial class frmPerfectSquares : Form
    {
        public frmPerfectSquares()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare variable
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInterger;

            // set the initial value to 0
            value = 0;

            // clear items in the list box
            this.lstPerfertSquares.Items.Clear();

            // get the user end value selection from the number up_down box
            endingValue = Convert.ToInt32(this.nudNumber.Value);

            // continue stating any perfect squares between the win and user selection value
            while (value <= endingValue)
            {
                // increment the value by 1
                value = value + 1;

                // take the square root
                squareRootAsDouble = Math.Sqrt(value);

                // covert the double to an interger
                squareRootAsInterger = Convert.ToInt32(squareRootAsDouble);

                // the value has to be perfect square
                if (squareRootAsInterger == squareRootAsDouble)
                {
                    this.lstPerfertSquares.Items.Add(value + " is aperfect square");

                    // refresh from
                    this.Refresh();
                }
            }

        }
    }
}
