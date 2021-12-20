using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoTheFjordClassLibrary
{
    public class Peasant : Enemy
    {

        public Peasant()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Peasant";
            Life = 6;
            HitChance = 20;
            Block = 2;
            MinDamage = 1;
            Description = "Even the peasants will fight but they are just simple folk.";
        }
        public Peasant(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) { }
    }//End Class
}
