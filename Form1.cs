using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class PaperScissorsRock : Form
    {
        Random generator = new Random();
        int randNum, playerWins, opponentWins, ties;
       
        public PaperScissorsRock()
        {
            InitializeComponent();
        }


        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Rock;
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;
        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.scissors_2;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
           // 1 - Rock      2 - Paper       3 - Scissors
            randNum = generator.Next(1, 4);

            if (randNum == 1)
            {
                imgOpponent.Image = Properties.Resources.Rock;
            }

            else if (randNum == 2)
            {
                imgOpponent.Image = Properties.Resources.paper;
            }
            else if (randNum == 3)
            {
                imgOpponent.Image = Properties.Resources.scissors_2;
            }



            if (randNum == 1 && radRock.Checked)
            {
                // Tie
                lblResult.Text = "It's a Tie!";
                for (int i = 1; i <= 1; i++)
                {
                    ties = ties + 1;
                    lblTieNum.Text = Convert.ToString(ties);
                }
            }

            else if (randNum == 1 && radPaper.Checked)
            {
                // Player Win
                lblResult.Text = "You Win!";
                for (int i = 1; i <= 1; i++)
                {
                    playerWins = playerWins + 1;
                    lblPlayerWinsNum.Text = Convert.ToString(playerWins);
                }
            }

            else if (randNum == 1 && radScissors.Checked)
            {
                // Opponent Win
                lblResult.Text = "Better Luck Next Time!";
                for (int i = 1; i <= 1; i++)
                {
                    opponentWins = opponentWins + 1;
                    lblOpponentWinsNum.Text = Convert.ToString(opponentWins);
                }
            }

            else if (randNum == 2 && radPaper.Checked)
            {
                // Tie
                lblResult.Text = "It's a Tie!";
                for (int i = 1; i <= 1; i++)
                {
                    ties = ties + 1;
                    lblTieNum.Text = Convert.ToString(ties);
                }
            }

            else if (randNum == 2 && radRock.Checked)
            {
                // Opponent Win
                lblResult.Text = "Better Luck Next Time!";
                for (int i = 1; i <= 1; i++)
                {
                    opponentWins = opponentWins + 1;
                    lblOpponentWinsNum.Text = Convert.ToString(opponentWins);
                }
            }

            else if (randNum == 2 && radScissors.Checked)
            {
                // Player Win
                lblResult.Text = "You Win!";
                for (int i = 1; i <= 1; i++)
                {
                    playerWins = playerWins + 1;
                    lblPlayerWinsNum.Text = Convert.ToString(playerWins);
                }
            }

            else if (randNum == 3 && radScissors.Checked)
            {
                // Tie
                lblResult.Text = "It's a Tie!";
                for (int i = 1; i <= 1; i++)
                {
                    ties = ties + 1;
                    lblTieNum.Text = Convert.ToString(ties);
                }
                    
            }

            else if (randNum == 3 && radRock.Checked)
            {
                // Player Win
                lblResult.Text = "You Win!";
                for (int i = 1; i <= 1; i++)
                {
                    playerWins = playerWins + 1;
                    lblPlayerWinsNum.Text = Convert.ToString(playerWins);
                }
                   
            }

            else if (randNum == 3 && radPaper.Checked)
            {
                // Opponent Win
                lblResult.Text = "Better Luck Next Time!";
                for (int i = 1; i <= 1; i++)
                {
                    opponentWins = opponentWins + 1;
                    lblOpponentWinsNum.Text = Convert.ToString(opponentWins);
                }
            }
            

        }

      
    }
}
