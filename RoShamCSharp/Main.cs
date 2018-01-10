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
        private int tab1win1count = 0, tab1win2count = 0, tab1tieCount = 0;
        private int tab2win1count = 0, tab2win2count = 0, tab2tieCount = 0;

        private void frmMain_Load(object sender, EventArgs e)
        {
            //sets the combo boxes to a default value
            //Find another way to do this? 
            cboTab2P1Pick.SelectedIndex = 0;
            cboPlayer2.SelectedIndex = 0;
            cboTab3P1Pick.SelectedIndex = 0;

            //removes border from win labels on all tabs
            //assigns the default text for all win labels
            //The border is only there so I can find it in designer.
            #region tab1

            lblTab1Win1.BorderStyle = 0;
            lblTab1Win1.Text = "Player 1 Wins: " + tab1win1count;

            lblTab1Win2.BorderStyle = 0;
            lblTab1Win2.Text = "Player 2 Wins: " + tab1win2count;

            lblTab1Tie.BorderStyle = 0;
            lblTab1Tie.Text = "Ties: " + tab1tieCount;

            #endregion

            #region tab2

            lblTab2Win1.BorderStyle = 0;
            lblTab2Win1.Text = "Player 1 Wins: " + tab2win1count;

            lblTab2Win2.BorderStyle = 0;
            lblTab2Win2.Text = "Player 2 Wins: " + tab2win2count;

            lblTab2Tie.BorderStyle = 0;
            lblTab2Tie.Text = "Ties: " + tab2tieCount;

            #endregion

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

            switch (GameLogic.pickWin(aiChoice, a2Choice))
            {
                case "Player 1 Wins!":
                    tab1win1count++;
                    lblTab1Win1.Text = "Player 1 Wins: " + tab1win1count;
                    break;
                case "Player 2 Wins!":
                    tab1win2count++;
                    lblTab1Win2.Text = "Player 2 Wins: " + tab1win2count;
                    break;
                default:
                    tab1tieCount++;
                    lblTab1Tie.Text = "Ties: " + tab1tieCount;
                    break;
            }

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
            if (cboTab2P1Pick.SelectedIndex == 0 || cboPlayer2.SelectedIndex == 0)
            {
                MessageBox.Show("You must select an option for player 1 and player 2.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                player1Choice = options[cboTab2P1Pick.SelectedIndex - 1];
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

                switch (GameLogic.pickWin(player1Choice, player2Choice))
                {
                    case "Player 1 Wins!":
                        tab2win1count++;
                        lblTab2Win1.Text = "Player 1 Wins: " + tab2win1count;
                        break;
                    case "Player 2 Wins!":
                        tab2win2count++;
                        lblTab2Win2.Text = "Player 2 Wins: " + tab2win2count;
                        break;
                    default:
                        tab2tieCount++;
                        lblTab2Tie.Text = "Ties: " + tab2tieCount;
                        break;
                }

                lblTab2Win.Text = GameLogic.pickWin(player1Choice, player2Choice);
                lblTab2Win.Visible = true;
            }
        }

        #endregion

        //Battle game tab 
        //***1 PERSON ONLY FOR CONVIENCE***
        //Pokemon style battle between user and ai

        #region Battle Game

        private void cboTab3P1Pick_SelectedIndexChanged(object sender, EventArgs e)
        {
            string p1Option = "";
            try
            {
                p1Option = options[cboTab3P1Pick.SelectedIndex - 1];
            }
            catch (IndexOutOfRangeException)
            {
              
            }

            picTab3p1.Image = GameLogic.p1Picture(p1Option);
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            string aiChoice = options[random.Next(0, 3)];
            picTab3p2.Image = GameLogic.p2Picture(aiChoice);
            lblTab3p2pick.Text = "Player 2 Pick:" + aiChoice;
        }

        #endregion
    } 
}
