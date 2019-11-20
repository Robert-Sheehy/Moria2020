using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment 
{
    int NUMBER_OF_EQUIPMENT_SLOTS = 11;
    public Equipment()
    {
        equipment = new Item[NUMBER_OF_EQUIPMENT_SLOTS];
    }
    Item[] equipment;





    public Item equip(Weapon newWeapon)
    {
        if (equipment[(int)Armour.Slots.Weapon] == null)
        {
            equipment[(int)Armour.Slots.Weapon] = newWeapon;
            return null;
        }
        else
        {   Item hold = equipment[(int)Armour.Slots.Weapon];
            equipment[(int)Armour.Slots.Weapon] = newWeapon;
            return hold;

        }
    }

    internal void equip(Item item)
    {
        if (item is Weapon) equip(item as Weapon);
        if (item is Armour) equip(item as Armour);
    }

    public int Total_Damage_Bonus()
    {
        Weapon weapon = (Weapon) equipment[(int)Armour.Slots.Weapon];
        if (weapon is Weapon)
            return weapon.magic_damage;

        return 0;


    }

    public int Total_Hit_Bonus()

    {
        int total_hit = 0;

        foreach (Item i in equipment)
            total_hit += i.itemMagicLevel;

        return total_hit;

    }

    public int Total_AC()

    {
        int total_ac = 0;

        foreach (Item i in equipment)
            if (i is Armour) total_ac += (i as Armour).AC;

        return total_ac;

    }
    public Item equip(Armour newArmour)
    {
        if (equipment[(int)newArmour.slot] == null)
        {
            equipment[(int)newArmour.slot] = newArmour;
            return null;
        }
        else
        {
            Item hold = equipment[(int)newArmour.slot];
            equipment[(int)newArmour.slot] = newArmour;
            return hold;

        }
    }
}
