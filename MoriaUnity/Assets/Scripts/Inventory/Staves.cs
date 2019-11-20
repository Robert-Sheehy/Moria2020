using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staves : Item
{
    internal Staves(string Name, string ModelName, int Level, int Cost, int magic_Level)
    {
        itemName = Name;
        ModelFilename = ModelName;
        min_level = Level;
        itemCost = Cost;
        itemMagicLevel = magic_Level;

    }


}
