/*
 * Created by: Andrew Kuekam
 * Created on: 2020-04-04
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
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

namespace ChocolateBoxeAndrew
{
    public partial class frmChocolateBox : Form
    {
        public frmChocolateBox()
        {
            InitializeComponent();
            // Hide label
            this.lblReward.Hide();
        }

        private void BtnGetreward_Click(object sender, EventArgs e)
        {
            //show lbl
            this.lblReward.Show();

            //declare variable and constants
            int Boxes;

            // link it to the text box
            Boxes = int.Parse(txtNumberOfBoxes.Text);

            //show the prizes
            if (Boxes > 20 )
            {
                lblReward.Text = " You get a prize";
            }
            
            else if (Boxes < 10 )
            {
                lblReward.Text = " You recived and honorable mention";
            }
            else
            {
                lblReward.Text = " You get a sall prize";
            }

        }
    }
}
