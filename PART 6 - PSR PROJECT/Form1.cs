using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PART_6___PSR_PROJECT
{
    public partial class frmRPS : Form
    {
        int PlayerChoice;
        int Numberchoice;
      


       

        public frmRPS()
        {
            InitializeComponent();
        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.rock;
            lblChoice.Text = ("You chose rock!!");
            PlayerChoice = 1;
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;
            lblChoice.Text = ("You chose Paper!!");
            PlayerChoice = 2;
        }

        private void radSciccors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.sciccors;
            lblChoice.Text = ("You chose sciccors!!");
            PlayerChoice = 3;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int PCChoice;
            Random rnd = new Random();
            PCChoice = rnd.Next(1, 4);
            switch (PCChoice)
            {
                case 1:
                    imgPC.Image = Properties.Resources.rock;
                    lblPCChoice.Text = ("Computer chose Rock");
                    Numberchoice = 1;
                   
                    break;
                case 2:
                    imgPC.Image = Properties.Resources.paper;
                    lblPCChoice.Text = ("Computer chose Paper");
                    Numberchoice = 2;
                    break;
                case 3:
                    imgPC.Image = Properties.Resources.sciccors;
                    lblPCChoice.Text = ("Computer chose Sciccors");
                    Numberchoice = 3;
                    break;

                default:
                    break;          
            }

            // IF ITS A TIE
            if (PlayerChoice == Numberchoice)
            {
                lblInstructions.Text = ("TIE!");
                btnPlay.Enabled = false;
            }
            //ROCKS CODE
            if (PlayerChoice == 1 && Numberchoice == 2)
            {
                lblInstructions.Text = ("PAPER WINS!");
                btnPlay.Enabled = false;
            }
            if(PlayerChoice == 1 && Numberchoice == 3)
            {
                lblInstructions.Text = ("ROCK WINS!");
                btnPlay.Enabled = false;
            }
            //PAPERS CODE
            if (PlayerChoice == 2 && Numberchoice == 1)
            {
                lblInstructions.Text = ("PAPER WINS!");
                btnPlay.Enabled = false;
            }
            if (PlayerChoice == 2 && Numberchoice == 3)
            {
                lblInstructions.Text = ("SCICCORS WINS!");
                btnPlay.Enabled = false;
            }
            //SCICCORS CODE
            if (PlayerChoice == 3 && Numberchoice == 1)
            {
                lblInstructions.Text = ("ROCK WINS!");
                btnPlay.Enabled = false;
            }
            if (PlayerChoice == 4 && Numberchoice == 2)
            {
                lblInstructions.Text = ("SCICCORS WINS!");
                btnPlay.Enabled = false;
            }
        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.question;
            imgPC.Image = Properties.Resources.question;

            lblInstructions.Text = ("Please Make A Selection");
            lblChoice.Text = ("You Chose");
            lblPCChoice.Text = ("PC Chose");
            btnPlay.Enabled = true;


        }
    }
}
