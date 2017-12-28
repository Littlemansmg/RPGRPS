using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamCSharp
{
    public class aiGame
    {
        public string pickWin(string aichoice, string a2choice)
        {
            string aiChoice = aichoice;
            string a2Choice = a2choice;


            switch (aiChoice.ToLower())
            {
                case "rock":
                    if (a2Choice.ToLower() == "paper")
                    {
                        return "Player 2 Wins!";
                    }
                    else if (aiChoice == a2Choice)
                    {
                        return "It's a tie!";
                    }
                    else
                    {
                        return "A winner is " + aiChoice + "!";
                    }

                    break;
                case "paper":
                    if (a2Choice.ToLower() == "scissors")
                    {
                        return "Player 2 Wins!";
                    }
                    else if (aiChoice == a2Choice)
                    {
                        return "It's a tie!";
                    }
                    else
                    {
                        return "A winner is " + aiChoice + "!";
                    }
                    break;
                case "scissors":
                    if (a2Choice.ToLower() == "rock")
                    {
                        return "Player 2 Wins!";
                    }
                    else if (aiChoice == a2Choice)
                    {
                        return "It's a tie!";
                    }
                    else
                    {
                        return "A winner is " + aiChoice + "!";
                    }
                    break;
                default:
                    return "Something went wrong here.";
                    break;
            }
        }
    }
}
