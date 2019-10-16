using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;



    public static class Combat
    {
        
    //Attack now moved to Game Manager
    /*public static void Attack(Character_Stats character, Creature victim)
    {
        System.Random roll = new System.Random();
        Creature attacker = new Creature(character);
        int isHit = HitCheck(attacker, victim);

        if(isHit > 0)
        {
            int damageDealt = CalcDamage(attacker, victim, isHit);
            victim.damaged(damageDealt);
            Debug.Log("");
        }
    }

    public static void Attack(Creature attacker, Character_Stats character)
    {
        Creature victim = new Creature(character);
        int isHit = HitCheck(attacker, victim);

        if (isHit > 0)
        {
            int damageDealt = CalcDamage(attacker, victim, isHit);
            victim.damaged(damageDealt);
        }
    }*/

        public static  int HitCheck(Creature attacker, Creature victim /*, int attackType*/)
        {

            System.Random roll = new System.Random();
            int diceRoll = roll.Next(1, 21);

            //Crit Hit and Crit Fail testing
            //diceRoll = 1;
            //diceRoll = 20;

            Debug.Log("Dice Rolled: " + diceRoll);

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
                //Next line would need to be replace with sample code below to allow for non melee combat
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

                Debug.Log("Hit Value after Bonuses: " + hitValue);
                Debug.Log("Victim AC: " + victimAC);

                if (hitValue > victimAC)
                    return 1;
            }

            return 0;
        }

        public static  int CalcDamage(Creature attacker, Creature victim, int isCrit)
        {
            int damageDealt = 0;
            System.Random roll = new System.Random();

            Debug.Log("Rolling " + attacker.getDamageNumber() + "d" + attacker.getDamageRange());

            for (int i = 1; i <= attacker.getDamageNumber(); i++)
            {
                int damageRoll = roll.Next(1, (attacker.getDamageRange() + 1));
                damageDealt += damageRoll;

                Debug.Log("Roll No. " + i + " - Rolled: " + damageRoll);
            }

            Debug.Log("Damage Dealt before bonuses: " + damageDealt);

            //Another line that would need to be updated for non melee combat
            damageDealt += attacker.getStrengthBonus();
            damageDealt += attacker.getDamageBonus();

            Debug.Log("Damage Dealt after bonuses: " + damageDealt);

            if(isCrit == 2)
                damageDealt = (damageDealt * 2);

            return damageDealt;
        }
    }
