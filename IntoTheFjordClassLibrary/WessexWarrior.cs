using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoTheFjordClassLibrary
{
    public class WessexWarrior : Enemy
    {

        public WessexWarrior()
        {
            MaxLife = 8;
            MaxDamage = 5;
            Name = "Wessex Warrior";
            Life = 8;
            HitChance = 25;
            Block = 5;
            MinDamage = 1;
            Description = "These warrior are good enough fighters even if they are farmers first.\n";
        }
        public WessexWarrior(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) { }

    }
}
