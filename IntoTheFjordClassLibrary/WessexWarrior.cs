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
            MaxLife = 50;
            MaxDamage = 30;
            Name = "Wessex Warrior";
            Life = 50;
            HitChance = 45;
            Block = 5;
            MinDamage = 5;
            Description = "These warrior are good enough fighters even if they are farmers first.\n";
        }
        public WessexWarrior(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) { }

    }
}
