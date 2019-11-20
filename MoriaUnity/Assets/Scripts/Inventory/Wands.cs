using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wands : Item
{
    internal Wands(string Name, string ModelName, float Weight, int Level, int Cost, int magic_Level, int ACin) //, Slots inSlot)
    {
        itemName = Name;
        ModelFilename = ModelName;
        itemWieght = Weight;
       
        min_level = Level;
        itemCost = Cost;
        itemMagicLevel = magic_Level;
    

    }
}
