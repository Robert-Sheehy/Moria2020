using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diggers : Item
{
    int itemDig;
    int number_of_dice;
    int range_of_dice;

    internal Diggers(string Name, string ModelName, float Weight, int Level, int Cost, int Dig, int NumberOfDice, int RangeOfDice)
    {
        itemName = Name;
        ModelFilename = ModelName;
        itemWieght = Weight;
        min_level = Level;
        itemCost = Cost;
        itemDig = Dig;
        number_of_dice = NumberOfDice;
        range_of_dice = RangeOfDice;

    }
}
