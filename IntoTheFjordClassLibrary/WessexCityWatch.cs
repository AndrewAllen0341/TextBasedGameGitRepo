using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoTheFjordClassLibrary
{
    public class WessexCityWatch : Enemy
    {

        public WessexCityWatch()
        {
            MaxLife = 20;
            MaxDamage = 16;
            Name = "Wessex Watchman";
            Life = 20;
            HitChance = 40;
            Block = 5;
            MinDamage = 5;
            Description = "These warrior are trained to fight in cities and are the local police force as well.\n";
        }
        public WessexCityWatch(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) { }

    }
}
