using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ROSHAMCSHARP developed by Scott Goes
//This program is a more improved version of my roshambo game
//in python. 

namespace RoShamCSharp
{
    public partial class frmMain : Form
    {
        private Random random = new Random();
        private string[] options = { "Rock", "Paper", "Scissors" };

        private void frmMain_Load(object sender, EventArgs e)
        {
            //sets the combo boxes to a default value
            //Find another way to do this? 
            cboPlayer1.SelectedIndex = 0;
            cboPlayer2.SelectedIndex = 0;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This is an exit button. 
            this.Close();
        }

        //AiGame Tab
        //This only plays the AI game, no player input required. 
        #region AiGame
        private void btnAi_Click(object sender, EventArgs e)
        {
            //vars needed to run the game
            string aiChoice = options[random.Next(0, 3)];
            string a2Choice = options[random.Next(0, 3)];

            //determines picture based on what the AI picked
            picTab1p1.Image = GameLogic.p1Picture(aiChoice);
            picTab1p2.Image = GameLogic.p2Picture(a2Choice);

            //sets what the player picked and determines the winner
            lblTab1p1pick.Text = "Player 1 pick: " + aiChoice;
            lblTab1p2pick.Text = "Player 2 pick: " + a2Choice;
            lblTab1Win.Text = GameLogic.pickWin(aiChoice, a2Choice);
            lblTab1Win.Visible = true;
        }

        #endregion

        //1/2 Player game tab
        //This tab allows 1vai or 1v1 game. 
        //Having the 1v1 really isn't that great because both 
        //users can see the others pick, but I have it in because.
        #region PlayerGame
        private void btnGame_Click(object sender, EventArgs e)
        {
            string player1Choice;
            string player2Choice;
            if (cboPlayer1.SelectedIndex == 0 || cboPlayer2.SelectedIndex == 0)
            {
                MessageBox.Show("You must select an option for player 1 and player 2.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                player1Choice = options[cboPlayer1.SelectedIndex - 1];
                if (cboPlayer2.SelectedIndex == 1)
                {
                    player2Choice = options[random.Next(0, 3)];
                }
                else
                {
                    player2Choice = options[cboPlayer2.SelectedIndex - 2];
                }

                lblTab2p1pick.Text = "Player 1 pick: " + player1Choice;
                lblTab2p2pick.Text = "Player 2 pick: " + player2Choice;

                picTab2p1.Image = GameLogic.p1Picture(player1Choice);
                picTab2p2.Image = GameLogic.p2Picture(player2Choice);

                lblTab2Win.Text = GameLogic.pickWin(player1Choice, player2Choice);
                lblTab2Win.Visible = true;
            }
        }

        #endregion


    } 
}
