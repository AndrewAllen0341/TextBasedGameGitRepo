using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoTheFjordClassLibrary
{
    public class WessexNoble : Enemy
    {

        public WessexNoble()
        {
            MaxLife = 25;
            MaxDamage = 15;
            Name = "Wessex Noble";
            Life = 25;
            HitChance = 35;
            Block = 10;
            MinDamage = 1;
            Description = "These warriors are much better trained and buy their own armor.\n";
        }
        public WessexNoble(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) { }

    }
}
