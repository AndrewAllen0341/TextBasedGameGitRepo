using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace IntoTheFjordClassLibrary
{
    public class CombatFinalBlock
    {
        public static void DoBlockEnemy(Enemy attacker, CompletedPlayer defender) //Class for enemy attack and player block
        {
            int chance = new Random().Next(1, 101);
            defender.Block += 10;
            if (chance <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //Calculates damage if hit occurs
                attacker.MaxDamage -= 1;
                int damageDealt = attacker.CalcDamage();
                //Assigns the damage
                defender.Life -= damageDealt;
                #region Responses for attack
                string[] Response = {$"Swinging wildly from overhead the {attacker.Name} breaks through your block and deals {damageDealt} damage to you!",
                    $"With a powerful swing the {attacker.Name} deals {damageDealt} damage.",
                    $"The {attacker.Name} hits you with the blunt end of their weapon, and deals {damageDealt} damage.",
                    $"Feigning an aggressive stance, the {attacker.Name} lands an attack. Dealing {damageDealt} damage to you."
                };
                #endregion
                int RandomIndex = new Random().Next(Response.Length);
                string HitResponse = Response[RandomIndex];
                Console.WriteLine(HitResponse);
                defender.Block -= 10;
            }//End IF statement
            else
            {
                string[] Response = { "Their attack was successfully blocked.", "You blocked their attack!", "They showed terrible form and missed horribly", "Deflecting the blow with you weapon it did no damage." };
                int RandomIndex = new Random().Next(Response.Length);
                string MissResponse = Response[RandomIndex];
                Console.WriteLine(MissResponse);
                defender.Block -= 10;
            }
        }//End Public static void (DoAttackPlayer)

        public static void DoBattleBlock(CompletedPlayer player, Enemy enemy)
        {
            Thread.Sleep(500);
            Console.WriteLine("You get in a defensive stance, anticipating an attack.");
            Thread.Sleep(1000);

            if (enemy.Life > 0)
            {
                Console.WriteLine($"The {enemy.Name} closes in on you for an attack.");
                Thread.Sleep(1000);
                DoBlockEnemy(enemy, player);
            }
        }

    }//End Class
}//End Name Space
