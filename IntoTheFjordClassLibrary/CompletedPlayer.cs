using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoTheFjordClassLibrary
{
    public sealed class CompletedPlayer : PlayerStats
    {
        public Prayer UserPrayer { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public CompletedPlayer(string name, int hitChance, int block, int life, int maxLife, Prayer userPrayer, Weapon equippedWeapon)
        {
            UserPrayer = userPrayer;
            EquippedWeapon = equippedWeapon;
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;

            switch (UserPrayer)
            {
                case Prayer.Thor:
                    HitChance += 6;
                    Block = Block;
                    MaxLife += 10;
                    Life = MaxLife;
                    break;
                case Prayer.Loki:
                    HitChance += 10;
                    Block = Block;
                    MaxLife += 6;
                    Life = MaxLife;
                    break;
                case Prayer.Magni:
                    HitChance = HitChance;
                    Block += 5;
                    MaxLife += 10;
                    Life = MaxLife;
                    break;
                case Prayer.NoGod:
                    HitChance -= 2;
                    Block -= 3;
                    MaxLife -= 5;
                    Life = MaxLife;
                    break;
                case Prayer.Invalid:
                    HitChance = HitChance;
                    Block = Block;
                    MaxLife = MaxLife;
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {

            return$"\n--- {Name} ---\n" +
                $"Life: {Life} / {MaxLife}\n" +
                $"Hit Chance: {HitChance}\n" +
                $"Block: {Block}\n" +
     $"You prayed to {UserPrayer} and chose to carry the {EquippedWeapon.Name}\n";
        }
        public override int CalcDamage()
        {
            //create random object
            Random rand = new Random();
            //determine damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //return the damage
            return damage;
        }
        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
    }
}