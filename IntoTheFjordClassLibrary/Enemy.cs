using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoTheFjordClassLibrary
{
    public class Enemy : PlayerStats
    {
        private int _minDamage;
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value >= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }//End MinDamage
        public Enemy() { }
        public Enemy(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
        {
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Name = name;
            Life = life;
            HitChance = HitChance;
            Block = block;
            Description = description;
            MinDamage = MinDamage;
        }

        public override string ToString()
        {
            return $"\n--- {Name} ---\n" +
                              $"Description: {Description}\n" +
                              $"Life: {Life} / {MaxLife}\n" +
                              $"Damage: {MinDamage} / {MaxDamage}\n" +
                              $"Block: {Block}\n";
        }
        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }
}