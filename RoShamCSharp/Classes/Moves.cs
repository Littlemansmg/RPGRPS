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
        Random accRandom = new Random();
        public int tackle()
        {
            //string name = "Tackle";
            int damage = 4;
            int accuracy = 80;

            int hit = accRandom.Next(0, 100);

            if (hit < accuracy)
            {
                return damage;
            }
            else
            {
                return 0;
            }



        }
    }
}
