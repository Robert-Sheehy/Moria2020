using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amulets : Item
{
    int itemCostPlus;
    int max_range;
    int min_range;

    internal Amulets(string Name, string ModelName, int Level, int Cost, int CostPlus, int MinR, int MaxR)
    {
        itemName = Name;
        ModelFilename = ModelName;
        min_level = Level;
        itemCost = Cost;
        itemCostPlus = CostPlus;
        min_range = MinR;
        max_range = MaxR;
    }
}
