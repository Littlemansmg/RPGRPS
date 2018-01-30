using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoShamCSharp
{
    public class Moves
    {
        Rock rock = new Rock();
        Paper paper = new Paper();
        Scissors scissors = new Scissors();
        Random random = new Random();
        public object tackle()
        {
            //string name = "Tackle";
            int damage = random.Next(3,10) ;
            int accuracy = 80;
            int hit = random.Next(0, 100);

            if (hit < accuracy)
            {
                return damage;
            }
            else
            {
                return "Tackle Missed!";
            }
        }

        public int defence(string fighter)
        {
            switch (fighter.ToLower())
            {
                case "rock":
                    return rock.defence;

                case "paper":
                    return paper.defence;

                case "scissors":
                    return scissors.defence;
                default:
                    return 0;
            }
        }

        public int heal()
        {
            return 1;
        }

        public int giveup()
        {
            return 0; 
        }
    }
}
