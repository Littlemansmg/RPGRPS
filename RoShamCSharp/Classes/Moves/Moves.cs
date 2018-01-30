using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoShamCSharp.Classes.Fighters;

namespace RoShamCSharp.Classes.Moves
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
            return 0;
        }

        public int heal()
        {
            int heal = random.Next(1, 5);
            return heal;
        }

        public int giveup()
        {
            return 0; 
        }
    }
}
