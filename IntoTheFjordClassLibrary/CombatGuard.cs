using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace IntoTheFjordClassLibrary
{
    public class CombatGuard
    {

        public static void DoAttackPlayer(CompletedPlayer attacker, Enemy defender)//Just a class for attacking
        {
            int chance = new Random().Next(1, 101);

            if (chance <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //Calculates damage if enemy is hit
                int damageDealt = attacker.CalcDamage();
                //Assigns the damage
                defender.Life -= damageDealt;
                #region Responses for attack
                string[] Response = {$"Swinging down from overhead you strike the {defender.Name} and you deal {damageDealt} damage!",
                    $"With a powerful backhand swing you deal {damageDealt} damage to {defender.Name}.",
                    $"Lunging forward you strike the {defender.Name} with a glancing blow, you deal {damageDealt} damage.",
                    $"Feigning a defensive stance, you attack. Striking the {defender.Name}, you deal {damageDealt} damage." };
                #endregion
                int RandomIndex = new Random().Next(Response.Length);
                string HitResponse = Response[RandomIndex];
                Console.WriteLine(HitResponse);
            }//End IF statement
            else
            {
                string[] Response = { "Your attack missed!", "They evaded your attack!", "Deflecting the blow with their weapon it did no damage." };
                int RandomIndex = new Random().Next(Response.Length);
                string MissResponse = Response[RandomIndex];
                Console.WriteLine(MissResponse);
            }
        }//End Public static void (DoAttackPlayer)
        public static void DoAttackEnemy(Enemy attacker, CompletedPlayer defender) //Class for enemy attack
        {
            int chance = new Random().Next(1, 101);

            if (chance <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //Calculates damage if hit occurs
                int damageDealt = attacker.CalcDamage();
                //Assigns the damage
                defender.Life -= damageDealt;
                #region Responses for attack
                string[] Response = {$"Swinging wildly from overhead the {attacker.Name} hits and deals {damageDealt} damage to you!",
                    $"With a powerful lunging attack the {attacker.Name} deals {damageDealt} damage.",
                    $"The {attacker.Name} hits you with the blunt end of their weapon, and deals {damageDealt} damage.",
                    $"Feigning an aggressive stance, the {attacker.Name} lands an attack. Dealing {damageDealt} damage to you." };
                #endregion
                int RandomIndex = new Random().Next(Response.Length);
                string HitResponse = Response[RandomIndex];
                Console.WriteLine(HitResponse);
            }//End IF statement
            else
            {
                string[] Response = { "Their attack missed!", "You evaded their attack!", "They showed terrible form and missed horribly", "You move swiftly and dodge their attack." };
                int RandomIndex = new Random().Next(Response.Length);
                string MissResponse = Response[RandomIndex];
                Console.WriteLine(MissResponse);
            }
        }//End Public static void (DoAttackPlayer)

        public static void DoBattle(CompletedPlayer player, Enemy enemyGuardhouse)
        {
            Thread.Sleep(500);
            DoAttackPlayer(player, enemyGuardhouse);
            Thread.Sleep(1000);

            if (enemyGuardhouse.Life > 0)
            {
                Console.WriteLine($"The {enemyGuardhouse.Name} closes in on you for an attack.");
                DoAttackEnemy(enemyGuardhouse, player);
            }
        }

    }//End Class
}//End Name Space