using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class totalDamageBonus : MonoBehaviour
{
    //kept in here
    public int ToDamBonusOnWeapon = 0, ToDamBonusOnItem = 0, ToDamBonusFromSTR = 0;
    //imports from other cs files
    CritProb hitBonus;
    Character_Stats cStrenght;

    //imported from item database
    int weaponDamage = 0, itemDamage = 0;

    //calculates the bonus damage to apply
    void Start()
    {
        ToDamBonusOnWeapon = weaponDamage + hitBonus;
        ToDamBonusOnItem = itemDamage + hitBonus;
        ToDamBonusFromSTR = cStrenght + hitBonus;
    }
}
