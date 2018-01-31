using System;
using System.Windows.Forms;
using RoShamCSharp.Classes;
using RoShamCSharp.Classes.Moves;


//ROSHAMCSHARP developed by Scott Goes
//This program is a more improved version of my roshambo game
//in python. 

namespace RoShamCSharp
{
    public partial class frmMain : Form
    {
        #region Vars

        //Object creation
        private Random random = new Random();
        private frmFormatting matFor = new frmFormatting();

        //arrays
        private string[] options = { "Rock", "Paper", "Scissors" };

        //possibly use formatting class to eliminate this code.
        private int tab1win1count = 0, tab1win2count = 0, tab1tieCount = 0;
        private int tab2win1count = 0, tab2win2count = 0, tab2tieCount = 0;

        //initalize
        private string aiChoice = "";
        private string p1Option = "";

        #endregion
        
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

        /// <summary>
        /// exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #region AiGame
        /// <summary>
        /// This only plays the AI game, no player input required.
        /// </summary>

        private void btnAi_Click(object sender, EventArgs e)
        {
            //vars needed to run the game
            aiChoice = options[random.Next(0, 3)];
            string a2Choice = options[random.Next(0, 3)];

            //determines picture based on what the AI picked
            picTab1p1.Image = StaticLogic.p1Picture(aiChoice);
            picTab1p2.Image = StaticLogic.p2Picture(a2Choice);

            //sets what the player picked and determines the winner
            lblTab1p1pick.Text = matFor.strP1Pick(aiChoice);
            lblTab1p2pick.Text = matFor.strP2Pick(a2Choice);

            switch (StaticLogic.pickWin(aiChoice, a2Choice))
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

            lblTab1Win.Text = StaticLogic.pickWin(aiChoice, a2Choice);
            lblTab1Win.Visible = true;
        }

        #endregion
        
        #region PlayerGame

        /// <summary>
        /// This tab allows 1vai or 1v1 game.
        /// </summary>
        /// <remarks>
        /// Having the 1v1 really isn't that great because both
        /// users can see the others pick, but I have it in because.
        /// </remarks>
        
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

                lblTab2p1pick.Text = matFor.strP1Pick(player1Choice);
                lblTab2p2pick.Text = matFor.strP1Pick(player2Choice);

                picTab2p1.Image = StaticLogic.p1Picture(player1Choice);
                picTab2p2.Image = StaticLogic.p2Picture(player2Choice);

