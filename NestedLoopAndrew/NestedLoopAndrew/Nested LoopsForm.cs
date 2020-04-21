/*
 * Created by: Andrew Kuekam
 * Created on: 2020-04-20
 * Created for: ICS3U Programming
 * Daily Assignment – Day #26 - Numbers Nested Loops
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

namespace NestedLoopAndrew
{
    public partial class frmNestedLoops : System.Windows.Forms.Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int capitalCounter;
            int lowerCounter;
            string capital;
            string lowercase;

            // clear listbox
            this.lstphabets.Items.Clear();

            // loop throught the capital letter from 65 to 90
            for (capitalCounter = 65; capitalCounter <= 90; capitalCounter++)
            {
                // for each of the lower alphabet, loop through 97 to 122 and add it beside it hte second number from 0 to 10
                for (lowerCounter = 97; lowerCounter <= 122; lowerCounter++)
                {
                    capital = Char.ConvertFromUtf32(capitalCounter);
                    lowercase = Char.ConvertFromUtf32(lowerCounter);


                    // display in the listbox
                    this.lstphabets.Items.Add(capitalCounter + " -> " + lowerCounter);
                }
            }
        }
    }
}
