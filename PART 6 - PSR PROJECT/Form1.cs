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
        public frmRPS()
        {
            InitializeComponent();
          
          
            
            

           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.rock;

            lblChoice.Text = ("You chose rock!!");
                



        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;

            lblChoice.Text = ("You chose Paper!!");
        }

        private void radSciccors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.sciccors;
            lblChoice.Text = ("You chose sciccors!!");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int randomInt;
            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);
            switch (randomInt)
            {
                case 1:
                    imgPC.Image = Properties.Resources.rock;
                    lblPCChoice.Text = ("Computer chose Rock");
                   
                    break;
                case 2:
                    imgPC.Image = Properties.Resources.paper;
                    lblPCChoice.Text = ("Computer chose Paper");
                    break;
                case 3:
                    imgPC.Image = Properties.Resources.sciccors;
                    lblPCChoice.Text = ("Computer chose Sciccors");
                    break;

                default:
                    break;



                
                        
            }







        }
    }
}
