using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculation : MonoBehaviour
{
    //to be imported
    public int damageOfWeapon, EGO, weight;
    //to be kept in script
    public int totalDamage, randomNum = 0, severityLevel = 0,CritHitBonus;
    //importing from CritProb
    CritProb canCrit,canGetHitBonus,hitBonus;
    totalDamageBonus ToDamBonusOnWeapon, ToDamBonusOnItem, ToDamBonusFromSTR;

    public void Update()
    {
        if(canCrit == true)
        {

        }
    }
}
