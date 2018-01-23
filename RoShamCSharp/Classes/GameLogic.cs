using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamCSharp
{
    public static class GameLogic
    {  
        public static string pickWin(string p1Option, string p2Option)
        {
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
                        return "Player 1 Wins!";
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
                        return "Player 1 Wins!";
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
                        return "Player 1 Wins!";
                    }
                    break;
                default:
                    return "Something went wrong here.";
                    break;
            }
        }

        public static Image p1Picture(string p1Option)
        {
            switch (p1Option.ToLower())
            {
                case "rock":
                {
                    return RoShamCSharp.Properties.Resources.p1Rock;
                    break;
                }
                case "paper":
                {
                    return RoShamCSharp.Properties.Resources.p1Paper;
                    break;
                }
                case "scissors":
                {
                    return RoShamCSharp.Properties.Resources.p1Scissors;
                    break;
                }
                default:
                {
                    return null;
                }
            }

        }

        public static Image p2Picture(string p2Option)
        {
            switch (p2Option.ToLower())
            {
                case "rock":
                {
                    return RoShamCSharp.Properties.Resources.p2Rock;
                    break;
                }
                case "paper":
                {
                    return RoShamCSharp.Properties.Resources.p2Paper;
                    break;
                }
                case "scissors":
                {
                    return RoShamCSharp.Properties.Resources.p2Scissors;
                    break;
                }
                default:
                {
                    return null;
                }
            }
        }

        public static object getFighter(string option) {
            
        }
    }
}
