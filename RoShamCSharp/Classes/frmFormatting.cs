using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoShamCSharp.Classes
{
    class frmFormatting
    {
        public string strP1Pick(string p1option)
        {
            String p1Pik = string.Format("Player 1 pick: {0}", p1option);
            return p1Pik;
        }

        public string strP2Pick(string p2option)
        {
            String p2Pik = string.Format("Player 2 pick: {0}", p2option);
            return p2Pik;
        }

        public string strHealth(int health)
        {
            String Health = string.Format("Health: {0}", health);
            return Health;
        }

    }
}
