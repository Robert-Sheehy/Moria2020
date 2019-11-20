using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armour : Item
{
    

    internal enum Slots { Torso, Head, Hands, Feet, Weapon, Neck, RightHandRing, LeftHandRing, Torch,
        Shield, Back
    }
    internal Slots slot;
    internal int AC;

    internal Armour(string Name, string ModelName, float Weight, int Level, int Cost, int magic_Level, int ACin, Slots inSlot)
    {
        itemName = Name;
        ModelFilename = ModelName;
        itemWieght = Weight;
        AC = ACin;
        min_level = Level;
        itemCost = Cost;
        itemMagicLevel = magic_Level;
        slot = inSlot;
        


    }
    
    



}
