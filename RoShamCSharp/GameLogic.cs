using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamCSharp
{
    public class GameLogic: frmMain
    {
        public string pickWin(string p1Option, string p2Option)
        {
            //string p1Option = p1Option;
            //string p2Option = p2Option;


            switch (p1Option.ToLower())
            {
                case "rock":
                    if (p2Option.ToLower() == "paper")
                    {
                        return "Player 2 Wins!";
                    }
                    else if (p1Option == p2Option)
                    {
                        return "It's a tie!";
                    }
                    else
                    {
                        return "A winner is " + p1Option + "!";
                    }

                    break;
                case "paper":
                    if (p2Option.ToLower() == "scissors")
                    {
                        return "Player 2 Wins!";
                    }
                    else if (p1Option == p2Option)
                    {
                        return "It's a tie!";
                    }
                    else
                    {
                        return "A winner is " + p1Option + "!";
                    }
                    break;
                case "scissors":
                    if (p2Option.ToLower() == "rock")
                    {
                        return "Player 2 Wins!";
                    }
                    else if (p1Option == p2Option)
                    {
                        return "It's a tie!";
                    }
                    else
                    {
                        return "A winner is " + p1Option + "!";
                    }
                    break;
                default:
                    return "Something went wrong here.";
                    break;
            }
        }

        public void picPicture()
        {
            p1Pic.Image = RoShamCSharp.Properties.Resources.p1Paper;
            p2Pic.Image = RoShamCSharp.Properties.Resources.p2Rock;
        }

    }
}
