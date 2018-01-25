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
        Random random = new Random();
        public int tackle()
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
                return 0;
            }
        }

        public int defence()
        {
            return 1;
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
