using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class CombatCalcTest : MonoBehaviour
{
    void Start()
    {
        Creature player = new Creature();
        Creature monster = new Creature();
                
        int isHit = Combat.HitCheck(player, monster);

        if (isHit == 0)
        {
            Debug.Log("Attack Missed...");
        }

        if (isHit == 1)
        {
            int damageDealt = Combat.CalcDamage(player, monster, isHit);
            monster.damaged(damageDealt);
            Debug.Log(damageDealt + " Damage Dealt");
        }

        if (isHit == 2)
        {
            int damageDealt = Combat.CalcDamage(player, monster, isHit);
            monster.damaged(damageDealt);
            Debug.Log("Critical Hit!\n" + damageDealt + " Damage Dealt");
        }
    }               
}


