using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolls : Item
{

    internal Scrolls(string Name, string ModelName, int Level, int Cost)
    {
        itemName = Name;
        ModelFilename = ModelName;
        min_level = Level;
        itemCost = Cost;

    }
}
