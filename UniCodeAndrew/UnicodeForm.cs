/*
 * Created by: Andrew Kuekam
 * Created on: 2020-04-17
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
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

namespace UniCodeAndrew
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            string letters;
            int letterCounter;

            // Create loop to covert each number
            for (letterCounter = 65; letterCounter <= 90; letterCounter++)
            {
                // convert the counter to unicode letter
                letters = Char.ConvertFromUtf32(letterCounter);

                // Add letter with its value to the listbox
                this.lstUnicode.Items.Add(letters + " -> " + letterCounter);

            }
            // Clear the items in listbox
            this.lstUnicode.Items.Clear();
        }
    }
}
