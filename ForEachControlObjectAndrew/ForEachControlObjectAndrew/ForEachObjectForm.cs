/*
 * Created by: Andrew Kuekam
 * Created on: 2020-04-15
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
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

namespace ForEachControlObjectAndrew
{
    public partial class frmForEachObject : System.Windows.Forms.Form
    {
        public frmForEachObject()
        {
            InitializeComponent();
        }

        private void BtnChangeColour_Click(object sender, EventArgs e)
        {
            // loopo through each object on the  form and make it Blue
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Blue;
            }
        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            // loopo through each object on the  form and make it Blue
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Red;
            }
        }
    }
}
