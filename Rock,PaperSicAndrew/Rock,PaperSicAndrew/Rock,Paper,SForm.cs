/*
 * Created by: Andrew Kuekam
 * Created on: 2020-04-02
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
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

namespace Rock_PaperSicAndrew
{
    public partial class frmRps : Form
    {
        // declare global variable and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRps()
        {
            InitializeComponent();
            // create the random number generate object
            randomNumberGenerator = new Random();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // declare local variable and constants
            int playerChoice, computerChoice, Win;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCIRSSORS = 3;

    // get the user selection, If there is no selection set it to 0
            if (radPlayRock.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radPlayPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radPlayScissor.Checked == true)
            {
                playerChoice = SCIRSSORS;
            }
            else
            {
                playerChoice = 0;
            }

            // randomly generate a number 1 and 3, representing ROCK, PAPER or SCISSORS
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // set the radio button fro the computer choice
            if (computerChoice == ROCK)
            {
                this.radComputerRock.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                this.radComputePaper.Checked = true;
            }
            else if (computerChoice == SCIRSSORS)
            {
                this.radComputerScissor.Checked = true;
            }
            else
            {
                computerChoice = 0;

            }
        }
    }
}