                switch (StaticLogic.pickWin(player1Choice, player2Choice))
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
                lblTab2Win.Text = StaticLogic.pickWin(player1Choice, player2Choice);
                lblTab2Win.Visible = true;
            }
        }

        #endregion

        #region Battle Game

        #region BattleVars

        private Moves moves = new Moves();
        public int[] p1Fighter = new int[3];
        public int[] p2Fighter = new int[3];

        #endregion

        /// <summary>
        /// Pokemon style battle between user and ai
        /// </summary>
        /// <remarks>
        /// ***1 PERSON ONLY FOR CONVIENCE***
        /// </remarks>

        private void cboTab3P1Pick_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                p1Option = options[cboTab3P1Pick.SelectedIndex - 1];
            }
            catch (IndexOutOfRangeException)
            {
            }

            if (cboTab3P1Pick.SelectedIndex == 0)
            {
                picTab3p1.Visible = false;
                picTab3p1.Image = null;
            }
            else
            {
                picTab3p1.Image = StaticLogic.p1Picture(p1Option);
                picTab3p1.Visible = true;
            }
        }
        
        private void btnBattle_Click(object sender, EventArgs e)
        {
            if (picTab3p1.Image == null)
            {
                return;
            }

            startGame();

            aiChoice = options[random.Next(0, 3)];
            picTab3p2.Image = StaticLogic.p2Picture(aiChoice);
            lblTab3p2pick.Text = matFor.strP2Pick(aiChoice);

            //[health, attack, defence]
            p1Fighter = StaticLogic.getFighter(p1Option);
            p2Fighter = StaticLogic.getFighter(aiChoice);

            lblP1Health.Text = matFor.strHealth(p1Fighter[0]);
            lblP2Health.Text = matFor.strHealth(p2Fighter[0]);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (checkMove() != 3)
            {
                playerMove(checkMove());
                aiMove();
            }
            else
            {
                lblTab3win.Text = "You gave up.";
            }
            

            if (!string.IsNullOrEmpty(lblTab3win.Text))
            {
                resetGame();
            }
        }

        private int checkMove()
        {
            if (rdoTackle.Checked)
            {
                return 0;
            }
            else if (rdoDefend.Checked)
            {
                return 1;
            }
            else if (rdoHeal.Checked)
            {
                return 2;
            }
            else if(rdoLolRip.Checked)
            {
                return 3;
            }
            return 4;
        }

        private void playerMove(int moveChoice)
        {
            object[] moveOption =
            {
                moves.tackle(),
                moves.defence(p1Option),
                moves.heal(),
                moves.giveup()
            };

            switch (moveChoice)
            {
                case 0:
                    if (moveOption[moveChoice] is int)
                    {
                        p2Fighter[0] = p2Fighter[0] - Convert.ToInt16(moveOption[0]);
                        lblP2Health.Text = matFor.strHealth(p2Fighter[0]);
                        lblTab3win.Text = StaticLogic.battleWin(p1Fighter[0], p2Fighter[0]);
                        lblStatus.Text = matFor.tackle(Convert.ToInt16(moveOption[0]));
                    }
                    else
                    {
                        lblStatus.Text = Convert.ToString(moveOption[0]);
                    }
                    break;
                case 2:
                    lblStatus.Text = matFor.heal(Convert.ToInt16(moveOption[2]));
                    p1Fighter[0] += Convert.ToInt16(moveOption[2]);
                    if (p1Fighter[0] > 60)
                    {
                        p1Fighter[0] = 60;
                    }
                    lblP1Health.Text = matFor.strHealth(p1Fighter[0]);
                    break;
                
            }
        }

        private void aiMove()
        {
            object[] moveOption =
            {
                moves.tackle(),
                //moves.defence(aiChoice)
                moves.heal()
            };

            int pickMove = random.Next(0, 2); /*random.Next(0, 2)*/

            switch (pickMove)
            {
                case 0:
                    if (moveOption[pickMove] is int)
                    {
                        p1Fighter[0] = p1Fighter[0] - Convert.ToInt16(moveOption[0]);
                        lblP1Health.Text = matFor.strHealth(p1Fighter[0]);
                        lblTab3win.Text = StaticLogic.battleWin(p1Fighter[0], p2Fighter[0]);
                        lblAi.Text = matFor.tackle(Convert.ToInt16(moveOption[0]));
                    }
                    else
                    {
                        lblAi.Text = Convert.ToString(moveOption[0]);
                    }
                    break;
                case 1:
                    lblAi.Text = matFor.heal(Convert.ToInt16(moveOption[1]));
                    p2Fighter[0] += Convert.ToInt16(moveOption[1]);
                    if (p2Fighter[0] > 60)
                    {
                        p2Fighter[0] = 60;
                    }
                    lblP2Health.Text = matFor.strHealth(p2Fighter[0]);
                    break;

            }

            if (!string.IsNullOrEmpty(lblTab3win.Text))
            {
                resetGame();
            }
        }

        private void startGame()
        {
            cboTab3P1Pick.Enabled = false;
            btnBattle.Visible = false;
            grpMove.Visible = true;
            rdoTackle.Checked = true;
            lblP2Health.Visible = true;
            lblTab3win.Visible = false;
            lblTab3win.Text = null;
            lblStatus.Visible = true;
            lblAi.Visible = true;
        }

        private void resetGame()
        {
            grpMove.Visible = false;
            lblTab3win.Visible = true;
            btnBattle.Visible = true;
            cboTab3P1Pick.Enabled = true;
            cboTab3P1Pick.SelectedIndex = 0;
            picTab3p1.Image = null;
            picTab3p2.Image = null;
            lblTab3p2pick.Text = matFor.strP2Pick(null);
            lblP2Health.Visible = false;
            lblStatus.Visible = false;
            lblStatus.Text = null;
            lblAi.Visible = false;
            lblAi.Text = null;
        }

        #endregion

    } 
}
