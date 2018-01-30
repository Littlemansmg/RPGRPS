using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoShamCSharp.Classes.Fighters;

namespace RoShamCSharp.Classes
{
    public static class StaticLogic
    {  
        public static Image p1Picture(string p1Option)
        {
            switch (p1Option.ToLower())
            {
                case "rock":
                {
                    return RoShamCSharp.Properties.Resources.p1Rock;;
                }
                case "paper":
                {
                    return RoShamCSharp.Properties.Resources.p1Paper;
                }
                case "scissors":
                {
                    return RoShamCSharp.Properties.Resources.p1Scissors;
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
                }

                case "paper":
                {
                    return RoShamCSharp.Properties.Resources.p2Paper;
                }

                case "scissors":
                {
                    return RoShamCSharp.Properties.Resources.p2Scissors;
                }

                default:
                {
                    return null;
                }
            }
        }

        public static int[] getFighter(string option) {
            switch (option.ToLower())
            {
                case "rock":
                    Rock rock = new Rock();
                    int[] rockstat =
                    {
                        rock.health,
                        rock.attack,
                        rock.defence
                    };
                    return rockstat;

                case "paper":
                    Paper paper = new Paper();
                    int[] papstat = 
                    {
                        paper.health,
                        paper.attack,
                        paper.defence
                    };
                    return papstat;

                case "scissors":
                    Scissors scissors = new Scissors();
                    int[] scissstat = 
                    {
                        scissors.health,
                        scissors.attack,
                        scissors.defence
                    };
                    return scissstat;

                default:
                    return null;
            }
        }

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

                default:
                    return "Something went wrong here.";
            }
        }

        public static string battleWin(int p1Health, int p2Health)
        {
            if (p1Health <= 0)
            {
                return "Player 2 wins!";
            }
            else if (p2Health <= 0)
            {
                return "Player 1 wins!";
            }
            else
            {
                return "";
            }
        }
    }
}
