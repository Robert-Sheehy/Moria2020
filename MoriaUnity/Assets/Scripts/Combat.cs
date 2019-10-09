using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class Combat
    {
        Random roll = new Random();
        public void Attack(Creature attacker, Creature victim)
        {
            int isHit = HitCheck(attacker, victim);
            
            if(isHit > 0)
            {
                int damageDealt = CalcDamage(attacker, victim);
                victim.damaged(damageDealt);
            }
        }

        public int HitCheck(Creature attacker, Creature victim)
        {
            int diceRoll = roll.Next(1, 21);

            if(diceRoll == 1)
            {
                return 0;
            }

            else if(diceRoll == 20)
            {
                return 2;
            }

            else
            {
                int victimAC = victim.getAC();
                int hitValue = diceRoll;
                //Next line would need to be adapted to allow for non melee combat
                hitValue += attacker.getStrengthBonus();

                /* This is sample code for non melee combat calculations
                 * attackType would need to be passed in during the original Attack call
                 
                if (attackType == 0)
                    hitValue += attacker.getStrengthBonus();

                if (attackType == 1)
                    hitValue += attacker.getDexterityBonus();

                if (attackType == 2)
                    hitValue += attacker.getIntelligenceBonus();
                    */

                hitValue += attacker.getHitBonus();

                if (hitValue > victimAC)
                    return 1;
            }

            return 0;
        }

        public int CalcDamage(Creature attacker, Creature victim)
        {
            int damageDealt = 0;

            for (int i = 0; i <= attacker.getDamageNumber(); i++)
            {
                int damageRoll = roll.Next(1, (attacker.getDamageRange() + 1));
                damageDealt += damageRoll;
            }

            //Another line that would need to be updated for non melee combat
            damageDealt += attacker.getStrengthBonus();
            damageDealt += attacker.getDamageBonus();

            return damageDealt;
        }
    }
}