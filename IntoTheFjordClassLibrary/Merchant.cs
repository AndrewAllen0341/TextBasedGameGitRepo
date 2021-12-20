using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoTheFjordClassLibrary
{
    public class Merchant : Enemy
    {

        public Merchant()
        {
            MaxLife = 8;
            MaxDamage = 4;
            Name = "Merchant";
            Life = 8;
            HitChance = 25;
            Block = 3;
            MinDamage = 1;
            Description = "A chubby man with clothes made of fine colors and fabrics.";
        }
        public Merchant(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) { }
    }//End Class
}
