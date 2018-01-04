using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoShamCSharp
{
    public partial class frmMain : Form
    {
        private Random random = new Random();
        

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This is an exit button. 
            this.Close();
        }

        private void btnAi_Click(object sender, EventArgs e)
        {
            string[] options = new string[] {"Rock", "Paper", "Scissors"};
            string aiChoice = options[random.Next(0, 3)];
            string a2Choice = options[random.Next(0, 3)];

            p1Pic.Image = GameLogic.p1Picture(aiChoice);
            p2Pic.Image = GameLogic.p2Picture(a2Choice);

            lblP1pick.Text = "Player 1 pick: " + aiChoice;
            lblP2pick.Text = "Player 2 pick: " + a2Choice;
            lblWin.Text = GameLogic.pickWin(aiChoice, a2Choice);
        }
    } 
}
