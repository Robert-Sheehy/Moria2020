using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    int number_of_dice;
    int range_of_dice;
    int magic_damage;
public Weapon(string Name, string ModelName, float Weight, int Level, int Cost,int magic_Level, int NumberOfDice, int RangeOfDice, int Magic_damage)
    {
        itemName = Name;
        ModelFilename = ModelName;
        itemWieght = Weight;
        min_level = Level;
        itemCost = Cost;
        itemMagicLevel = magic_Level;
        number_of_dice = NumberOfDice;
        range_of_dice = RangeOfDice;
        magic_damage = Magic_damage;






    }
}
